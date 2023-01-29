
namespace SysTools
{
    partial class GongShiJiSuanQi
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
            this.cbKinds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pMianJi = new System.Windows.Forms.Panel();
            this.buOK = new System.Windows.Forms.Button();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.cbXingZhuang = new System.Windows.Forms.ComboBox();
            this.pTiJi = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pMianJi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pTiJi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKinds
            // 
            this.cbKinds.AutoCompleteCustomSource.AddRange(new string[] {
            "面积类",
            "体积类",
            "数学类",
            "单位类"});
            this.cbKinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbKinds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKinds.ForeColor = System.Drawing.Color.White;
            this.cbKinds.FormattingEnabled = true;
            this.cbKinds.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbKinds.Items.AddRange(new object[] {
            "数学类",
            "面积类",
            "单位类",
            "体积类"});
            this.cbKinds.Location = new System.Drawing.Point(167, 12);
            this.cbKinds.Name = "cbKinds";
            this.cbKinds.Size = new System.Drawing.Size(244, 28);
            this.cbKinds.TabIndex = 0;
            this.cbKinds.SelectedIndexChanged += new System.EventHandler(this.cbKinds_SelectedIndexChanged);
            this.cbKinds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbKinds_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择计算类型：";
            // 
            // pMianJi
            // 
            this.pMianJi.Controls.Add(this.pTiJi);
            this.pMianJi.Controls.Add(this.buOK);
            this.pMianJi.Controls.Add(this.labelD);
            this.pMianJi.Controls.Add(this.labelC);
            this.pMianJi.Controls.Add(this.labelB);
            this.pMianJi.Controls.Add(this.labelA);
            this.pMianJi.Controls.Add(this.txtResult);
            this.pMianJi.Controls.Add(this.pictureBox1);
            this.pMianJi.Controls.Add(this.txtD);
            this.pMianJi.Controls.Add(this.txtC);
            this.pMianJi.Controls.Add(this.txtB);
            this.pMianJi.Controls.Add(this.txtA);
            this.pMianJi.Controls.Add(this.cbXingZhuang);
            this.pMianJi.Location = new System.Drawing.Point(16, 48);
            this.pMianJi.Name = "pMianJi";
            this.pMianJi.Size = new System.Drawing.Size(972, 540);
            this.pMianJi.TabIndex = 3;
            // 
            // buOK
            // 
            this.buOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buOK.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buOK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buOK.Location = new System.Drawing.Point(281, 442);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(144, 53);
            this.buOK.TabIndex = 14;
            this.buOK.Text = "计算";
            this.buOK.UseVisualStyleBackColor = false;
            this.buOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(42, 326);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(69, 20);
            this.labelD.TabIndex = 13;
            this.labelD.Text = "labelD";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(42, 251);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(69, 20);
            this.labelC.TabIndex = 12;
            this.labelC.Text = "labelC";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(42, 167);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(69, 20);
            this.labelB.TabIndex = 11;
            this.labelB.Text = "labelB";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(42, 88);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(69, 20);
            this.labelA.TabIndex = 10;
            this.labelA.Text = "labelA";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(466, 147);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(464, 348);
            this.txtResult.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(466, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtD.ForeColor = System.Drawing.Color.White;
            this.txtD.Location = new System.Drawing.Point(36, 349);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(389, 30);
            this.txtD.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtC.ForeColor = System.Drawing.Color.White;
            this.txtC.Location = new System.Drawing.Point(36, 274);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(389, 30);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.ForeColor = System.Drawing.Color.White;
            this.txtB.Location = new System.Drawing.Point(36, 190);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(389, 30);
            this.txtB.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.Location = new System.Drawing.Point(36, 111);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(389, 30);
            this.txtA.TabIndex = 4;
            // 
            // cbXingZhuang
            // 
            this.cbXingZhuang.AutoCompleteCustomSource.AddRange(new string[] {
            "平行四边形",
            "梯形",
            "圆形",
            "扇形",
            "椭圆形",
            "三角形",
            "圆环"});
            this.cbXingZhuang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbXingZhuang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbXingZhuang.ForeColor = System.Drawing.Color.White;
            this.cbXingZhuang.FormattingEnabled = true;
            this.cbXingZhuang.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbXingZhuang.Items.AddRange(new object[] {
            "长方形",
            "正方形",
            "平行四边形",
            "椭圆形",
            "圆形",
            "圆环",
            "梯形",
            "三角形"});
            this.cbXingZhuang.Location = new System.Drawing.Point(148, 12);
            this.cbXingZhuang.Name = "cbXingZhuang";
            this.cbXingZhuang.Size = new System.Drawing.Size(247, 28);
            this.cbXingZhuang.TabIndex = 1;
            this.cbXingZhuang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pTiJi
            // 
            this.pTiJi.Controls.Add(this.comboBox1);
            this.pTiJi.Location = new System.Drawing.Point(3, 0);
            this.pTiJi.Name = "pTiJi";
            this.pTiJi.Size = new System.Drawing.Size(972, 540);
            this.pTiJi.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "面积类",
            "体积类",
            "数学类",
            "单位类"});
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "长方体",
            "正方体",
            "球体"});
            this.comboBox1.Location = new System.Drawing.Point(148, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // GongShiJiSuanQi
            // 
            this.AcceptButton = this.buOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1003, 606);
            this.Controls.Add(this.pMianJi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKinds);
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GongShiJiSuanQi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公式计算器";
            this.Load += new System.EventHandler(this.GongShiJiSuanQi_Load);
            this.pMianJi.ResumeLayout(false);
            this.pMianJi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pTiJi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pMianJi;
        private System.Windows.Forms.ComboBox cbXingZhuang;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.Panel pTiJi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}