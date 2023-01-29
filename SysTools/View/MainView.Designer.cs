
namespace SysTools
{
    partial class MainView
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buMoreTools = new System.Windows.Forms.Button();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.buTools = new System.Windows.Forms.Button();
            this.buSysSpeed = new System.Windows.Forms.Button();
            this.buSysTest = new System.Windows.Forms.Button();
            this.buSysClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buClose = new System.Windows.Forms.Button();
            this.buMin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buMoreTools);
            this.panel1.Controls.Add(this.txtOrders);
            this.panel1.Controls.Add(this.buTools);
            this.panel1.Controls.Add(this.buSysSpeed);
            this.panel1.Controls.Add(this.buSysTest);
            this.panel1.Controls.Add(this.buSysClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 520);
            this.panel1.TabIndex = 0;
            // 
            // buMoreTools
            // 
            this.buMoreTools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buMoreTools.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buMoreTools.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buMoreTools.Image = global::SysTools.Properties.Resources.更多工具;
            this.buMoreTools.Location = new System.Drawing.Point(467, 331);
            this.buMoreTools.Name = "buMoreTools";
            this.buMoreTools.Size = new System.Drawing.Size(139, 177);
            this.buMoreTools.TabIndex = 6;
            this.buMoreTools.Text = "更多工具";
            this.buMoreTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buMoreTools.UseVisualStyleBackColor = true;
            this.buMoreTools.Click += new System.EventHandler(this.buMoreTools_Click);
            // 
            // txtOrders
            // 
            this.txtOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrders.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrders.ForeColor = System.Drawing.Color.White;
            this.txtOrders.Location = new System.Drawing.Point(500, 51);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(352, 30);
            this.txtOrders.TabIndex = 5;
            this.txtOrders.Text = "Type Orders Here";
            this.txtOrders.TextChanged += new System.EventHandler(this.txtOrders_TextChanged);
            this.txtOrders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrders_KeyDown);
            this.txtOrders.Leave += new System.EventHandler(this.txtOrders_Leave);
            this.txtOrders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOrders_MouseDown);
            // 
            // buTools
            // 
            this.buTools.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buTools.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buTools.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buTools.Image = global::SysTools.Properties.Resources.实用工具;
            this.buTools.Location = new System.Drawing.Point(322, 331);
            this.buTools.Name = "buTools";
            this.buTools.Size = new System.Drawing.Size(139, 177);
            this.buTools.TabIndex = 3;
            this.buTools.Text = "系统,网络";
            this.buTools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buTools.UseVisualStyleBackColor = true;
            this.buTools.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buSysSpeed
            // 
            this.buSysSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buSysSpeed.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buSysSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buSysSpeed.Image = global::SysTools.Properties.Resources.优化加速;
            this.buSysSpeed.Location = new System.Drawing.Point(177, 331);
            this.buSysSpeed.Name = "buSysSpeed";
            this.buSysSpeed.Size = new System.Drawing.Size(139, 177);
            this.buSysSpeed.TabIndex = 2;
            this.buSysSpeed.Text = "优化加速";
            this.buSysSpeed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buSysSpeed.UseVisualStyleBackColor = true;
            this.buSysSpeed.Click += new System.EventHandler(this.buSysSpeed_Click);
            // 
            // buSysTest
            // 
            this.buSysTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buSysTest.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buSysTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buSysTest.Image = global::SysTools.Properties.Resources.系统检测;
            this.buSysTest.Location = new System.Drawing.Point(355, 51);
            this.buSysTest.Name = "buSysTest";
            this.buSysTest.Size = new System.Drawing.Size(139, 163);
            this.buSysTest.TabIndex = 1;
            this.buSysTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buSysTest.UseVisualStyleBackColor = true;
            this.buSysTest.Click += new System.EventHandler(this.buSysTest_Click);
            // 
            // buSysClear
            // 
            this.buSysClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buSysClear.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buSysClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buSysClear.Image = global::SysTools.Properties.Resources.电脑清理;
            this.buSysClear.Location = new System.Drawing.Point(19, 331);
            this.buSysClear.Name = "buSysClear";
            this.buSysClear.Size = new System.Drawing.Size(139, 177);
            this.buSysClear.TabIndex = 0;
            this.buSysClear.Text = "系统清理";
            this.buSysClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buSysClear.UseVisualStyleBackColor = true;
            this.buSysClear.Click += new System.EventHandler(this.buSysClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buClose);
            this.panel2.Controls.Add(this.buMin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 45);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "SysTools";
            // 
            // buClose
            // 
            this.buClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClose.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buClose.Location = new System.Drawing.Point(812, 4);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(40, 39);
            this.buClose.TabIndex = 3;
            this.buClose.Text = "×";
            this.buClose.UseVisualStyleBackColor = true;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // buMin
            // 
            this.buMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buMin.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buMin.Location = new System.Drawing.Point(766, 4);
            this.buMin.Name = "buMin";
            this.buMin.Size = new System.Drawing.Size(40, 39);
            this.buMin.TabIndex = 2;
            this.buMin.Text = "-";
            this.buMin.UseVisualStyleBackColor = true;
            this.buMin.Click += new System.EventHandler(this.buMin_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 52);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SysTools \r\nby Murchey\r\n版本: V1.2.2.0";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(855, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysTools";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.Button buMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buSysSpeed;
        private System.Windows.Forms.Button buSysTest;
        private System.Windows.Forms.Button buSysClear;
        private System.Windows.Forms.Button buTools;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Button buMoreTools;
    }
}

