namespace Retail_Sales_SystemV1._0
{
    partial class UserMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMaintenance));
            this.rSSDatabaseDataSet = new Retail_Sales_SystemV1._0.RSSDatabaseDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager();
            this.staffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorClearandAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.staffNumberTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accessRightCheckBox = new System.Windows.Forms.CheckBox();
            this.staffNumberLabel = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblJT = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblAR = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblDesc = new System.Windows.Forms.ToolStripLabel();
            this.lblRecord = new System.Windows.Forms.Label();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).BeginInit();
            this.staffBindingNavigator.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rSSDatabaseDataSet
            // 
            this.rSSDatabaseDataSet.DataSetName = "RSSDatabaseDataSet";
            this.rSSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.rSSDatabaseDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemListTableAdapter = null;
            this.tableAdapterManager.ItemPriceTableAdapter = null;
            this.tableAdapterManager.ModifyRecordTableAdapter = null;
            this.tableAdapterManager.ShopItemTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffBindingNavigator
            // 
            this.staffBindingNavigator.AddNewItem = this.bindingNavigatorClearandAdd;
            this.staffBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffBindingNavigator.AutoSize = false;
            this.staffBindingNavigator.BindingSource = this.staffBindingSource;
            this.staffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staffBindingNavigator.DeleteItem = null;
            this.staffBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.staffBindingNavigator.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.staffBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorClearandAdd,
            this.btnConfirmAdd,
            this.bindingNavigatorDeleteItem});
            this.staffBindingNavigator.Location = new System.Drawing.Point(0, 26);
            this.staffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staffBindingNavigator.Name = "staffBindingNavigator";
            this.staffBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.staffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staffBindingNavigator.Size = new System.Drawing.Size(700, 38);
            this.staffBindingNavigator.TabIndex = 0;
            this.staffBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorClearandAdd
            // 
            this.bindingNavigatorClearandAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorClearandAdd.Name = "bindingNavigatorClearandAdd";
            this.bindingNavigatorClearandAdd.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorClearandAdd.Size = new System.Drawing.Size(73, 35);
            this.bindingNavigatorClearandAdd.Text = "加入新的";
            this.bindingNavigatorClearandAdd.Click += new System.EventHandler(this.bindingNavigatorClearandAdd_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 35);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConfirmAdd.Enabled = false;
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.RightToLeftAutoMirrorImage = true;
            this.btnConfirmAdd.Size = new System.Drawing.Size(73, 35);
            this.btnConfirmAdd.Text = "加入新的";
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(43, 35);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // staffNumberTextBox
            // 
            this.staffNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffNumber", true));
            this.staffNumberTextBox.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.staffNumberTextBox.Location = new System.Drawing.Point(252, 158);
            this.staffNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.staffNumberTextBox.Name = "staffNumberTextBox";
            this.staffNumberTextBox.Size = new System.Drawing.Size(236, 41);
            this.staffNumberTextBox.TabIndex = 2;
            this.staffNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffNumberTextBox_KeyPress);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "LastName", true));
            this.lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lastNameTextBox.Location = new System.Drawing.Point(252, 251);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(236, 41);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameTextBox_KeyPress);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "FirstName", true));
            this.firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.firstNameTextBox.Location = new System.Drawing.Point(252, 353);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(236, 41);
            this.firstNameTextBox.TabIndex = 6;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTextBox_KeyPress);
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "JobTitle", true));
            this.jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.jobTitleTextBox.Location = new System.Drawing.Point(252, 449);
            this.jobTitleTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(236, 41);
            this.jobTitleTextBox.TabIndex = 8;
            this.jobTitleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jobTitleTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Password", true));
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passwordTextBox.Location = new System.Drawing.Point(252, 553);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(236, 41);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // accessRightCheckBox
            // 
            this.accessRightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accessRightCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.staffBindingSource, "AccessRight", true));
            this.accessRightCheckBox.Location = new System.Drawing.Point(252, 666);
            this.accessRightCheckBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.accessRightCheckBox.Name = "accessRightCheckBox";
            this.accessRightCheckBox.Size = new System.Drawing.Size(59, 19);
            this.accessRightCheckBox.TabIndex = 12;
            this.accessRightCheckBox.UseVisualStyleBackColor = true;
            this.accessRightCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.accessRightCheckBox_MouseClick);
            // 
            // staffNumberLabel
            // 
            this.staffNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffNumberLabel.AutoSize = true;
            this.staffNumberLabel.Location = new System.Drawing.Point(88, 165);
            this.staffNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.staffNumberLabel.Name = "staffNumberLabel";
            this.staffNumberLabel.Size = new System.Drawing.Size(92, 35);
            this.staffNumberLabel.TabIndex = 13;
            this.staffNumberLabel.Text = "label1";
            // 
            // lblLN
            // 
            this.lblLN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(88, 258);
            this.lblLN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(92, 35);
            this.lblLN.TabIndex = 14;
            this.lblLN.Text = "label1";
            // 
            // lblFN
            // 
            this.lblFN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(88, 360);
            this.lblFN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(92, 35);
            this.lblFN.TabIndex = 15;
            this.lblFN.Text = "label1";
            // 
            // lblJT
            // 
            this.lblJT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJT.AutoSize = true;
            this.lblJT.Location = new System.Drawing.Point(88, 455);
            this.lblJT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJT.Name = "lblJT";
            this.lblJT.Size = new System.Drawing.Size(92, 35);
            this.lblJT.TabIndex = 16;
            this.lblJT.Text = "label1";
            // 
            // lblPW
            // 
            this.lblPW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(88, 559);
            this.lblPW.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(92, 35);
            this.lblPW.TabIndex = 17;
            this.lblPW.Text = "label1";
            // 
            // lblAR
            // 
            this.lblAR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAR.AutoSize = true;
            this.lblAR.Location = new System.Drawing.Point(88, 661);
            this.lblAR.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAR.Name = "lblAR";
            this.lblAR.Size = new System.Drawing.Size(92, 35);
            this.lblAR.TabIndex = 18;
            this.lblAR.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDesc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(155, 22);
            this.lblDesc.Text = "toolStripLabel1";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(15, 710);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(92, 35);
            this.lblRecord.TabIndex = 20;
            this.lblRecord.Text = "label1";
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowUserToAddRows = false;
            this.staffDataGridView.AllowUserToDeleteRows = false;
            this.staffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.staffDataGridView.Location = new System.Drawing.Point(0, 739);
            this.staffDataGridView.MultiSelect = false;
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.ReadOnly = true;
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffDataGridView.Size = new System.Drawing.Size(700, 123);
            this.staffDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StaffNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "StaffNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JobTitle";
            this.dataGridViewTextBoxColumn4.HeaderText = "JobTitle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AccessRight";
            this.dataGridViewCheckBoxColumn1.HeaderText = "AccessRight";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // UserMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 859);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblAR);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblJT);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.staffNumberLabel);
            this.Controls.Add(this.accessRightCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.staffNumberTextBox);
            this.Controls.Add(this.staffBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMaintenance";
            this.Text = "User Maintenance";
            this.Load += new System.EventHandler(this.UserMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).EndInit();
            this.staffBindingNavigator.ResumeLayout(false);
            this.staffBindingNavigator.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RSSDatabaseDataSet rSSDatabaseDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private RSSDatabaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private RSSDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staffBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorClearandAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox staffNumberTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox accessRightCheckBox;
        private System.Windows.Forms.Label staffNumberLabel;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblJT;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblAR;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblDesc;
        private System.Windows.Forms.ToolStripButton btnConfirmAdd;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}