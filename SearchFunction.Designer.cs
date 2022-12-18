namespace Retail_Sales_SystemV1._0
{
    partial class SearchFunction
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
            this.lblSeaBy = new System.Windows.Forms.Label();
            this.cBName = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.cBCode = new System.Windows.Forms.CheckBox();
            this.cBLocation = new System.Windows.Forms.CheckBox();
            this.cBCategory = new System.Windows.Forms.CheckBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cBPrice = new System.Windows.Forms.CheckBox();
            this.cBPackaging = new System.Windows.Forms.CheckBox();
            this.cBOP = new System.Windows.Forms.CheckBox();
            this.tbMemberPrice = new System.Windows.Forms.TextBox();
            this.cBMemberPrice = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.comBCategory = new System.Windows.Forms.ComboBox();
            this.comBLocation = new System.Windows.Forms.ComboBox();
            this.comBPackaging = new System.Windows.Forms.ComboBox();
            this.cbQuantity = new System.Windows.Forms.CheckBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeaBy
            // 
            this.lblSeaBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeaBy.AutoSize = true;
            this.lblSeaBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeaBy.Location = new System.Drawing.Point(27, 37);
            this.lblSeaBy.Name = "lblSeaBy";
            this.lblSeaBy.Size = new System.Drawing.Size(111, 25);
            this.lblSeaBy.TabIndex = 0;
            this.lblSeaBy.Text = "Search By";
            this.lblSeaBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBName
            // 
            this.cBName.AutoSize = true;
            this.cBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBName.Location = new System.Drawing.Point(12, 87);
            this.cBName.Name = "cBName";
            this.cBName.Size = new System.Drawing.Size(70, 24);
            this.cBName.TabIndex = 2;
            this.cBName.Text = "Name";
            this.cBName.UseVisualStyleBackColor = true;
            this.cBName.CheckedChanged += new System.EventHandler(this.cBName_CheckedChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbName.Location = new System.Drawing.Point(147, 85);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(216, 26);
            this.tbName.TabIndex = 3;
            this.tbName.Visible = false;
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbCode.Location = new System.Drawing.Point(147, 126);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(216, 26);
            this.tbCode.TabIndex = 5;
            this.tbCode.Visible = false;
            // 
            // cBCode
            // 
            this.cBCode.AutoSize = true;
            this.cBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCode.Location = new System.Drawing.Point(12, 128);
            this.cBCode.Name = "cBCode";
            this.cBCode.Size = new System.Drawing.Size(66, 24);
            this.cBCode.TabIndex = 4;
            this.cBCode.Text = "Code";
            this.cBCode.UseVisualStyleBackColor = true;
            this.cBCode.CheckedChanged += new System.EventHandler(this.cBCode_CheckedChanged);
            // 
            // cBLocation
            // 
            this.cBLocation.AutoSize = true;
            this.cBLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBLocation.Location = new System.Drawing.Point(12, 210);
            this.cBLocation.Name = "cBLocation";
            this.cBLocation.Size = new System.Drawing.Size(89, 24);
            this.cBLocation.TabIndex = 8;
            this.cBLocation.Text = "Location";
            this.cBLocation.UseVisualStyleBackColor = true;
            this.cBLocation.CheckedChanged += new System.EventHandler(this.cBLocation_CheckedChanged);
            // 
            // cBCategory
            // 
            this.cBCategory.AutoSize = true;
            this.cBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategory.Location = new System.Drawing.Point(12, 169);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(92, 24);
            this.cBCategory.TabIndex = 6;
            this.cBCategory.Text = "Category";
            this.cBCategory.UseVisualStyleBackColor = true;
            this.cBCategory.CheckedChanged += new System.EventHandler(this.cBCategory_CheckedChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbPrice.Location = new System.Drawing.Point(147, 290);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(216, 26);
            this.tbPrice.TabIndex = 13;
            this.tbPrice.Visible = false;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // cBPrice
            // 
            this.cBPrice.AutoSize = true;
            this.cBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPrice.Location = new System.Drawing.Point(12, 293);
            this.cBPrice.Name = "cBPrice";
            this.cBPrice.Size = new System.Drawing.Size(63, 24);
            this.cBPrice.TabIndex = 12;
            this.cBPrice.Text = "Price";
            this.cBPrice.UseVisualStyleBackColor = true;
            this.cBPrice.CheckedChanged += new System.EventHandler(this.cBPrice_CheckedChanged);
            // 
            // cBPackaging
            // 
            this.cBPackaging.AutoSize = true;
            this.cBPackaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPackaging.Location = new System.Drawing.Point(12, 251);
            this.cBPackaging.Name = "cBPackaging";
            this.cBPackaging.Size = new System.Drawing.Size(102, 24);
            this.cBPackaging.TabIndex = 10;
            this.cBPackaging.Text = "Packaging";
            this.cBPackaging.UseVisualStyleBackColor = true;
            this.cBPackaging.CheckedChanged += new System.EventHandler(this.cBPackaging_CheckedChanged);
            // 
            // cBOP
            // 
            this.cBOP.AutoSize = true;
            this.cBOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBOP.Location = new System.Drawing.Point(12, 375);
            this.cBOP.Name = "cBOP";
            this.cBOP.Size = new System.Drawing.Size(125, 24);
            this.cBOP.TabIndex = 16;
            this.cBOP.Text = "On Promotion";
            this.cBOP.UseVisualStyleBackColor = true;
            this.cBOP.CheckedChanged += new System.EventHandler(this.cBOP_CheckedChanged);
            // 
            // tbMemberPrice
            // 
            this.tbMemberPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbMemberPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberPrice.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbMemberPrice.Location = new System.Drawing.Point(147, 332);
            this.tbMemberPrice.Name = "tbMemberPrice";
            this.tbMemberPrice.ReadOnly = true;
            this.tbMemberPrice.Size = new System.Drawing.Size(216, 26);
            this.tbMemberPrice.TabIndex = 15;
            this.tbMemberPrice.Visible = false;
            this.tbMemberPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMemberPrice_KeyPress);
            // 
            // cBMemberPrice
            // 
            this.cBMemberPrice.AutoSize = true;
            this.cBMemberPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMemberPrice.Location = new System.Drawing.Point(12, 334);
            this.cBMemberPrice.Name = "cBMemberPrice";
            this.cBMemberPrice.Size = new System.Drawing.Size(121, 24);
            this.cBMemberPrice.TabIndex = 14;
            this.cBMemberPrice.Text = "MemberPrice";
            this.cBMemberPrice.UseVisualStyleBackColor = true;
            this.cBMemberPrice.CheckedChanged += new System.EventHandler(this.cBMemberPrice_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(51, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 38);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "Search";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(235, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLang});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(379, 35);
            this.menuBar.TabIndex = 19;
            this.menuBar.Text = "menuStrip1";
            // 
            // btnLang
            // 
            this.btnLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEng,
            this.btnSC,
            this.btnTC});
            this.btnLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(302, 31);
            this.btnLang.Text = "Select The Language to Use for Search";
            this.btnLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEng
            // 
            this.btnEng.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEng.Name = "btnEng";
            this.btnEng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEng.Size = new System.Drawing.Size(213, 24);
            this.btnEng.Text = "English";
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnSC
            // 
            this.btnSC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC.Name = "btnSC";
            this.btnSC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSC.Size = new System.Drawing.Size(213, 24);
            this.btnSC.Text = "Simplified Chinese";
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTC
            // 
            this.btnTC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTC.Name = "btnTC";
            this.btnTC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTC.Size = new System.Drawing.Size(213, 24);
            this.btnTC.Text = "Traditional Chinese";
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // comBCategory
            // 
            this.comBCategory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBCategory.FormattingEnabled = true;
            this.comBCategory.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.comBCategory.Location = new System.Drawing.Point(147, 167);
            this.comBCategory.MaxDropDownItems = 12;
            this.comBCategory.Name = "comBCategory";
            this.comBCategory.Size = new System.Drawing.Size(216, 28);
            this.comBCategory.TabIndex = 20;
            this.comBCategory.Visible = false;
            // 
            // comBLocation
            // 
            this.comBLocation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comBLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBLocation.FormattingEnabled = true;
            this.comBLocation.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.comBLocation.Location = new System.Drawing.Point(147, 208);
            this.comBLocation.MaxDropDownItems = 12;
            this.comBLocation.Name = "comBLocation";
            this.comBLocation.Size = new System.Drawing.Size(216, 28);
            this.comBLocation.TabIndex = 21;
            this.comBLocation.Visible = false;
            // 
            // comBPackaging
            // 
            this.comBPackaging.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comBPackaging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBPackaging.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBPackaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBPackaging.FormattingEnabled = true;
            this.comBPackaging.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.comBPackaging.Location = new System.Drawing.Point(147, 249);
            this.comBPackaging.MaxDropDownItems = 12;
            this.comBPackaging.Name = "comBPackaging";
            this.comBPackaging.Size = new System.Drawing.Size(216, 28);
            this.comBPackaging.TabIndex = 22;
            this.comBPackaging.Visible = false;
            // 
            // cbQuantity
            // 
            this.cbQuantity.AutoSize = true;
            this.cbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantity.Location = new System.Drawing.Point(140, 375);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(113, 24);
            this.cbQuantity.TabIndex = 23;
            this.cbQuantity.Text = "Quantity > 0";
            this.cbQuantity.UseVisualStyleBackColor = true;
            this.cbQuantity.CheckedChanged += new System.EventHandler(this.cBQuantity_CheckedChanged);
            // 
            // SearchFunction
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 488);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.comBPackaging);
            this.Controls.Add(this.comBLocation);
            this.Controls.Add(this.comBCategory);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cBOP);
            this.Controls.Add(this.tbMemberPrice);
            this.Controls.Add(this.cBMemberPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cBPrice);
            this.Controls.Add(this.cBPackaging);
            this.Controls.Add(this.cBLocation);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.cBCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cBName);
            this.Controls.Add(this.lblSeaBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchFunction";
            this.Text = "Search Function";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchFunction_FormClosed);
            this.Load += new System.EventHandler(this.SearchFunction_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeaBy;
        private System.Windows.Forms.CheckBox cBName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.CheckBox cBCode;
        private System.Windows.Forms.CheckBox cBLocation;
        private System.Windows.Forms.CheckBox cBCategory;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.CheckBox cBPrice;
        private System.Windows.Forms.CheckBox cBPackaging;
        private System.Windows.Forms.CheckBox cBOP;
        private System.Windows.Forms.TextBox tbMemberPrice;
        private System.Windows.Forms.CheckBox cBMemberPrice;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem btnLang;
        private System.Windows.Forms.ToolStripMenuItem btnEng;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
        private System.Windows.Forms.ComboBox comBCategory;
        private System.Windows.Forms.ComboBox comBLocation;
        private System.Windows.Forms.ComboBox comBPackaging;
        private System.Windows.Forms.CheckBox cbQuantity;
    }
}