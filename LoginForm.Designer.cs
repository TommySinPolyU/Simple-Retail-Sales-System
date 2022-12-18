namespace Retail_Sales_SystemV1._0
{
    partial class RSSIEM
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
            this.descr1 = new System.Windows.Forms.Label();
            this.descrSN = new System.Windows.Forms.Label();
            this.descrPW = new System.Windows.Forms.Label();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.btnLang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEng = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.labelbottom = new System.Windows.Forms.Label();
            this.rSSDatabaseDataSet = new Retail_Sales_SystemV1._0.RSSDatabaseDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Retail_Sales_SystemV1._0.RSSDatabaseDataSetTableAdapters.TableAdapterManager();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descr1
            // 
            this.descr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.descr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descr1.Location = new System.Drawing.Point(24, 73);
            this.descr1.Name = "descr1";
            this.descr1.Size = new System.Drawing.Size(584, 33);
            this.descr1.TabIndex = 0;
            this.descr1.Text = "Please Enter The user information for login to system:";
            this.descr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descrSN
            // 
            this.descrSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrSN.Location = new System.Drawing.Point(72, 126);
            this.descrSN.Name = "descrSN";
            this.descrSN.Size = new System.Drawing.Size(165, 27);
            this.descrSN.TabIndex = 1;
            this.descrSN.Text = "Staff Number: ";
            this.descrSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descrPW
            // 
            this.descrPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrPW.Location = new System.Drawing.Point(72, 178);
            this.descrPW.Name = "descrPW";
            this.descrPW.Size = new System.Drawing.Size(132, 27);
            this.descrPW.TabIndex = 2;
            this.descrPW.Text = "Password: ";
            this.descrPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSN
            // 
            this.tbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSN.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbSN.Location = new System.Drawing.Point(241, 123);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(172, 35);
            this.tbSN.TabIndex = 3;
            this.tbSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPW.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbPW.Location = new System.Drawing.Point(241, 178);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(172, 35);
            this.tbPW.TabIndex = 4;
            this.tbPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(434, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 46);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(434, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClean_Click);
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
            this.menuBar.Size = new System.Drawing.Size(632, 45);
            this.menuBar.TabIndex = 7;
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
            this.btnLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(120, 50);
            this.btnLang.Text = "Language";
            // 
            // btnEng
            // 
            this.btnEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(217, 24);
            this.btnEng.Text = "English";
            this.btnEng.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // btnSC
            // 
            this.btnSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(217, 24);
            this.btnSC.Text = "Simplified Chinese";
            this.btnSC.Click += new System.EventHandler(this.simplifiedChineseToolStripMenuItem_Click);
            // 
            // btnTC
            // 
            this.btnTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(217, 24);
            this.btnTC.Text = "Traditional Chinese";
            this.btnTC.Click += new System.EventHandler(this.traditionalChineseToolStripMenuItem_Click);
            // 
            // labelbottom
            // 
            this.labelbottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelbottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbottom.Location = new System.Drawing.Point(24, 232);
            this.labelbottom.Name = "labelbottom";
            this.labelbottom.Size = new System.Drawing.Size(596, 27);
            this.labelbottom.TabIndex = 8;
            this.labelbottom.Text = "648 Games House Retail Sales System - For Staff Only";
            this.labelbottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.rSSDatabaseDataSet;
            // 
            // RSSIEM
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(632, 297);
            this.Controls.Add(this.labelbottom);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbSN);
            this.Controls.Add(this.descrPW);
            this.Controls.Add(this.descrSN);
            this.Controls.Add(this.descr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RSSIEM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS - Item Enquiry and Maintenance - Login System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RSSIEM_FormClosed);
            this.Load += new System.EventHandler(this.RSSIEM_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rSSDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descr1;
        private System.Windows.Forms.Label descrSN;
        private System.Windows.Forms.Label descrPW;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private RSSDatabaseDataSet rSSDatabaseDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private RSSDatabaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private RSSDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem btnLang;
        private System.Windows.Forms.ToolStripMenuItem btnEng;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
        private System.Windows.Forms.Label labelbottom;
    }
}

