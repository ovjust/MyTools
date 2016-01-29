using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
