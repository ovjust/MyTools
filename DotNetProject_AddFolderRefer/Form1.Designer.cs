namespace DotNetProject_AddFolderRefer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.txtDll = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目根目录:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "引用路径:";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(453, 8);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "浏览目录";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(453, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(128, 190);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 23);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "执行修改";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(84, 13);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(363, 21);
            this.txtRoot.TabIndex = 5;
            this.txtRoot.Text = "E:\\CRM_COM_SVN\\003 系统编码\\branch\\CHCRM_Solution_wfTools\\";
            // 
            // txtDll
            // 
            this.txtDll.Location = new System.Drawing.Point(84, 43);
            this.txtDll.Name = "txtDll";
            this.txtDll.Size = new System.Drawing.Size(288, 21);
            this.txtDll.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "E:\\CHCrmSvn\\commonDlls\\",
            "E:\\CHCrmSvn\\DevExpress.DLL.14.1.4\\",
            "E:\\CHCrmSvn\\OralceWorkFlow\\",
            "E:\\CHCrmSvn\\npoi_dotnet3.5\\"});
            this.checkedListBox1.Location = new System.Drawing.Point(60, 70);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(468, 100);
            this.checkedListBox1.TabIndex = 7;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(378, 41);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 8;
            this.btnBrowse2.Text = "浏览目录";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "请在vs中关闭解决方案，再做此操作";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtDll);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.TextBox txtDll;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label label3;
    }
}

