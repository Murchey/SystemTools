
namespace SysTools
{
    partial class SysClearForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbTempFolder = new System.Windows.Forms.CheckBox();
            this.cbRubbishBin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cbTempFolder
            // 
            this.cbTempFolder.AutoSize = true;
            this.cbTempFolder.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTempFolder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbTempFolder.Location = new System.Drawing.Point(13, 53);
            this.cbTempFolder.Name = "cbTempFolder";
            this.cbTempFolder.Size = new System.Drawing.Size(503, 35);
            this.cbTempFolder.TabIndex = 5;
            this.cbTempFolder.Text = "清空缓存文件夹       -清除所有系统缓存文件";
            this.cbTempFolder.UseVisualStyleBackColor = true;
            // 
            // cbRubbishBin
            // 
            this.cbRubbishBin.AutoSize = true;
            this.cbRubbishBin.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRubbishBin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbRubbishBin.Location = new System.Drawing.Point(13, 12);
            this.cbRubbishBin.Name = "cbRubbishBin";
            this.cbRubbishBin.Size = new System.Drawing.Size(521, 35);
            this.cbRubbishBin.TabIndex = 4;
            this.cbRubbishBin.Text = "清空回收站             -清除回收站内的所有文件";
            this.cbRubbishBin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(464, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "立即清理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SysClearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(591, 431);
            this.Controls.Add(this.cbTempFolder);
            this.Controls.Add(this.cbRubbishBin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysClearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysClearForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox cbTempFolder;
        private System.Windows.Forms.CheckBox cbRubbishBin;
        private System.Windows.Forms.Button button1;
    }
}