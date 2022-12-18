using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Retail_Sales_SystemV1._0
{
    public partial class ItemEnquiryandMaintenance : Form
    {
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RSSDatabase.mdb;"; // a setting for the Database file.
        public string language = "";
        public bool isSearched = false;
        public IEMMainMenu mMfrm;
        private SearchFunction sF;
        private UpdateFunction uF;
        public ItemEnquiryandMaintenance()
        {
            InitializeComponent();
        }

        public ItemEnquiryandMaintenance(IEMMainMenu mMfrm1)
        {
            InitializeComponent();
            this.mMfrm = mMfrm1;
            this.language = mMfrm1.language;
        }

        private void ItemEnquiry_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'rSSDatabaseDataSet.Staff' 資料表。您可以視需要進行移動或移除。
            this.modifyRecordTableAdapter.Fill(this.rSSDatabaseDataSet.ModifyRecord);
            isSearched = false;
            switch (language)
            {
                case "English":
                    changeLanguage("English");
                    break;
                case "TraditionalChinese":
                    changeLanguage("TraditionalChinese");
                    break;
                case "SimplifiedChinese":
                    changeLanguage("SimplifiedChinese");
                    break;
            }
        }

        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            switch (Lang)
            {
                case "English":
                    language = "English";
                    if (isSearched == false)
                    {
                        UpdateGrid("SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemList.Category, ItemList.Packaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    }
                    else { UpdateGrid(sF.tosqlStrEng); }
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    if (isSearched == false)
                    {
                        UpdateGrid("SELECT ItemList.ItemCode, ItemList.TCName, ItemList.TCDetailDesc, ItemList.Category, ItemList.TCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    }
                    else { UpdateGrid(sF.tosqlStrTC); }
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    if (isSearched == false)
                    {
                        UpdateGrid("SELECT ItemList.ItemCode, ItemList.SCName, ItemList.SCDetailDesc, ItemList.Category, ItemList.SCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    }
                    else { UpdateGrid(sF.tosqlStrSC); }
                    break;
            }
        }
        private void changeUILang()
        {
            switch (language)
            {
                case "English":
                    language = "English";
                    this.Text = "Item Enquiry System";
                    //Change the column name of data table from Enquiry.
                    dataView.Columns[0].HeaderText = "ItemCode";
                    dataView.Columns[1].HeaderText = "Name";
                    dataView.Columns[2].HeaderText = "DetailDesc";
                    dataView.Columns[3].HeaderText = "Category";
                    dataView.Columns[4].HeaderText = "Packaging";
                    dataView.Columns[5].HeaderText = "Location";
                    dataView.Columns[6].HeaderText = "ShelfNum";
                    dataView.Columns[7].HeaderText = "Quantity";
                    dataView.Columns[8].HeaderText = "Price";
                    dataView.Columns[9].HeaderText = "Discounts";
                    dataView.Columns[10].HeaderText = "MemberPrice";
                    dataView.Columns[11].HeaderText = "onPromotion";

                    //Change the column name of data table from ModifyRecord.
                    modifyRecordDataGridView.Columns[0].HeaderText = "Modify Number";
                    modifyRecordDataGridView.Columns[1].HeaderText = "Item Code";
                    modifyRecordDataGridView.Columns[2].HeaderText = "Staff Number";
                    modifyRecordDataGridView.Columns[3].HeaderText = "Before Shelf Number";
                    modifyRecordDataGridView.Columns[4].HeaderText = "After Shelf Number";
                    modifyRecordDataGridView.Columns[5].HeaderText = "Before Location";
                    modifyRecordDataGridView.Columns[6].HeaderText = "After Location";
                    modifyRecordDataGridView.Columns[7].HeaderText = "Modify Date";

                    btnSearch.Text = "Search";
                    btnReset.Text = "Reset";
                    btnUpdate.Text = "Update";
                    if (modifyRecordDataGridView.Visible == true)
                        cbDisplayRecord.Text = "Hide Modify Records";
                    else
                        cbDisplayRecord.Text = "Display Modify Records";
                    btnExport.Text = "Export";
                    btnImport.Text = "Import";
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    this.Text = "貨品查詢系統";
                    //Change the column name of data table from Enquiry.

                    dataView.Columns[0].HeaderText = "貨品編號";
                    dataView.Columns[1].HeaderText = "貨品名稱";
                    dataView.Columns[2].HeaderText = "貨品說明";
                    dataView.Columns[3].HeaderText = "分類";
                    dataView.Columns[4].HeaderText = "包裝";
                    dataView.Columns[5].HeaderText = "位置";
                    dataView.Columns[6].HeaderText = "貨架編號";
                    dataView.Columns[7].HeaderText = "存貨量";
                    dataView.Columns[8].HeaderText = "售價";
                    dataView.Columns[9].HeaderText = "折扣";
                    dataView.Columns[10].HeaderText = "會員售價";
                    dataView.Columns[11].HeaderText = "正進行促銷";

                    //Change the column name of data table from ModifyRecord.
                    modifyRecordDataGridView.Columns[0].HeaderText = "修改記錄編號";
                    modifyRecordDataGridView.Columns[1].HeaderText = "貨品編號";
                    modifyRecordDataGridView.Columns[2].HeaderText = "修改員工編號";
                    modifyRecordDataGridView.Columns[3].HeaderText = "修改前貨架編號";
                    modifyRecordDataGridView.Columns[4].HeaderText = "修改後貨架編號";
                    modifyRecordDataGridView.Columns[5].HeaderText = "修改前位置";
                    modifyRecordDataGridView.Columns[6].HeaderText = "修改後位置";
                    modifyRecordDataGridView.Columns[7].HeaderText = "修改日期";

                    btnSearch.Text = "搜尋";
                    btnReset.Text = "重置";
                    btnUpdate.Text = "更新";
                    if (modifyRecordDataGridView.Visible == true)
                        cbDisplayRecord.Text = "隱藏更新記錄";
                    else
                        cbDisplayRecord.Text = "顯示更新記錄";
                    btnExport.Text = "資料導出";
                    btnImport.Text = "資料導入";

                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    this.Text = "货品查询系统";
                    dataView.Columns[0].HeaderText = "货品编号";
                    dataView.Columns[1].HeaderText = "货品名称";
                    dataView.Columns[2].HeaderText = "货品说明";
                    dataView.Columns[3].HeaderText = "分类";
                    dataView.Columns[4].HeaderText = "包装";
                    dataView.Columns[5].HeaderText = "位置";
                    dataView.Columns[6].HeaderText = "货架编号";
                    dataView.Columns[7].HeaderText = "存货量";
                    dataView.Columns[8].HeaderText = "售价";
                    dataView.Columns[9].HeaderText = "折扣";
                    dataView.Columns[10].HeaderText = "会员售价";
                    dataView.Columns[11].HeaderText = "正进行促销";

                    //Change the column name of data table from ModifyRecord.
                    modifyRecordDataGridView.Columns[0].HeaderText = "修改记录编号";
                    modifyRecordDataGridView.Columns[1].HeaderText = "货品编号";
                    modifyRecordDataGridView.Columns[2].HeaderText = "修改员工编号";
                    modifyRecordDataGridView.Columns[3].HeaderText = "修改前货架编号";
                    modifyRecordDataGridView.Columns[4].HeaderText = "修改后货架编号";
                    modifyRecordDataGridView.Columns[5].HeaderText = "修改前位置";
                    modifyRecordDataGridView.Columns[6].HeaderText = "修改后位置";
                    modifyRecordDataGridView.Columns[7].HeaderText = "修改日期";

                    btnSearch.Text = "搜寻";
                    btnReset.Text = "重置";
                    btnUpdate.Text = "更新";
                    if (modifyRecordDataGridView.Visible == true)
                        cbDisplayRecord.Text = "隐藏更新记录";
                    else
                        cbDisplayRecord.Text = "显示更新记录";
                    btnExport.Text = "资料导出";
                    btnImport.Text = "资料导入";
                    break;
            }
        }

        public void UpdateGrid(string sqlStr)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dt.Clear();
            dt.Rows.Clear();
            dt.Columns.Clear();
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            dataView.DataSource = dt;
            dataView.Columns[8].DefaultCellStyle.Format = "$#.##";
            dataView.Columns[9].DefaultCellStyle.Format = "$#.##";
            dataView.Columns[10].DefaultCellStyle.Format = "$#.##";
            changeUILang();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            sF = new SearchFunction();
            sF.language = this.language;
            sF.eryfrm = this;
            sF.Show();
            sF.mM = mMfrm;
            mMfrm.sF = sF;
            mMfrm.btnLang.Visible = false;
            mMfrm.btnery.Visible = false;
            mMfrm.btnUM.Visible = false;
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        //Reset all searched details and show all records of table.
        {
            System.Threading.Thread.Sleep(200);
            isSearched = false;
            switch (language)
            {
                case "English":
                    language = "English";
                    UpdateGrid("SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemList.Category, ItemList.Packaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    UpdateGrid("SELECT ItemList.ItemCode, ItemList.TCName, ItemList.TCDetailDesc, ItemList.Category, ItemList.TCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    UpdateGrid("SELECT ItemList.ItemCode, ItemList.SCName, ItemList.SCDetailDesc, ItemList.Category, ItemList.SCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mMfrm.SRight == "True" || mMfrm.SRight == "true")
            {
                uF = new UpdateFunction();
                uF.language = this.language;
                uF.eryfrm = this;
                uF.mM = mMfrm;
                uF.Show();
                mMfrm.uF = uF;
                mMfrm.btnLang.Visible = false;
                mMfrm.btnery.Visible = false;
                mMfrm.btnUM.Visible = false;
                this.Hide();
            }
            else
            {
                switch (language)
                {
                    case "English":
                        MessageBox.Show("You are not allow to update data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "TraditionalChinese":
                        MessageBox.Show("你沒有權限進行更新。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "SimplifiedChinese":
                        MessageBox.Show("你没有权限进行更新。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void cbDisplayRecord_Click(object sender, EventArgs e)
        {
            if (cbDisplayRecord.CheckState == CheckState.Checked)
            {
                cbDisplayRecord.CheckState = CheckState.Unchecked;
                cbDisplayRecord.Checked = false;
                modifyRecordDataGridView.Visible = false;
                switch (language)
                {
                    case "English":
                        cbDisplayRecord.Text = "Display Modify Records";
                        break;

                    case "TraditionalChinese":
                        cbDisplayRecord.Text = "顯示更新記錄";
                        break;

                    case "SimplifiedChinese":
                        cbDisplayRecord.Text = "显示更新记录";
                        break;
                }
            }
            else
            {
                cbDisplayRecord.CheckState = CheckState.Checked;
                cbDisplayRecord.Checked = true;
                modifyRecordDataGridView.Visible = true;
                switch (language)
                {
                    case "English":
                        cbDisplayRecord.Text = "Hide Modify Records";
                        break;

                    case "TraditionalChinese":
                        cbDisplayRecord.Text = "隱藏更新記錄";
                        break;

                    case "SimplifiedChinese":
                        cbDisplayRecord.Text = "隐藏更新记录";
                        break;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Start To Generate the ItemList Files
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            sfd.Filter = "CSV Filetype (*.csv)|*.csv";
            //Set title to each language.
            switch (language)
            {
                case "English":
                    sfd.Title = "Export a CSV File from ItemList";
                    break;
                case "TraditionalChinese":
                    sfd.Title = "導出 ItemList CSV 檔案";
                    break;

                case "SimplifiedChinese":
                    sfd.Title = "导出 ItemList CSV 档案";
                    break;
            }
            sfd.FileName = "ItemList";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connStr;
                string query = "SELECT * FROM ItemList";
                string sep;
                if (Path.GetFileName(sfd.FileName) != "ItemList.csv")
                {
                    if (MessageBox.Show(
                         "It is recommended to use the default file name (ItemList.csv) for generation." + "\r\n\r\nDo you want to save with default name?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        sfd.FileName = "ItemList.csv";
                    }
                }

                string fn = Path.GetFileName(sfd.FileName).ToString();
                StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF8);
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        int fields = dr.FieldCount - 1;
                        dr.Read();
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr.GetName(i) + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr[i] + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        while (dr.Read())
                        {
                            for (int i = 0; i <= fields; i++)
                            {
                                if (i != fields)
                                {
                                    sep = ",";
                                }
                                else
                                {
                                    sep = "";
                                }
                                sb.Append(dr[i].ToString() + sep);
                            }
                            sw.WriteLine(sb.ToString());
                            sb.Clear();
                        }
                    }
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show(fn + " Generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                    }
                    conn.Close();
                    sw.Close();
                }
            }

            //Start To Generate the ItemPrice Files
            sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            sfd.Filter = "CSV Filetype (*.csv)|*.csv";
            //Set title to each language.
            switch (language)
            {
                case "English":
                    sfd.Title = "Export a CSV File from ItemPrice";
                    break;
                case "TraditionalChinese":
                    sfd.Title = "導出 ItemPrice CSV 檔案";
                    break;

                case "SimplifiedChinese":
                    sfd.Title = "导出 ItemPrice CSV 档案";
                    break;
            }

            sfd.FileName = "ItemPrice";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connStr;
                string query = "SELECT * FROM ItemPrice";
                string sep;
                if (Path.GetFileName(sfd.FileName) != "ItemPrice.csv")
                {
                    if (MessageBox.Show(
                         "It is recommended to use the default file name (ItemPrice.csv) for generation." + "\r\n\r\nDo you want to save with default name?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        sfd.FileName = "ItemPrice.csv";
                    }
                }
                string fn = Path.GetFileName(sfd.FileName).ToString();
                StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF8);
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        int fields = dr.FieldCount - 1;
                        dr.Read();
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr.GetName(i) + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr[i] + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        while (dr.Read())
                        {
                            for (int i = 0; i <= fields; i++)
                            {
                                if (i != fields)
                                {
                                    sep = ",";
                                }
                                else
                                {
                                    sep = "";
                                }
                                sb.Append(dr[i].ToString() + sep);
                            }
                            sw.WriteLine(sb.ToString());
                            sb.Clear();
                        }
                    }
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show(fn + " Generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                    }
                    conn.Close();
                    sw.Close();
                }
            }

            //Start To Generate the ShopItem Files
            sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            sfd.Filter = "CSV Filetype (*.csv)|*.csv";
            //Set title to each language.
            switch (language)
            {
                case "English":
                    sfd.Title = "Export a CSV File from ShopItem";
                    break;
                case "TraditionalChinese":
                    sfd.Title = "導出 ShopItem CSV 檔案";
                    break;

                case "SimplifiedChinese":
                    sfd.Title = "导出 ShopItem CSV 档案";
                    break;
            }

            sfd.FileName = "ShopItem";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connStr;
                string query = "SELECT * FROM ShopItem";
                string sep;
                if (Path.GetFileName(sfd.FileName) != "ShopItem.csv")
                {
                    if (MessageBox.Show(
                         "It is recommended to use the default file name (ShopItem.csv) for generation." + "\r\n\r\nDo you want to save with default name?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        sfd.FileName = "ShopItem.csv";
                    }
                }
                string fn = Path.GetFileName(sfd.FileName).ToString();
                StreamWriter sw = new StreamWriter(fn, false, Encoding.UTF8);
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        int fields = dr.FieldCount - 1;
                        dr.Read();
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr.GetName(i) + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr[i] + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        while (dr.Read())
                        {
                            for (int i = 0; i <= fields; i++)
                            {
                                if (i != fields)
                                {
                                    sep = ",";
                                }
                                else
                                {
                                    sep = "";
                                }
                                sb.Append(dr[i].ToString() + sep);
                            }
                            sw.WriteLine(sb.ToString());
                            sb.Clear();
                        }
                    }
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show(fn + " Generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                    }
                    conn.Close();
                    sw.Close();
                }
            }

            //Start To Generate the ModifyRecord Files
            sfd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            sfd.Filter = "CSV Filetype (*.csv)|*.csv";
            //Set title to each language.
            switch (language)
            {
                case "English":
                    sfd.Title = "Export a CSV File from ModifyRecord";
                    break;
                case "TraditionalChinese":
                    sfd.Title = "導出 ModifyRecord CSV 檔案";
                    break;

                case "SimplifiedChinese":
                    sfd.Title = "导出 ModifyRecord CSV 档案";
                    break;
            }
            //
            sfd.FileName = "ModifyRecord";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connStr;
                string query = "SELECT * FROM ModifyRecord";
                string sep;
                if (Path.GetFileName(sfd.FileName) != "ModifyRecord.csv")
                {
                    if (MessageBox.Show(
                         "It is recommended to use the default file name (ModifyRecord.csv) for generation." + "\r\n\r\nDo you want to save with default name?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        sfd.FileName = "ModifyRecord.csv";
                    }
                }
                string fn = Path.GetFileName(sfd.FileName).ToString();
                StreamWriter sw = new StreamWriter(fn,false, Encoding.UTF8);
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        int fields = dr.FieldCount - 1;
                        dr.Read();
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr.GetName(i) + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        for (int i = 0; i <= fields; i++)
                        {
                            if (i != fields)
                            {
                                sep = ",";
                            }
                            else
                            {
                                sep = "";
                            }
                            sb.Append(dr[i] + sep);
                        }
                        sw.WriteLine(sb.ToString());
                        sb.Clear();

                        while (dr.Read())
                        {
                            for (int i = 0; i <= fields; i++)
                            {
                                if (i != fields)
                                {
                                    sep = ",";
                                }
                                else
                                {
                                    sep = "";
                                }
                                sb.Append(dr[i].ToString() + sep);
                            }
                            sw.WriteLine(sb.ToString());
                            sb.Clear();
                        }
                    }
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show(fn + " Generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("生成 " + fn + " 成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                            break;
                    }
                    conn.Close();
                    sw.Close();
                }
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (mMfrm.SRight == "True" || mMfrm.SRight == "true")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                ofd.Filter = "CSV Filetype (*.csv)|*.csv";
                //Set title to each language.
                switch (language)
                {
                    case "English":
                        ofd.Title = "Read a CSV File(ItemList.csv/ItemPrice.csv/ShopItem.csv/ModifyRecord.csv)";
                        break;
                    case "TraditionalChinese":
                        ofd.Title = "導入 CSV 檔案(ItemList.csv/ItemPrice.csv/ShopItem.csv/ModifyRecord.csv)";
                        break;

                    case "SimplifiedChinese":
                        ofd.Title = "导入 CSV 档案(ItemList.csv/ItemPrice.csv/ShopItem.csv/ModifyRecord.csv)";
                        break;
                }
                //
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    String path = ofd.InitialDirectory; // pathname
                    String fn = ofd.SafeFileName; // filename without path

                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = connStr;
                    string query = "";
                    if (Path.GetFileName(ofd.FileName) == "ItemList.csv")
                    {
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            conn.Open();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = @"delete * from ItemList";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = @"insert into ItemList select * from " +
                                              "[Text;FMT=Delimited;HDR=YES;CharacterSet=65001;Database=" +
                                              path + "].[" + fn + "]";
                            cmd.ExecuteNonQuery();
                            switch (language)
                            {
                                case "English":
                                    MessageBox.Show("ItemList updated!But All relative table data are clear.\r\nPlease Import another relative table to make sure The Data integrity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;

                                case "TraditionalChinese":
                                    MessageBox.Show("ItemList 更新成功!但所有關聯資料表均被清除。\r\n請導入其他相關資料表以確保資料完整性。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;

                                case "SimplifiedChinese":
                                    MessageBox.Show("ItemList 更新成功!但所有关联资料表均被清除。\r\n请导入其他相关资料表以确保资料完整性。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    break;
                            }
                        }

                        ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                        ofd.Filter = "CSV Filetype (*.csv)|*.csv";
                        //Set title to each language.
                        switch (language)
                        {
                            case "English":
                                ofd.Title = "Read a CSV File(ItemPrice.csv/ShopItem.csv/ModifyRecord.csv)";
                                break;
                            case "TraditionalChinese":
                                ofd.Title = "導入 CSV 檔案(ItemPrice.csv/ShopItem.csv/ModifyRecord.csv)";
                                break;

                            case "SimplifiedChinese":
                                ofd.Title = "导入 CSV 档案(ItemPrice.csv/ShopItem.csv/ModifyRecord.csv)";
                                break;
                        }
                        switch (language)
                        {
                            case "English":
                                MessageBox.Show("Please Import ItemPrice.csv, ShopItem.csv and ModifyRecord.csv.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                break;

                            case "TraditionalChinese":
                                MessageBox.Show("請導入 ItemPrice.csv, ShopItem.csv 及 ModifyRecord.csv。", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                break;

                            case "SimplifiedChinese":
                                MessageBox.Show("请导入 ItemPrice.csv, ShopItem.csv 及 ModifyRecord.csv。", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                break;
                        }
                        bool isDone = false;
                        string[] csv = new string[3];
                        string[] Title = new string[3];
                        //Set title to each language.
                        switch (language)
                        {
                            case "English":
                                Title[0] = "Read a CSV File(ItemPrice.csv)";
                                Title[1] = "Read a CSV File(ShopItem.csv)";
                                Title[2] = "Read a CSV File(ModifyRecord.csv)";
                                break;
                            case "TraditionalChinese":
                                Title[0] = "導入 CSV 檔案(ItemPrice.csv)";
                                Title[1] = "導入 CSV 檔案(ShopItem.csv)";
                                Title[2] = "導入 CSV 檔案(ModifyRecord.csv)";
                                break;

                            case "SimplifiedChinese":
                                Title[0] = "导入 CSV 档案(ItemPrice.csv)";
                                Title[1] = "导入 CSV 档案(ShopItem.csv)";
                                Title[2] = "导入 CSV 档案(ModifyRecord.csv)";
                                break;
                        }
                        csv[0] = "ItemPrice";
                        csv[1] = "ShopItem";
                        csv[2] = "ModifyRecord";
                        for (int i = 0; i < 3; i++)
                        {
                            isDone = false;
                            conn.Close();

                            while (isDone == false)
                            {
                                ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                                ofd.Filter = "CSV Filetype (*.csv)|*.csv";
                                ofd.Title = Title[i];
                                ofd.FileName = csv[i] + ".csv";
                                if (ofd.ShowDialog() == DialogResult.OK)
                                {
                                    path = ofd.InitialDirectory; // pathname
                                    fn = ofd.SafeFileName; // filename without path
                                    if (Path.GetFileName(ofd.FileName) == (csv[i] + ".csv"))
                                    {
                                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                                        {
                                            conn.Open();
                                            cmd.CommandType = System.Data.CommandType.Text;
                                            cmd.CommandText = @"delete * from " + csv[i];
                                            cmd.ExecuteNonQuery();
                                            cmd.CommandText = @"insert into " + csv[i] + " select * from " +
                                                              "[Text;FMT=Delimited;HDR=YES;CharacterSet=65001;Database=" +
                                                              path + "].[" + fn + "]";
                                            cmd.ExecuteNonQuery();
                                            switch (language)
                                            {
                                                case "English":
                                                    MessageBox.Show(csv[i] + " updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                                    break;

                                                case "TraditionalChinese":
                                                    MessageBox.Show(csv[i] + " 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                                    break;

                                                case "SimplifiedChinese":
                                                    MessageBox.Show(csv[i] + " 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                                    break;
                                            }
                                            isDone = true;
                                        }
                                    }
                                    else
                                    {
                                        switch (language)
                                        {
                                            case "English":
                                                MessageBox.Show("Please Select vaild file with appointed name. \r\nThe Vaild Appointed Name is " + csv[i] + ".csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;

                                            case "TraditionalChinese":
                                                MessageBox.Show("請選擇正確的檔案格式及符合下列命名之檔案。\r\n" + csv[i] + ".csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;

                                            case "SimplifiedChinese":
                                                MessageBox.Show("请选择正确的档案格式及符合下列命名之档案。\r\n" + csv[i] + ".csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    switch (language)
                                    {
                                        case "English":
                                            MessageBox.Show("Please Import another relative table to make sure The Data integrity.\r\nIf Not, The Data all data will be cleared.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            break;

                                        case "TraditionalChinese":
                                            MessageBox.Show("請導入其他相關資料表以確保資料完整性。\r\n否則，所有資料將會被清除。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            break;

                                        case "SimplifiedChinese":
                                            MessageBox.Show("请导入其他相关资料表以确保资料完整性。\r\n否则，所有资料将会被清除。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            break;
                                    }
                                    isDone = true;
                                    break;
                                }
                            }
                        }

                    }
                    else if (Path.GetFileName(ofd.FileName) == "ItemPrice.csv")
                    {
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            conn.Open();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = @"delete * from ItemPrice";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = @"insert into ItemPrice select * from " +
                                              "[Text;FMT=Delimited;HDR=YES;CharacterSet=65001;Database=" +
                                              path + "].[" + fn + "]";
                            cmd.ExecuteNonQuery();
                            switch (language)
                            {
                                case "English":
                                    MessageBox.Show("ItemPrice updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;

                                case "TraditionalChinese":
                                    MessageBox.Show("ItemPrice 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;

                                case "SimplifiedChinese":
                                    MessageBox.Show("ItemPrice 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;
                            }
                        }
                    }
                    else if (Path.GetFileName(ofd.FileName) == "ShopItem.csv")
                    {
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            conn.Open();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = @"delete * from ShopItem";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = @"insert into ShopItem select * from " +
                                              "[Text;FMT=Delimited;HDR=YES;CharacterSet=65001;Database=" +
                                              path + "].[" + fn + "]"; ;
                            cmd.ExecuteNonQuery();
                            switch (language)
                            {
                                case "English":
                                    MessageBox.Show("ShopItem updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;

                                case "TraditionalChinese":
                                    MessageBox.Show("ShopItem 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;

                                case "SimplifiedChinese":
                                    MessageBox.Show("ShopItem 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;
                            }
                        }
                    }
                    else if (Path.GetFileName(ofd.FileName) == "ModifyRecord.csv")
                    {
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            conn.Open();
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.CommandText = @"delete * from ModifyRecord";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = @"insert into ModifyRecord select * from " +
                                              "[Text;FMT=Delimited;HDR=YES;CharacterSet=65001;Database=" +
                                              path + "].[" + fn + "]";
                            cmd.ExecuteNonQuery();
                            switch (language)
                            {
                                case "English":
                                    MessageBox.Show("ModifyRecord updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;

                                case "TraditionalChinese":
                                    MessageBox.Show("ModifyRecord 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;

                                case "SimplifiedChinese":
                                    MessageBox.Show("ModifyRecord 更新成功!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        switch (language)
                        {
                            case "English":
                                MessageBox.Show("Please Select vaild file with appointed name. \r\nThe Vaild Appointed Name are ItemList.csv, ItemPrice.csv, ShopItem.csv and ModifyRecord.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case "TraditionalChinese":
                                MessageBox.Show("請選擇正確的檔案格式及符合下列命名之檔案。\r\n ItemList.csv, ItemPrice.csv, ShopItem.csv 及 ModifyRecord.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case "SimplifiedChinese":
                                MessageBox.Show("请选择正确的档案格式及符合下列命名之档案。\r\n ItemList.csv, ItemPrice.csv, ShopItem.csv 及 ModifyRecord.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    conn.Close();
                    this.modifyRecordTableAdapter.Fill(this.rSSDatabaseDataSet.ModifyRecord);
                    isSearched = false;
                    switch (language)
                    {
                        case "English":
                            changeLanguage("English");
                            break;
                        case "TraditionalChinese":
                            changeLanguage("TraditionalChinese");
                            break;
                        case "SimplifiedChinese":
                            changeLanguage("SimplifiedChinese");
                            break;
                    }
                }
            }
            else
            {
                switch (language)
                {
                    case "English":
                        MessageBox.Show("You are not allow to import data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "TraditionalChinese":
                        MessageBox.Show("你沒有權限導入資料。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "SimplifiedChinese":
                        MessageBox.Show("你没有权限导入资料。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        }
    }
