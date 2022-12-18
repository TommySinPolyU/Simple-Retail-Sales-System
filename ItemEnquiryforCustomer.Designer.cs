namespace Retail_Sales_SystemV1._0
{
    partial class ItemEnquiryforCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.descSearchBy = new System.Windows.Forms.ToolStripTextBox();
            this.descItemCode = new System.Windows.Forms.ToolStripTextBox();
            this.tbItemCode = new System.Windows.Forms.ToolStripTextBox();
            this.btnLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetailSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.descCategory = new System.Windows.Forms.ToolStripTextBox();
            this.btnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.rSSDatabaseDataSet = new Retail_Sales_SystemV1._0.RSSDatabaseDataSet();
            this.itemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemListTableAdapter = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.ItemListTableAdapter();
            this.tableAdapterManager = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager();
            this.itemPriceTableAdapter = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.ItemPriceTableAdapter();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.detailDescTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.discountsTextBox = new System.Windows.Forms.TextBox();
            this.memberPriceTextBox = new System.Windows.Forms.TextBox();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscounts = new System.Windows.Forms.Label();
            this.lblMemberPrice = new System.Windows.Forms.Label();
            this.comBCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descSearchBy,
            this.descItemCode,
            this.tbItemCode,
            this.btnLang,
            this.btnDetailSearch,
            this.descCategory,
            this.btnReset});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(263, 951);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // descSearchBy
            // 
            this.descSearchBy.AutoSize = false;
            this.descSearchBy.BackColor = System.Drawing.SystemColors.Info;
            this.descSearchBy.Enabled = false;
            this.descSearchBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descSearchBy.Name = "descSearchBy";
            this.descSearchBy.ReadOnly = true;
            this.descSearchBy.Size = new System.Drawing.Size(249, 46);
            this.descSearchBy.Text = "SearchBy";
            this.descSearchBy.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descItemCode
            // 
            this.descItemCode.AutoSize = false;
            this.descItemCode.BackColor = System.Drawing.SystemColors.Info;
            this.descItemCode.Enabled = false;
            this.descItemCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descItemCode.Name = "descItemCode";
            this.descItemCode.ReadOnly = true;
            this.descItemCode.Size = new System.Drawing.Size(249, 46);
            this.descItemCode.Text = "ItemCode";
            this.descItemCode.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbItemCode
            // 
            this.tbItemCode.AutoSize = false;
            this.tbItemCode.BackColor = System.Drawing.SystemColors.Window;
            this.tbItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbItemCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Size = new System.Drawing.Size(249, 46);
            this.tbItemCode.TextChanged += new System.EventHandler(this.tbItemCode_TextChanged);
            // 
            // btnLang
            // 
            this.btnLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLang.AutoSize = false;
            this.btnLang.BackColor = System.Drawing.SystemColors.Info;
            this.btnLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEng,
            this.btnSC,
            this.btnTC});
            this.btnLang.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(188, 40);
            this.btnLang.Text = "Language";
            // 
            // btnEng
            // 
            this.btnEng.BackColor = System.Drawing.SystemColors.Info;
            this.btnEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(264, 30);
            this.btnEng.Text = "English";
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnSC
            // 
            this.btnSC.BackColor = System.Drawing.SystemColors.Info;
            this.btnSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(264, 30);
            this.btnSC.Text = "Simplified Chinese";
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTC
            // 
            this.btnTC.BackColor = System.Drawing.SystemColors.Info;
            this.btnTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(264, 30);
            this.btnTC.Text = "Traditional Chinese";
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDetailSearch.AutoSize = false;
            this.btnDetailSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(188, 40);
            this.btnDetailSearch.Text = "DetailSearch";
            this.btnDetailSearch.Click += new System.EventHandler(this.btnDetailSearch_Click);
            // 
            // descCategory
            // 
            this.descCategory.AutoSize = false;
            this.descCategory.BackColor = System.Drawing.SystemColors.Info;
            this.descCategory.Enabled = false;
            this.descCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.descCategory.Name = "descCategory";
            this.descCategory.ReadOnly = true;
            this.descCategory.Size = new System.Drawing.Size(249, 46);
            this.descCategory.Text = "Category";
            this.descCategory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnReset.AutoSize = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(188, 40);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rSSDatabaseDataSet
            // 
            this.rSSDatabaseDataSet.DataSetName = "RSSDatabaseDataSet";
            this.rSSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemListBindingSource
            // 
            this.itemListBindingSource.DataMember = "ItemList";
            this.itemListBindingSource.DataSource = this.rSSDatabaseDataSet;
            // 
            // itemListTableAdapter
            // 
            this.itemListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemListTableAdapter = this.itemListTableAdapter;
            this.tableAdapterManager.ItemPriceTableAdapter = this.itemPriceTableAdapter;
            this.tableAdapterManager.ModifyRecordTableAdapter = null;
            this.tableAdapterManager.ShopItemTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemPriceTableAdapter
            // 
            this.itemPriceTableAdapter.ClearBeforeFill = true;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemListBindingSource, "ItemCode", true));
            this.itemCodeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.itemCodeTextBox.Location = new System.Drawing.Point(599, 80);
            this.itemCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(973, 46);
            this.itemCodeTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemListBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(599, 132);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(973, 46);
            this.nameTextBox.TabIndex = 5;
            // 
            // detailDescTextBox
            // 
            this.detailDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemListBindingSource, "DetailDesc", true));
            this.detailDescTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.detailDescTextBox.Location = new System.Drawing.Point(599, 188);
            this.detailDescTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailDescTextBox.Multiline = true;
            this.detailDescTextBox.Name = "detailDescTextBox";
            this.detailDescTextBox.Size = new System.Drawing.Size(973, 123);
            this.detailDescTextBox.TabIndex = 7;
            // 
            // itemPriceBindingSource
            // 
            this.itemPriceBindingSource.DataMember = "ItemPrice";
            this.itemPriceBindingSource.DataSource = this.rSSDatabaseDataSet;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(599, 319);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(973, 46);
            this.priceTextBox.TabIndex = 9;
            // 
            // discountsTextBox
            // 
            this.discountsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceBindingSource, "Discounts", true));
            this.discountsTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.discountsTextBox.Location = new System.Drawing.Point(599, 372);
            this.discountsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discountsTextBox.Name = "discountsTextBox";
            this.discountsTextBox.Size = new System.Drawing.Size(973, 46);
            this.discountsTextBox.TabIndex = 11;
            // 
            // memberPriceTextBox
            // 
            this.memberPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceBindingSource, "MemberPrice", true));
            this.memberPriceTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberPriceTextBox.Location = new System.Drawing.Point(599, 428);
            this.memberPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.memberPriceTextBox.Name = "memberPriceTextBox";
            this.memberPriceTextBox.Size = new System.Drawing.Size(973, 46);
            this.memberPriceTextBox.TabIndex = 13;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSearchResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchResult.Location = new System.Drawing.Point(273, 25);
            this.lblSearchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(293, 51);
            this.lblSearchResult.TabIndex = 14;
            this.lblSearchResult.Text = "SearchResult";
            this.lblSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.AllowUserToResizeColumns = false;
            this.searchDataGridView.AllowUserToResizeRows = false;
            this.searchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.searchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.searchDataGridView.Location = new System.Drawing.Point(273, 528);
            this.searchDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchDataGridView.MultiSelect = false;
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(1389, 424);
            this.searchDataGridView.TabIndex = 15;
            this.searchDataGridView.SelectionChanged += new System.EventHandler(this.searchDataGridView_SelectionChanged);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItemCode.Location = new System.Drawing.Point(349, 84);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(172, 38);
            this.lblItemCode.TabIndex = 16;
            this.lblItemCode.Text = "Item Code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(349, 136);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 38);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDesc.Location = new System.Drawing.Point(349, 191);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(187, 38);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(349, 322);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 38);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price:";
            // 
            // lblDiscounts
            // 
            this.lblDiscounts.AutoSize = true;
            this.lblDiscounts.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscounts.Location = new System.Drawing.Point(349, 376);
            this.lblDiscounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscounts.Name = "lblDiscounts";
            this.lblDiscounts.Size = new System.Drawing.Size(164, 38);
            this.lblDiscounts.TabIndex = 20;
            this.lblDiscounts.Text = "Discounts:";
            // 
            // lblMemberPrice
            // 
            this.lblMemberPrice.AutoSize = true;
            this.lblMemberPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMemberPrice.Location = new System.Drawing.Point(349, 431);
            this.lblMemberPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberPrice.Name = "lblMemberPrice";
            this.lblMemberPrice.Size = new System.Drawing.Size(222, 38);
            this.lblMemberPrice.TabIndex = 21;
            this.lblMemberPrice.Text = "Member Price:";
            // 
            // comBCategory
            // 
            this.comBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBCategory.FormattingEnabled = true;
            this.comBCategory.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.comBCategory.ItemHeight = 38;
            this.comBCategory.Location = new System.Drawing.Point(9, 202);
            this.comBCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBCategory.Name = "comBCategory";
            this.comBCategory.Size = new System.Drawing.Size(249, 46);
            this.comBCategory.TabIndex = 22;
            this.comBCategory.SelectedIndexChanged += new System.EventHandler(this.comBCategory_SelectedIndexChanged);
            // 
            // ItemEnquiryforCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1664, 951);
            this.Controls.Add(this.comBCategory);
            this.Controls.Add(this.lblMemberPrice);
            this.Controls.Add(this.lblDiscounts);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.memberPriceTextBox);
            this.Controls.Add(this.discountsTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.detailDescTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.itemCodeTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEnquiryforCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Enquiry System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemEnquiryforCustomer_FormClosed);
            this.Load += new System.EventHandler(this.ItemEnquiryforCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox descItemCode;
        private RSSDatabaseDataSet rSSDatabaseDataSet;
        private System.Windows.Forms.BindingSource itemListBindingSource;
        private RSSDatabaseDataSetTableAdapters.ItemListTableAdapter itemListTableAdapter;
        private RSSDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RSSDatabaseDataSetTableAdapters.ItemPriceTableAdapter itemPriceTableAdapter;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox detailDescTextBox;
        private System.Windows.Forms.BindingSource itemPriceBindingSource;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox discountsTextBox;
        private System.Windows.Forms.TextBox memberPriceTextBox;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.ToolStripTextBox descSearchBy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscounts;
        private System.Windows.Forms.Label lblMemberPrice;
        private System.Windows.Forms.ToolStripMenuItem btnLang;
        private System.Windows.Forms.ToolStripMenuItem btnEng;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
        private System.Windows.Forms.ToolStripTextBox descCategory;
        private System.Windows.Forms.ToolStripMenuItem btnReset;
        public System.Windows.Forms.DataGridView searchDataGridView;
        public System.Windows.Forms.ToolStripTextBox tbItemCode;
        public System.Windows.Forms.ComboBox comBCategory;
        public System.Windows.Forms.ToolStripMenuItem btnDetailSearch;
    }
}