
namespace SysTools
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.buChoseFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.ForeColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(16, 45);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(557, 25);
            this.txtFilePath.TabIndex = 0;
            // 
            // buChoseFile
            // 
            this.buChoseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.buChoseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buChoseFile.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buChoseFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buChoseFile.Location = new System.Drawing.Point(579, 36);
            this.buChoseFile.Name = "buChoseFile";
            this.buChoseFile.Size = new System.Drawing.Size(161, 48);
            this.buChoseFile.TabIndex = 1;
            this.buChoseFile.Text = "选择比对文件";
            this.buChoseFile.UseVisualStyleBackColor = false;
            this.buChoseFile.Click += new System.EventHandler(this.buChoseFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buChoseFile);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择文件（UpdateTest.xml）";
            // 
            // buOK
            // 
            this.buOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.buOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buOK.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buOK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buOK.Location = new System.Drawing.Point(605, 158);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(161, 48);
            this.buOK.TabIndex = 3;
            this.buOK.Text = "确定";
            this.buOK.UseVisualStyleBackColor = false;
            this.buOK.Click += new System.EventHandler(this.buOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "如有升级将立刻跳转至浏览器下载";
            // 
            // UpdateForm
            // 
            this.AcceptButton = this.buChoseFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "升级窗口（内测版）";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button buChoseFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Label label1;
    }
}