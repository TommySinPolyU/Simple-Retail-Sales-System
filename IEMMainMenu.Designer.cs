namespace Retail_Sales_SystemV1._0
{
    partial class IEMMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnery = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUM = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.rSSDatabaseDataSet = new Retail_Sales_SystemV1._0.RSSDatabaseDataSet();
            this.modifyRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modifyRecordTableAdapter = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.ModifyRecordTableAdapter();
            this.tableAdapterManager = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AllowMerge = false;
            this.menuBar.AutoSize = false;
            this.menuBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnery,
            this.btnLout,
            this.btnUM,
            this.btnLang});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(970, 69);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // btnery
            // 
            this.btnery.AutoSize = false;
            this.btnery.Checked = true;
            this.btnery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnery.Name = "btnery";
            this.btnery.Size = new System.Drawing.Size(297, 46);
            this.btnery.Text = "Item Enquiry and Maintenance";
            this.btnery.Click += new System.EventHandler(this.btnery_Click);
            // 
            // btnLout
            // 
            this.btnLout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLout.AutoSize = false;
            this.btnLout.Name = "btnLout";
            this.btnLout.Size = new System.Drawing.Size(87, 46);
            this.btnLout.Text = "Logout";
            this.btnLout.Click += new System.EventHandler(this.btnLout_Click);
            // 
            // btnUM
            // 
            this.btnUM.AutoSize = false;
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(185, 46);
            this.btnUM.Text = "User Maintenance";
            this.btnUM.Click += new System.EventHandler(this.btnUM_Click);
            // 
            // btnLang
            // 
            this.btnLang.AutoSize = false;
            this.btnLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEng,
            this.btnSC,
            this.btnTC});
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(111, 46);
            this.btnLang.Text = "Language";
            // 
            // btnEng
            // 
            this.btnEng.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(207, 32);
            this.btnEng.Text = "English";
            this.btnEng.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // btnSC
            // 
            this.btnSC.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(207, 32);
            this.btnSC.Text = "Simplified Chinese";
            this.btnSC.Click += new System.EventHandler(this.simplifiedChineseToolStripMenuItem_Click);
            // 
            // btnTC
            // 
            this.btnTC.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(207, 32);
            this.btnTC.Text = "Traditional Chinese";
            this.btnTC.Click += new System.EventHandler(this.traditionalChineseToolStripMenuItem_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbInfo.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbInfo.Location = new System.Drawing.Point(700, 0);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(180, 69);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TabStop = false;
            // 
            // rSSDatabaseDataSet
            // 
            this.rSSDatabaseDataSet.DataSetName = "RSSDatabaseDataSet";
            this.rSSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modifyRecordBindingSource
            // 
            this.modifyRecordBindingSource.DataMember = "ModifyRecord";
            this.modifyRecordBindingSource.DataSource = this.rSSDatabaseDataSet;
            // 
            // modifyRecordTableAdapter
            // 
            this.modifyRecordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemListTableAdapter = null;
            this.tableAdapterManager.ItemPriceTableAdapter = null;
            this.tableAdapterManager.ModifyRecordTableAdapter = this.modifyRecordTableAdapter;
            this.tableAdapterManager.ShopItemTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // IEMMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 581);
            this.ControlBox = false;
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IEMMainMenu";
            this.Text = "RSS - Item Enquiry and Maintenance";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Resize += new System.EventHandler(this.IEMMainMenu_Resize);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem btnLout;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.ToolStripMenuItem btnEng;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
        public System.Windows.Forms.ToolStripMenuItem btnery;
        public System.Windows.Forms.ToolStripMenuItem btnLang;
        public System.Windows.Forms.ToolStripMenuItem btnUM;
        private RSSDatabaseDataSet rSSDatabaseDataSet;
        private System.Windows.Forms.BindingSource modifyRecordBindingSource;
        private RSSDatabaseDataSetTableAdapters.ModifyRecordTableAdapter modifyRecordTableAdapter;
        private RSSDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}