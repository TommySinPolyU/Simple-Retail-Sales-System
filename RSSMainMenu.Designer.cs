namespace Retail_Sales_SystemV1._0
{
    partial class RSSMainMenu
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
            this.btnIEM = new System.Windows.Forms.Button();
            this.btnCIE = new System.Windows.Forms.Button();
            this.btnOIE = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIEM
            // 
            this.btnIEM.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIEM.Location = new System.Drawing.Point(46, 52);
            this.btnIEM.Name = "btnIEM";
            this.btnIEM.Size = new System.Drawing.Size(341, 40);
            this.btnIEM.TabIndex = 0;
            this.btnIEM.Text = "Item Enquiry and Maintenance System";
            this.btnIEM.UseVisualStyleBackColor = true;
            this.btnIEM.Click += new System.EventHandler(this.btnIEM_Click);
            // 
            // btnCIE
            // 
            this.btnCIE.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIE.Location = new System.Drawing.Point(46, 126);
            this.btnCIE.Name = "btnCIE";
            this.btnCIE.Size = new System.Drawing.Size(341, 40);
            this.btnCIE.TabIndex = 1;
            this.btnCIE.Text = "Item Enquiry System For Customer Use";
            this.btnCIE.UseVisualStyleBackColor = true;
            this.btnCIE.Click += new System.EventHandler(this.btnCIE_Click);
            // 
            // btnOIE
            // 
            this.btnOIE.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOIE.Location = new System.Drawing.Point(46, 199);
            this.btnOIE.Name = "btnOIE";
            this.btnOIE.Size = new System.Drawing.Size(341, 40);
            this.btnOIE.TabIndex = 2;
            this.btnOIE.Text = "Online Item Enquiry";
            this.btnOIE.UseVisualStyleBackColor = true;
            this.btnOIE.Click += new System.EventHandler(this.btnOIE_Click);
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLang});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(426, 32);
            this.menuBar.TabIndex = 8;
            this.menuBar.Text = "menuStrip1";
            // 
            // btnLang
            // 
            this.btnLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLang.AutoSize = false;
            this.btnLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEng,
            this.btnSC,
            this.btnTC});
            this.btnLang.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(120, 50);
            this.btnLang.Text = "Language";
            // 
            // btnEng
            // 
            this.btnEng.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(226, 26);
            this.btnEng.Text = "English";
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnSC
            // 
            this.btnSC.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(226, 26);
            this.btnSC.Text = "Simplified Chinese";
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTC
            // 
            this.btnTC.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(226, 26);
            this.btnTC.Text = "Traditional Chinese";
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // RSSMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 276);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.btnOIE);
            this.Controls.Add(this.btnCIE);
            this.Controls.Add(this.btnIEM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RSSMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSSMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RSSMainMenu_FormClosed);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIEM;
        private System.Windows.Forms.Button btnCIE;
        private System.Windows.Forms.Button btnOIE;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem btnLang;
        private System.Windows.Forms.ToolStripMenuItem btnEng;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
    }
}