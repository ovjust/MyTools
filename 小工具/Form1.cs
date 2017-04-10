using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using 小工具.Common;

namespace 小工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCount_Click(object sender, EventArgs e)
        {
             lblLength.Text=  rtbIn1.Text.Length.ToString();
        }

        private void btnFtp_getList_Click(object sender, EventArgs e)
        {
            txtFtp.Text = FtpTool.FTPGetFileListStr(txtFtpUrl.Text + ":" + txtFtpPort.Text, txtFtpUid.Text, txtFtpPwd.Text);
        }

        private void btnRowNum_Click(object sender, EventArgs e)
        {
            var sep = txtRowNum.Text;
            var lines = rtbIn1.Lines;
            for (var i = 0; i < lines.Count(); i++)
            {
                var index = lines[i].IndexOf(sep);
                if (index != -1)
                {
                    var res = lines[i].Substring(index + 1);
                    lines[i] = res;
                    //rtbIn1.Lines[i] = res;//没有效果，rtbIn1.Lines[i]中的值不会改变
                }
            }
            rtbIn1.Lines = lines;
        }

        private void btnDelNum_Click(object sender, EventArgs e)
        {
           var lines= richTextBox1In.Lines;
           for (var row=0;row<lines.Length;row++) 
           {
               var line=lines[row];
               var removeEnd = 0;
               bool nowCharEmpty = true;
               for (var i = 0; i < line.Length; i++)
               {
                   char ch = line[i];
                   if (nowCharEmpty)
                   {
                       if (!char.IsWhiteSpace(ch))
                       {
                           nowCharEmpty = false;
                       }
                   }
                   else
                   {
                       if (char.IsWhiteSpace(ch))
                       {
                           removeEnd = i;
                           break;
                       }
                   }
               }
               lines[row] = line.Substring(removeEnd);
           }
           richTextBox2Out.Lines = lines;
        }

        private void btnShowExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select, " + txtPath.Text);
        }

        private void btnShowExplorer2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
            Process.Start("explorer.exe");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtPath.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox
            //MessageBox.Show(
        }

        private void btnSqlUpdate_Click(object sender, EventArgs e)
        {
            if (richTextBox1In.Text == string.Empty)
            {
                MessageBox.Show("输入值为空");
                return;
            }
            string text = richTextBox1In.Text;
            //text = @"  insert  XPParameter (ID,Name,Age) values (1,'aa,b''b ()',3)";
            string pattern = @"insert\s+(?<table>\S+)\s*\((?<fields>\S+)\)\s*values\s*\((?<values>[\s|\S]+)\)"; //匹配URL的模式,并分组
            MatchCollection mc = Regex.Matches(text, pattern); //满足pattern的匹配集合
            List<string> parts = new List<string>();
            if (mc.Count == 0)
            {
                MessageBox.Show("无法识别输入的sql语句");
                return;
            }
            GroupCollection gc = mc[0].Groups;
                //string outputText =match.Value ;
            string table = gc["table"].Value;
            string fields = gc["fields"].Value;
            string values = gc["values"].Value;
            var arrFields = fields.Split(',');
            var arrValues = SplitWithPair(values, ',', '\'');
            if (arrFields.Length != arrValues.Count)
            {
                MessageBox.Show("值与字段数量不符");
                return;
            }
            List<string> setFields = new List<string>();
            for (var i = 0; i < arrFields.Length; i++)
                setFields.Add(arrFields[i] + '=' + arrValues[i]);
            string strSetFields = string.Join(",\n", setFields.ToArray());
            string sqlUpdate = string.Format(@"update {0} set {1}",table,strSetFields);
            richTextBox2Out.Text = sqlUpdate;
        }
        List<string> SplitWithPair(string s, char spliter, char pairChar)
        {
            List<string> list = new List<string>();
            s += spliter;
            int start = 0;
            bool isPair = true;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == pairChar)
                    isPair = !isPair;
                else if (s[i] == spliter && isPair)
                {
                   list.Add( s.Substring(start, i - start ));
                   start = i + 1;
                }
            }
            return list;
        }
        void RegexTest1()
        {
            string text = "I've found this amazing URL at http://www.sohu.com ,and then find ftp://ftp.sohu.com is better.";
            string pattern = @"\b(?<protocol>\S+)://(?<address>\S+)\b"; //匹配URL的模式,并分组
            MatchCollection mc = Regex.Matches(text, pattern); //满足pattern的匹配集合

            Console.WriteLine("文本中包含的URL地址有：");
            foreach (Match match in mc)
            {
                GroupCollection gc = match.Groups;
                string outputText = "URL:" + match.Value + "；Protocol:" + gc["protocol"].Value + "；Address:" + gc["address"].Value;
                Console.WriteLine(outputText);
            }
        }
    }
}
