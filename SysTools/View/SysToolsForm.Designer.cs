
namespace SysTools
{
    partial class SysToolsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buCancel = new System.Windows.Forms.Button();
            this.buClose = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.buTimer = new System.Windows.Forms.Button();
            this.buShut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSearchEngine = new System.Windows.Forms.ComboBox();
            this.buSearch = new System.Windows.Forms.Button();
            this.buCleanSearchTxt = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buTskmgr = new System.Windows.Forms.Button();
            this.buWrite = new System.Windows.Forms.Button();
            this.buNotepad = new System.Windows.Forms.Button();
            this.buRegSys = new System.Windows.Forms.Button();
            this.buFileSys = new System.Windows.Forms.Button();
            this.buBrowser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buWeb7 = new System.Windows.Forms.Button();
            this.buWeb8 = new System.Windows.Forms.Button();
            this.buWeb4 = new System.Windows.Forms.Button();
            this.buWeb9 = new System.Windows.Forms.Button();
            this.buWeb1 = new System.Windows.Forms.Button();
            this.buWeb6 = new System.Windows.Forms.Button();
            this.buWeb2 = new System.Windows.Forms.Button();
            this.buWeb3 = new System.Windows.Forms.Button();
            this.buWeb5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buCancel);
            this.groupBox1.Controls.Add(this.buClose);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.buTimer);
            this.groupBox1.Controls.Add(this.buShut);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自定义关机";
            // 
            // buCancel
            // 
            this.buCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buCancel.Location = new System.Drawing.Point(608, 27);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(102, 34);
            this.buCancel.TabIndex = 3;
            this.buCancel.Text = "取消定时";
            this.buCancel.UseVisualStyleBackColor = true;
            this.buCancel.Click += new System.EventHandler(this.buCancel_Click);
            // 
            // buClose
            // 
            this.buClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buClose.Location = new System.Drawing.Point(114, 27);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(102, 34);
            this.buClose.TabIndex = 1;
            this.buClose.Text = "立即注销";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTime.Location = new System.Drawing.Point(222, 33);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(261, 28);
            this.txtTime.TabIndex = 2;
            this.txtTime.Text = "输入时长（分钟）";
            this.txtTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTime_MouseClick);
            // 
            // buTimer
            // 
            this.buTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buTimer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buTimer.Location = new System.Drawing.Point(500, 27);
            this.buTimer.Name = "buTimer";
            this.buTimer.Size = new System.Drawing.Size(102, 34);
            this.buTimer.TabIndex = 1;
            this.buTimer.Text = "定时关机";
            this.buTimer.UseVisualStyleBackColor = true;
            this.buTimer.Click += new System.EventHandler(this.buTimer_Click);
            // 
            // buShut
            // 
            this.buShut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buShut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buShut.Location = new System.Drawing.Point(6, 27);
            this.buShut.Name = "buShut";
            this.buShut.Size = new System.Drawing.Size(102, 34);
            this.buShut.TabIndex = 0;
            this.buShut.Text = "立即关机";
            this.buShut.UseVisualStyleBackColor = true;
            this.buShut.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSearchEngine);
            this.groupBox2.Controls.Add(this.buSearch);
            this.groupBox2.Controls.Add(this.buCleanSearchTxt);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.buTskmgr);
            this.groupBox2.Controls.Add(this.buWrite);
            this.groupBox2.Controls.Add(this.buNotepad);
            this.groupBox2.Controls.Add(this.buRegSys);
            this.groupBox2.Controls.Add(this.buFileSys);
            this.groupBox2.Controls.Add(this.buBrowser);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统组件";
            // 
            // cbSearchEngine
            // 
            this.cbSearchEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbSearchEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchEngine.ForeColor = System.Drawing.Color.White;
            this.cbSearchEngine.FormattingEnabled = true;
            this.cbSearchEngine.Items.AddRange(new object[] {
            "Bing-必应",
            "Zhihu-知乎",
            "Baidu-百度",
            "Bilibili-哔哩哔哩",
            "Github",
            "Google-谷歌",
            "Twitter-推特",
            "Youtube-油管"});
            this.cbSearchEngine.Location = new System.Drawing.Point(500, 67);
            this.cbSearchEngine.Name = "cbSearchEngine";
            this.cbSearchEngine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSearchEngine.Size = new System.Drawing.Size(250, 28);
            this.cbSearchEngine.TabIndex = 12;
            this.cbSearchEngine.Text = "Bing-必应";
            // 
            // buSearch
            // 
            this.buSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buSearch.Location = new System.Drawing.Point(634, 27);
            this.buSearch.Name = "buSearch";
            this.buSearch.Size = new System.Drawing.Size(116, 34);
            this.buSearch.TabIndex = 9;
            this.buSearch.Text = "搜索";
            this.buSearch.UseVisualStyleBackColor = true;
            this.buSearch.Click += new System.EventHandler(this.buSearch_Click);
            // 
            // buCleanSearchTxt
            // 
            this.buCleanSearchTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buCleanSearchTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buCleanSearchTxt.Location = new System.Drawing.Point(599, 29);
            this.buCleanSearchTxt.Name = "buCleanSearchTxt";
            this.buCleanSearchTxt.Size = new System.Drawing.Size(29, 30);
            this.buCleanSearchTxt.TabIndex = 8;
            this.buCleanSearchTxt.Text = "×";
            this.buCleanSearchTxt.UseVisualStyleBackColor = true;
            this.buCleanSearchTxt.Click += new System.EventHandler(this.buCleanSearchTxt_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSearch.Location = new System.Drawing.Point(19, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(583, 30);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "搜索框（在此处输入内容进行搜索）";
            this.txtSearch.Click += new System.EventHandler(this.textBox1_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // buTskmgr
            // 
            this.buTskmgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buTskmgr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buTskmgr.Location = new System.Drawing.Point(608, 197);
            this.buTskmgr.Name = "buTskmgr";
            this.buTskmgr.Size = new System.Drawing.Size(132, 34);
            this.buTskmgr.TabIndex = 6;
            this.buTskmgr.Text = "任务管理器";
            this.buTskmgr.UseVisualStyleBackColor = true;
            this.buTskmgr.Click += new System.EventHandler(this.buTskmgr_Click);
            // 
            // buWrite
            // 
            this.buWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWrite.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWrite.Location = new System.Drawing.Point(452, 197);
            this.buWrite.Name = "buWrite";
            this.buWrite.Size = new System.Drawing.Size(132, 34);
            this.buWrite.TabIndex = 5;
            this.buWrite.Text = "写字板";
            this.buWrite.UseVisualStyleBackColor = true;
            this.buWrite.Click += new System.EventHandler(this.buWrite_Click);
            // 
            // buNotepad
            // 
            this.buNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buNotepad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buNotepad.Location = new System.Drawing.Point(608, 253);
            this.buNotepad.Name = "buNotepad";
            this.buNotepad.Size = new System.Drawing.Size(132, 34);
            this.buNotepad.TabIndex = 4;
            this.buNotepad.Text = "记事本";
            this.buNotepad.UseVisualStyleBackColor = true;
            this.buNotepad.Click += new System.EventHandler(this.buNotepad_Click);
            // 
            // buRegSys
            // 
            this.buRegSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buRegSys.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buRegSys.Location = new System.Drawing.Point(452, 253);
            this.buRegSys.Name = "buRegSys";
            this.buRegSys.Size = new System.Drawing.Size(132, 34);
            this.buRegSys.TabIndex = 3;
            this.buRegSys.Text = "注册表";
            this.buRegSys.UseVisualStyleBackColor = true;
            this.buRegSys.Click += new System.EventHandler(this.buRegSys_Click);
            // 
            // buFileSys
            // 
            this.buFileSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buFileSys.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buFileSys.Location = new System.Drawing.Point(608, 140);
            this.buFileSys.Name = "buFileSys";
            this.buFileSys.Size = new System.Drawing.Size(132, 34);
            this.buFileSys.TabIndex = 2;
            this.buFileSys.Text = "此电脑";
            this.buFileSys.UseVisualStyleBackColor = true;
            this.buFileSys.Click += new System.EventHandler(this.buFileSys_Click);
            // 
            // buBrowser
            // 
            this.buBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buBrowser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buBrowser.Location = new System.Drawing.Point(452, 140);
            this.buBrowser.Name = "buBrowser";
            this.buBrowser.Size = new System.Drawing.Size(132, 34);
            this.buBrowser.TabIndex = 1;
            this.buBrowser.Text = "浏览器";
            this.buBrowser.UseVisualStyleBackColor = true;
            this.buBrowser.Click += new System.EventHandler(this.buBrowser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buWeb7);
            this.groupBox3.Controls.Add(this.buWeb8);
            this.groupBox3.Controls.Add(this.buWeb4);
            this.groupBox3.Controls.Add(this.buWeb9);
            this.groupBox3.Controls.Add(this.buWeb1);
            this.groupBox3.Controls.Add(this.buWeb6);
            this.groupBox3.Controls.Add(this.buWeb2);
            this.groupBox3.Controls.Add(this.buWeb3);
            this.groupBox3.Controls.Add(this.buWeb5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(19, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 257);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自定义网址栏(软件目录下 Websites.xml)";
            // 
            // buWeb7
            // 
            this.buWeb7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb7.Location = new System.Drawing.Point(13, 186);
            this.buWeb7.Name = "buWeb7";
            this.buWeb7.Size = new System.Drawing.Size(132, 34);
            this.buWeb7.TabIndex = 19;
            this.buWeb7.Text = "Web7";
            this.buWeb7.UseVisualStyleBackColor = true;
            this.buWeb7.Click += new System.EventHandler(this.buWeb7_Click);
            // 
            // buWeb8
            // 
            this.buWeb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb8.Location = new System.Drawing.Point(151, 186);
            this.buWeb8.Name = "buWeb8";
            this.buWeb8.Size = new System.Drawing.Size(132, 34);
            this.buWeb8.TabIndex = 21;
            this.buWeb8.Text = "Web8";
            this.buWeb8.UseVisualStyleBackColor = true;
            this.buWeb8.Click += new System.EventHandler(this.buWeb8_Click);
            // 
            // buWeb4
            // 
            this.buWeb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb4.Location = new System.Drawing.Point(13, 117);
            this.buWeb4.Name = "buWeb4";
            this.buWeb4.Size = new System.Drawing.Size(132, 34);
            this.buWeb4.TabIndex = 14;
            this.buWeb4.Text = "Web4";
            this.buWeb4.UseVisualStyleBackColor = true;
            this.buWeb4.Click += new System.EventHandler(this.buWeb4_Click);
            // 
            // buWeb9
            // 
            this.buWeb9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb9.Location = new System.Drawing.Point(289, 186);
            this.buWeb9.Name = "buWeb9";
            this.buWeb9.Size = new System.Drawing.Size(132, 34);
            this.buWeb9.TabIndex = 20;
            this.buWeb9.Text = "Web9";
            this.buWeb9.UseVisualStyleBackColor = true;
            this.buWeb9.Click += new System.EventHandler(this.buWeb9_Click);
            // 
            // buWeb1
            // 
            this.buWeb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb1.Location = new System.Drawing.Point(13, 47);
            this.buWeb1.Name = "buWeb1";
            this.buWeb1.Size = new System.Drawing.Size(132, 34);
            this.buWeb1.TabIndex = 13;
            this.buWeb1.Text = "Web1";
            this.buWeb1.UseVisualStyleBackColor = true;
            this.buWeb1.Click += new System.EventHandler(this.buWeb1_Click);
            // 
            // buWeb6
            // 
            this.buWeb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb6.Location = new System.Drawing.Point(289, 117);
            this.buWeb6.Name = "buWeb6";
            this.buWeb6.Size = new System.Drawing.Size(132, 34);
            this.buWeb6.TabIndex = 18;
            this.buWeb6.Text = "Web6";
            this.buWeb6.UseVisualStyleBackColor = true;
            this.buWeb6.Click += new System.EventHandler(this.buWeb6_Click);
            // 
            // buWeb2
            // 
            this.buWeb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb2.Location = new System.Drawing.Point(151, 47);
            this.buWeb2.Name = "buWeb2";
            this.buWeb2.Size = new System.Drawing.Size(132, 34);
            this.buWeb2.TabIndex = 17;
            this.buWeb2.Text = "Web2";
            this.buWeb2.UseVisualStyleBackColor = true;
            this.buWeb2.Click += new System.EventHandler(this.buWeb2_Click);
            // 
            // buWeb3
            // 
            this.buWeb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb3.Location = new System.Drawing.Point(289, 47);
            this.buWeb3.Name = "buWeb3";
            this.buWeb3.Size = new System.Drawing.Size(132, 34);
            this.buWeb3.TabIndex = 16;
            this.buWeb3.Text = "Web3";
            this.buWeb3.UseVisualStyleBackColor = true;
            this.buWeb3.Click += new System.EventHandler(this.buWeb3_Click);
            // 
            // buWeb5
            // 
            this.buWeb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buWeb5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buWeb5.Location = new System.Drawing.Point(151, 117);
            this.buWeb5.Name = "buWeb5";
            this.buWeb5.Size = new System.Drawing.Size(132, 34);
            this.buWeb5.TabIndex = 15;
            this.buWeb5.Text = "Web5";
            this.buWeb5.UseVisualStyleBackColor = true;
            this.buWeb5.Click += new System.EventHandler(this.buWeb5_Click);
            // 
            // SysToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(776, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysToolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysToolsForm";
            this.Load += new System.EventHandler(this.SysToolsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button buTimer;
        private System.Windows.Forms.Button buShut;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.Button buCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buBrowser;
        private System.Windows.Forms.Button buFileSys;
        private System.Windows.Forms.Button buRegSys;
        private System.Windows.Forms.Button buNotepad;
        private System.Windows.Forms.Button buWrite;
        private System.Windows.Forms.Button buTskmgr;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button buCleanSearchTxt;
        private System.Windows.Forms.Button buSearch;
        private System.Windows.Forms.ComboBox cbSearchEngine;
        private System.Windows.Forms.Button buWeb8;
        private System.Windows.Forms.Button buWeb9;
        private System.Windows.Forms.Button buWeb7;
        private System.Windows.Forms.Button buWeb6;
        private System.Windows.Forms.Button buWeb2;
        private System.Windows.Forms.Button buWeb3;
        private System.Windows.Forms.Button buWeb5;
        private System.Windows.Forms.Button buWeb4;
        private System.Windows.Forms.Button buWeb1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}