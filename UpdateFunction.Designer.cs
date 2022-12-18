namespace Retail_Sales_SystemV1._0
{
    partial class UpdateFunction
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.comBSelectCode = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLocat = new System.Windows.Forms.Label();
            this.comBLocat = new System.Windows.Forms.ComboBox();
            this.lblShelf = new System.Windows.Forms.Label();
            this.comBShelfNum = new System.Windows.Forms.ComboBox();
            this.lblDescBefore = new System.Windows.Forms.Label();
            this.lblDescAfter = new System.Windows.Forms.Label();
            this.lblUpdateLocat = new System.Windows.Forms.Label();
            this.lblShelfUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comBLocationUpdate = new System.Windows.Forms.ComboBox();
            this.comBShelfNumUpdate = new System.Windows.Forms.ComboBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLang});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(475, 40);
            this.menuBar.TabIndex = 20;
            this.menuBar.Text = "menuStrip1";
            // 
            // btnLang
            // 
            this.btnLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEng,
            this.btnSC,
            this.btnTC});
            this.btnLang.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(233, 36);
            this.btnLang.Text = "Select The Language";
            this.btnLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEng
            // 
            this.btnEng.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEng.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEng.Name = "btnEng";
            this.btnEng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEng.Size = new System.Drawing.Size(280, 30);
            this.btnEng.Text = "English";
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnSC
            // 
            this.btnSC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSC.Name = "btnSC";
            this.btnSC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSC.Size = new System.Drawing.Size(280, 30);
            this.btnSC.Text = "Simplified Chinese";
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTC
            // 
            this.btnTC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTC.Name = "btnTC";
            this.btnTC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTC.Size = new System.Drawing.Size(280, 30);
            this.btnTC.Text = "Traditional Chinese";
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // comBSelectCode
            // 
            this.comBSelectCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBSelectCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBSelectCode.FormattingEnabled = true;
            this.comBSelectCode.Location = new System.Drawing.Point(221, 116);
            this.comBSelectCode.Name = "comBSelectCode";
            this.comBSelectCode.Size = new System.Drawing.Size(218, 34);
            this.comBSelectCode.TabIndex = 22;
            this.comBSelectCode.SelectedValueChanged += new System.EventHandler(this.comBSelectCode_SelectedValueChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCode.Location = new System.Drawing.Point(42, 118);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(127, 26);
            this.lblCode.TabIndex = 23;
            this.lblCode.Text = "Item Code: ";
            // 
            // lblLocat
            // 
            this.lblLocat.AutoSize = true;
            this.lblLocat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLocat.Location = new System.Drawing.Point(42, 160);
            this.lblLocat.Name = "lblLocat";
            this.lblLocat.Size = new System.Drawing.Size(116, 26);
            this.lblLocat.TabIndex = 25;
            this.lblLocat.Text = "Location:  ";
            // 
            // comBLocat
            // 
            this.comBLocat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBLocat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBLocat.FormattingEnabled = true;
            this.comBLocat.Location = new System.Drawing.Point(221, 157);
            this.comBLocat.Name = "comBLocat";
            this.comBLocat.Size = new System.Drawing.Size(218, 34);
            this.comBLocat.TabIndex = 24;
            this.comBLocat.SelectedValueChanged += new System.EventHandler(this.comBLocat_SelectedValueChanged);
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShelf.Location = new System.Drawing.Point(42, 200);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(167, 26);
            this.lblShelf.TabIndex = 27;
            this.lblShelf.Text = "Shelf Number:  ";
            // 
            // comBShelfNum
            // 
            this.comBShelfNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBShelfNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBShelfNum.FormattingEnabled = true;
            this.comBShelfNum.Location = new System.Drawing.Point(221, 198);
            this.comBShelfNum.Name = "comBShelfNum";
            this.comBShelfNum.Size = new System.Drawing.Size(218, 34);
            this.comBShelfNum.TabIndex = 26;
            this.comBShelfNum.SelectedValueChanged += new System.EventHandler(this.comBShelfNum_SelectedValueChanged);
            // 
            // lblDescBefore
            // 
            this.lblDescBefore.AutoSize = true;
            this.lblDescBefore.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescBefore.Location = new System.Drawing.Point(57, 54);
            this.lblDescBefore.Name = "lblDescBefore";
            this.lblDescBefore.Size = new System.Drawing.Size(371, 26);
            this.lblDescBefore.TabIndex = 29;
            this.lblDescBefore.Text = "Select The Data you want to update";
            // 
            // lblDescAfter
            // 
            this.lblDescAfter.AutoSize = true;
            this.lblDescAfter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescAfter.Location = new System.Drawing.Point(45, 265);
            this.lblDescAfter.Name = "lblDescAfter";
            this.lblDescAfter.Size = new System.Drawing.Size(400, 52);
            this.lblDescAfter.TabIndex = 30;
            this.lblDescAfter.Text = "            Enter Value For Update\r\nBlank Box if you don\'t want to modify.\r\n";
            // 
            // lblUpdateLocat
            // 
            this.lblUpdateLocat.AutoSize = true;
            this.lblUpdateLocat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUpdateLocat.Location = new System.Drawing.Point(45, 336);
            this.lblUpdateLocat.Name = "lblUpdateLocat";
            this.lblUpdateLocat.Size = new System.Drawing.Size(116, 26);
            this.lblUpdateLocat.TabIndex = 31;
            this.lblUpdateLocat.Text = "Location:  ";
            // 
            // lblShelfUpdate
            // 
            this.lblShelfUpdate.AutoSize = true;
            this.lblShelfUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShelfUpdate.Location = new System.Drawing.Point(42, 397);
            this.lblShelfUpdate.Name = "lblShelfUpdate";
            this.lblShelfUpdate.Size = new System.Drawing.Size(162, 26);
            this.lblShelfUpdate.TabIndex = 33;
            this.lblShelfUpdate.Text = "Shelf Number: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(182, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comBLocationUpdate
            // 
            this.comBLocationUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBLocationUpdate.FormattingEnabled = true;
            this.comBLocationUpdate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comBLocationUpdate.Location = new System.Drawing.Point(221, 333);
            this.comBLocationUpdate.Name = "comBLocationUpdate";
            this.comBLocationUpdate.Size = new System.Drawing.Size(218, 34);
            this.comBLocationUpdate.TabIndex = 35;
            // 
            // comBShelfNumUpdate
            // 
            this.comBShelfNumUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBShelfNumUpdate.FormattingEnabled = true;
            this.comBShelfNumUpdate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comBShelfNumUpdate.Location = new System.Drawing.Point(221, 397);
            this.comBShelfNumUpdate.Name = "comBShelfNumUpdate";
            this.comBShelfNumUpdate.Size = new System.Drawing.Size(218, 34);
            this.comBShelfNumUpdate.TabIndex = 36;
            // 
            // UpdateFunction
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(475, 522);
            this.Controls.Add(this.comBShelfNumUpdate);
            this.Controls.Add(this.comBLocationUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblShelfUpdate);
            this.Controls.Add(this.lblUpdateLocat);
            this.Controls.Add(this.lblDescAfter);
            this.Controls.Add(this.lblDescBefore);
            this.Controls.Add(this.lblShelf);
            this.Controls.Add(this.comBShelfNum);
            this.Controls.Add(this.lblLocat);
            this.Controls.Add(this.comBLocat);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.comBSelectCode);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFunction";
            this.Text = "Update Function";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateFunction_FormClosed);
            this.Load += new System.EventHandler(this.UpdateFunction_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem btnLang;
        private System.Windows.Forms.ToolStripMenuItem btnEng;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
        private System.Windows.Forms.ComboBox comBSelectCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLocat;
        private System.Windows.Forms.ComboBox comBLocat;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.ComboBox comBShelfNum;
        private System.Windows.Forms.Label lblDescBefore;
        private System.Windows.Forms.Label lblDescAfter;
        private System.Windows.Forms.Label lblUpdateLocat;
        private System.Windows.Forms.Label lblShelfUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comBLocationUpdate;
        private System.Windows.Forms.ComboBox comBShelfNumUpdate;
    }
}