namespace 小工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCount = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRowNum = new System.Windows.Forms.Button();
            this.txtRowNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbIn1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFtp_getList = new System.Windows.Forms.Button();
            this.txtFtp = new System.Windows.Forms.RichTextBox();
            this.txtFtpPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFtpUid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFtpPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFtpUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2Out = new System.Windows.Forms.RichTextBox();
            this.btnDelNum = new System.Windows.Forms.Button();
            this.richTextBox1In = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnShowExplorer2 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnShowExplorer = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(341, 47);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(98, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "计算字符长度";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(410, 32);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(0, 12);
            this.lblLength.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 346);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rtbIn1);
            this.tabPage1.Controls.Add(this.lblLength);
            this.tabPage1.Controls.Add(this.btnCount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "字符长度：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnRowNum);
            this.groupBox2.Controls.Add(this.txtRowNum);
            this.groupBox2.Location = new System.Drawing.Point(6, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "去行号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "分隔符：";
            // 
            // btnRowNum
            // 
            this.btnRowNum.Location = new System.Drawing.Point(6, 67);
            this.btnRowNum.Name = "btnRowNum";
            this.btnRowNum.Size = new System.Drawing.Size(75, 23);
            this.btnRowNum.TabIndex = 5;
            this.btnRowNum.Text = "转换";
            this.btnRowNum.UseVisualStyleBackColor = true;
            this.btnRowNum.Click += new System.EventHandler(this.btnRowNum_Click);
            // 
            // txtRowNum
            // 
            this.txtRowNum.Location = new System.Drawing.Point(6, 40);
            this.txtRowNum.Name = "txtRowNum";
            this.txtRowNum.Size = new System.Drawing.Size(100, 21);
            this.txtRowNum.TabIndex = 7;
            this.txtRowNum.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(333, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文字替换：";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(6, 67);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "转换";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "输入：";
            // 
            // rtbIn1
            // 
            this.rtbIn1.Location = new System.Drawing.Point(3, 18);
            this.rtbIn1.Name = "rtbIn1";
            this.rtbIn1.Size = new System.Drawing.Size(322, 179);
            this.rtbIn1.TabIndex = 3;
            this.rtbIn1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFtp_getList);
            this.tabPage2.Controls.Add(this.txtFtp);
            this.tabPage2.Controls.Add(this.txtFtpPwd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtFtpUid);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtFtpPort);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtFtpUrl);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ftp文件列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFtp_getList
            // 
            this.btnFtp_getList.Location = new System.Drawing.Point(377, 33);
            this.btnFtp_getList.Name = "btnFtp_getList";
            this.btnFtp_getList.Size = new System.Drawing.Size(108, 23);
            this.btnFtp_getList.TabIndex = 9;
            this.btnFtp_getList.Text = "获取文件列表";
            this.btnFtp_getList.UseVisualStyleBackColor = true;
            this.btnFtp_getList.Click += new System.EventHandler(this.btnFtp_getList_Click);
            // 
            // txtFtp
            // 
            this.txtFtp.Location = new System.Drawing.Point(11, 90);
            this.txtFtp.Name = "txtFtp";
            this.txtFtp.Size = new System.Drawing.Size(474, 201);
            this.txtFtp.TabIndex = 8;
            this.txtFtp.Text = "";
            // 
            // txtFtpPwd
            // 
            this.txtFtpPwd.Location = new System.Drawing.Point(251, 60);
            this.txtFtpPwd.Name = "txtFtpPwd";
            this.txtFtpPwd.Size = new System.Drawing.Size(100, 21);
            this.txtFtpPwd.TabIndex = 7;
            this.txtFtpPwd.Text = "o7v4j6t8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "密码：";
            // 
            // txtFtpUid
            // 
            this.txtFtpUid.Location = new System.Drawing.Point(67, 57);
            this.txtFtpUid.Name = "txtFtpUid";
            this.txtFtpUid.Size = new System.Drawing.Size(100, 21);
            this.txtFtpUid.TabIndex = 5;
            this.txtFtpUid.Text = "ovjust";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户名：";
            // 
            // txtFtpPort
            // 
            this.txtFtpPort.Location = new System.Drawing.Point(251, 19);
            this.txtFtpPort.Name = "txtFtpPort";
            this.txtFtpPort.Size = new System.Drawing.Size(100, 21);
            this.txtFtpPort.TabIndex = 3;
            this.txtFtpPort.Text = "21";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口：";
            // 
            // txtFtpUrl
            // 
            this.txtFtpUrl.Location = new System.Drawing.Point(67, 19);
            this.txtFtpUrl.Name = "txtFtpUrl";
            this.txtFtpUrl.Size = new System.Drawing.Size(100, 21);
            this.txtFtpUrl.TabIndex = 1;
            this.txtFtpUrl.Text = "ftp.ibeifeng.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ftp://";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox2Out);
            this.tabPage3.Controls.Add(this.btnDelNum);
            this.tabPage3.Controls.Add(this.richTextBox1In);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(539, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2Out
            // 
            this.richTextBox2Out.Location = new System.Drawing.Point(9, 168);
            this.richTextBox2Out.Name = "richTextBox2Out";
            this.richTextBox2Out.Size = new System.Drawing.Size(384, 144);
            this.richTextBox2Out.TabIndex = 2;
            this.richTextBox2Out.Text = "";
            // 
            // btnDelNum
            // 
            this.btnDelNum.Location = new System.Drawing.Point(420, 88);
            this.btnDelNum.Name = "btnDelNum";
            this.btnDelNum.Size = new System.Drawing.Size(111, 23);
            this.btnDelNum.TabIndex = 1;
            this.btnDelNum.Text = "去数字行号\" 1\"";
            this.btnDelNum.UseVisualStyleBackColor = true;
            this.btnDelNum.Click += new System.EventHandler(this.btnDelNum_Click);
            // 
            // richTextBox1In
            // 
            this.richTextBox1In.Location = new System.Drawing.Point(9, 7);
            this.richTextBox1In.Name = "richTextBox1In";
            this.richTextBox1In.Size = new System.Drawing.Size(384, 144);
            this.richTextBox1In.TabIndex = 0;
            this.richTextBox1In.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnOpenFile);
            this.tabPage4.Controls.Add(this.btnShowExplorer2);
            this.tabPage4.Controls.Add(this.txtPath);
            this.tabPage4.Controls.Add(this.btnShowExplorer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(539, 320);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(181, 51);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(135, 23);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "打开文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnShowExplorer2
            // 
            this.btnShowExplorer2.Location = new System.Drawing.Point(354, 51);
            this.btnShowExplorer2.Name = "btnShowExplorer2";
            this.btnShowExplorer2.Size = new System.Drawing.Size(135, 23);
            this.btnShowExplorer2.TabIndex = 2;
            this.btnShowExplorer2.Text = "显示资源管理器";
            this.btnShowExplorer2.UseVisualStyleBackColor = true;
            this.btnShowExplorer2.Click += new System.EventHandler(this.btnShowExplorer2_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(9, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(422, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\Users\\liyikun.YIGUO\\Desktop\\开发计划.mpp";
            // 
            // btnShowExplorer
            // 
            this.btnShowExplorer.Location = new System.Drawing.Point(6, 51);
            this.btnShowExplorer.Name = "btnShowExplorer";
            this.btnShowExplorer.Size = new System.Drawing.Size(135, 23);
            this.btnShowExplorer.TabIndex = 0;
            this.btnShowExplorer.Text = "在文件夹中显示";
            this.btnShowExplorer.UseVisualStyleBackColor = true;
            this.btnShowExplorer.Click += new System.EventHandler(this.btnShowExplorer_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(539, 320);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbIn1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFtp_getList;
        private System.Windows.Forms.RichTextBox txtFtp;
        private System.Windows.Forms.TextBox txtFtpPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFtpUid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFtpPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFtpUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRowNum;
        private System.Windows.Forms.TextBox txtRowNum;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox2Out;
        private System.Windows.Forms.Button btnDelNum;
        private System.Windows.Forms.RichTextBox richTextBox1In;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnShowExplorer;
        private System.Windows.Forms.Button btnShowExplorer2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

