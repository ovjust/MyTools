using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 小工具
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = richTextBox1.Lines;
            for(var i=0;i<lines.Length;i++)
            {
                var line=lines[i];
                var parts=line.Split(',');
                var field = parts.Length == 2 ? parts[1] : parts[0];
                line += "=s." + field;
                lines[i] = line;
            }
            richTextBox1.Lines = lines;
        }
    }
}
