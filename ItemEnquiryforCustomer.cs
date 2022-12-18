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


namespace Retail_Sales_SystemV1._0
{
    public partial class ItemEnquiryforCustomer : Form
    {
        public RSSMainMenu rSSMainFrm;
        public CusDetailSearch cusDS;
        private int IndexKey;
        private bool Pass = false;
        private bool categoryPass = false;
        public bool isSearched = false;
        public string tosqlStrEng;
        public string tosqlStrTC;
        public string tosqlStrSC;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/RSSDatabase.mdb"; // a setting for the Database file.
        public string language = "English";

        public ItemEnquiryforCustomer()
        {
            InitializeComponent();
        }


        private void itemListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rSSDatabaseDataSet);

        }

        private void ItemEnquiryforCustomer_Load(object sender, EventArgs e)
        {
            changeLanguage();
            createComboData("Category", "ItemList", comBCategory);
            // TODO: 這行程式碼會將資料載入 'rSSDatabaseDataSet.ItemPrice' 資料表。您可以視需要進行移動或移除。
            this.itemPriceTableAdapter.Fill(this.rSSDatabaseDataSet.ItemPrice);
            // TODO: 這行程式碼會將資料載入 'rSSDatabaseDataSet.ItemList' 資料表。您可以視需要進行移動或移除。
            this.itemListTableAdapter.Fill(this.rSSDatabaseDataSet.ItemList);
            lblSearchResult.Visible = false;
            itemCodeTextBox.Visible = false;
            nameTextBox.Visible = false;
            detailDescTextBox.Visible = false;
            priceTextBox.Visible = false;
            discountsTextBox.Visible = false;
            memberPriceTextBox.Visible = false;
            lblItemCode.Visible = false;
            lblName.Visible = false;
            lblDesc.Visible = false;
            lblPrice.Visible = false;
            lblDiscounts.Visible = false;
            lblMemberPrice.Visible = false;
            searchDataGridView.Visible = false;
        }

        private void CheckCode()
        {
            DataTable dt = new DataTable();
            string sqlStr = "Select ItemCode from ItemList";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (tbItemCode.Text == (dt.Rows[i]["ItemCode"].ToString()))
                {
                    Pass = true;
                    IndexKey = i;
                    break;
                }
                else {
                    Pass = false;
                    lblSearchResult.Visible = false;
                    itemCodeTextBox.Visible = false;
                    nameTextBox.Visible = false;
                    detailDescTextBox.Visible = false;
                    priceTextBox.Visible = false;
                    discountsTextBox.Visible = false;
                    memberPriceTextBox.Visible = false;
                    lblItemCode.Visible = false;
                    lblName.Visible = false;
                    lblDesc.Visible = false;
                    lblPrice.Visible = false;
                    lblDiscounts.Visible = false;
                    lblMemberPrice.Visible = false;
                    searchDataGridView.Visible = false;
                    comBCategory.SelectedItem = "--Select--";

                }
            }
        }

        private void tbItemCode_TextChanged(object sender, EventArgs e)
        {
            if(tbItemCode.Text != "")
            {
                comBCategory.Enabled = false;
                btnDetailSearch.Enabled = false;
            }
            else
            {
                comBCategory.Enabled = true;
                btnDetailSearch.Enabled = true;
            }
            CheckCode();
            if (Pass == true)
            {
                outputData();
            }

        }

        private void outputData()
        {
            searchDataGridView.ClearSelection();
            DataTable dt = new DataTable();
            if (comBCategory.SelectedItem.ToString() != "" && comBCategory.SelectedItem.ToString() != "--Select--" && Pass == false)
            {
                tosqlStrEng = "SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice FROM ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode where Category = '" + comBCategory.SelectedItem + "'";
                tosqlStrTC = "SELECT ItemList.ItemCode, ItemList.TCName, ItemList.TCDetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice FROM ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode where Category = '" + comBCategory.SelectedItem + "'";
                tosqlStrSC = "SELECT ItemList.ItemCode, ItemList.SCName, ItemList.SCDetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice FROM ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode where Category = '" + comBCategory.SelectedItem + "'";
            }
            else if (isSearched == false)
                {
                tosqlStrEng = cusDS.tosqlStrEng;
                tosqlStrTC = cusDS.tosqlStrTC;
                tosqlStrSC = cusDS.tosqlStrSC;
                }
            OleDbDataAdapter dataAdapter;
            switch (language)
            {
                case "English":
                    dataAdapter = new OleDbDataAdapter(tosqlStrEng, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    lblSearchResult.Visible = true;
                    itemCodeTextBox.Visible = true;
                    nameTextBox.Visible = true;
                    detailDescTextBox.Visible = true;
                    priceTextBox.Visible = true;
                    discountsTextBox.Visible = true;
                    memberPriceTextBox.Visible = true;
                    lblItemCode.Visible = true;
                    lblName.Visible = true;
                    lblDesc.Visible = true;
                    lblPrice.Visible = true;
                    lblDiscounts.Visible = true;
                    lblMemberPrice.Visible = true;
                    itemCodeTextBox.Text = dt.Rows[IndexKey]["ItemCode"].ToString();
                    nameTextBox.Text = dt.Rows[IndexKey]["Name"].ToString();
                    detailDescTextBox.Text = dt.Rows[IndexKey]["DetailDesc"].ToString();
                    priceTextBox.Text = dt.Rows[IndexKey]["Price"].ToString();
                    discountsTextBox.Text = dt.Rows[IndexKey]["Discounts"].ToString();
                    memberPriceTextBox.Text = dt.Rows[IndexKey]["MemberPrice"].ToString();
                    break;

                case "TraditionalChinese":
                    dataAdapter = new OleDbDataAdapter(tosqlStrTC, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    lblSearchResult.Visible = true;
                    itemCodeTextBox.Visible = true;
                    nameTextBox.Visible = true;
                    detailDescTextBox.Visible = true;
                    priceTextBox.Visible = true;
                    discountsTextBox.Visible = true;
                    memberPriceTextBox.Visible = true;
                    lblItemCode.Visible = true;
                    lblName.Visible = true;
                    lblDesc.Visible = true;
                    lblPrice.Visible = true;
                    lblDiscounts.Visible = true;
                    lblMemberPrice.Visible = true;
                    itemCodeTextBox.Text = dt.Rows[IndexKey]["ItemCode"].ToString();
                    nameTextBox.Text = dt.Rows[IndexKey]["TCName"].ToString();
                    detailDescTextBox.Text = dt.Rows[IndexKey]["TCDetailDesc"].ToString();
                    priceTextBox.Text = dt.Rows[IndexKey]["Price"].ToString();
                    discountsTextBox.Text = dt.Rows[IndexKey]["Discounts"].ToString();
                    memberPriceTextBox.Text = dt.Rows[IndexKey]["MemberPrice"].ToString();
                    break;

                case "SimplifiedChinese":
                    dataAdapter = new OleDbDataAdapter(tosqlStrSC, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    lblSearchResult.Visible = true;
                    itemCodeTextBox.Visible = true;
                    nameTextBox.Visible = true;
                    detailDescTextBox.Visible = true;
                    priceTextBox.Visible = true;
                    discountsTextBox.Visible = true;
                    memberPriceTextBox.Visible = true;
                    lblItemCode.Visible = true;
                    lblName.Visible = true;
                    lblDesc.Visible = true;
                    lblPrice.Visible = true;
                    lblDiscounts.Visible = true;
                    lblMemberPrice.Visible = true;
                    itemCodeTextBox.Text = dt.Rows[IndexKey]["ItemCode"].ToString();
                    nameTextBox.Text = dt.Rows[IndexKey]["SCName"].ToString();
                    detailDescTextBox.Text = dt.Rows[IndexKey]["SCDetailDesc"].ToString();
                    priceTextBox.Text = dt.Rows[IndexKey]["Price"].ToString();
                    discountsTextBox.Text = dt.Rows[IndexKey]["Discounts"].ToString();
                    memberPriceTextBox.Text = dt.Rows[IndexKey]["MemberPrice"].ToString();
                    break;
            }
        }

        public void changeLanguage()
        {
            if(Pass == true)
            {
                outputData();
            }
            if(categoryPass == true || isSearched == true)
            {
                upDataSearch_Category();
            }
            switch (language)
            {
                case "English":
                    lblDesc.Text = "Description:";
                    lblDiscounts.Text = "Discounts:";
                    lblItemCode.Text = "Item Code:";
                    lblMemberPrice.Text = "Member Price:";
                    lblName.Text = "Name:";
                    lblPrice.Text = "Price:";
                    lblSearchResult.Text = "Search Result";
                    btnDetailSearch.Text = "DetailSearch";
                    btnLang.Text = "Language";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    descSearchBy.Text = "Search By";
                    btnReset.Text = "Reset";
                    descItemCode.Text = "Item Code";
                    descCategory.Text = "Category";
                    this.Text = "Item Enquiry System";
                    break;

                case "TraditionalChinese":
                    lblDesc.Text = "說明:";
                    lblDiscounts.Text = "折扣:";
                    lblItemCode.Text = "貨品編號:";
                    lblMemberPrice.Text = "會員售價:";
                    lblName.Text = "貨品名稱:";
                    lblPrice.Text = "售價:";
                    lblSearchResult.Text = "搜尋結果";
                    btnDetailSearch.Text = "進階搜尋";
                    btnLang.Text = "語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    descSearchBy.Text = "搜尋於";
                    btnReset.Text = "重置";
                    descItemCode.Text = "貨品編號";
                    descCategory.Text = "分類";
                    this.Text = "貨品查詢系統";
                    break;

                case "SimplifiedChinese":
                    lblDesc.Text = "说明:";
                    lblDiscounts.Text = "折扣:";
                    lblItemCode.Text = "货品编号:";
                    lblMemberPrice.Text = "会员售价:";
                    lblName.Text = "货品名称:";
                    lblPrice.Text = "售价:";
                    lblSearchResult.Text = "搜寻结果";
                    btnDetailSearch.Text = "进阶搜寻";
                    btnLang.Text = "语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁体中文(Traditional Chinese)";
                    descSearchBy.Text = "搜寻于";
                    btnReset.Text = "重置";
                    descItemCode.Text = "货品编号";
                    descCategory.Text = "分类";
                    this.Text = "货品查询系统";
                    break;
            }
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            language = "English";
            changeLanguage();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            language = "SimplifiedChinese";
            changeLanguage();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            language = "TraditionalChinese";
            changeLanguage();
        }

        private void createComboData(string colunm, string Table,ComboBox comboBox)
        {
            string sqlStr = "Select DISTINCT " + colunm + " FROM " + Table;
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(sqlStr, connStr);
            DataTable dt1 = new DataTable();
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            dt1.Clear();
            dt1.Rows.Clear();
            dt1.Columns.Clear();
            dataAdapter1.Fill(dt1);
            dataAdapter1.Dispose();
            comboBox.DisplayMember = colunm;
            comboBox.ValueMember = colunm;
            comboBox.Items.Add("--Select--");
            comboBox.SelectedItem = "--Select--";
            for(int i = 0; i < dt1.Rows.Count; i++)
            {
                comboBox.Items.Add(dt1.Rows[i][colunm].ToString());
            }
        }

        public void UpdateGrid(string sqlStr)
        {
            DataTable dt1 = new DataTable();
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(sqlStr, connStr);
            dt1.Clear();
            dt1.Rows.Clear();
            dt1.Columns.Clear();
            dataAdapter1.Fill(dt1);
            dataAdapter1.Dispose();
            searchDataGridView.DataSource = dt1;
            /*
            searchDataGridView.Columns[3].DefaultCellStyle.Format = "$#.##";
            searchDataGridView.Columns[4].DefaultCellStyle.Format = "$#.##";
            searchDataGridView.Columns[5].DefaultCellStyle.Format = "$#.##";
            */
        }

        private void comBCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBCategory.SelectedItem.ToString() != "" && comBCategory.SelectedItem.ToString() != "--Select--")
            {
                tbItemCode.Enabled = false;
                btnDetailSearch.Enabled = false;
            }
            else
            {
                tbItemCode.Enabled = true;
                btnDetailSearch.Enabled = true;
            }
            upDataSearch_Category();
            tbItemCode.Clear();
        }

        private void upDataSearch_Category()
        {
            if ((comBCategory.SelectedItem.ToString() != "" && comBCategory.SelectedItem.ToString() != "--Select--") && isSearched == false)
            {
                string tosqlStrEng = "SELECT ItemList.ItemCode, ItemList.Name FROM ItemList where Category = '" + comBCategory.SelectedItem + "'";
                string tosqlStrTC = "SELECT ItemList.ItemCode, ItemList.TCName FROM ItemList where Category = '" + comBCategory.SelectedItem + "'";
                string tosqlStrSC = "SELECT ItemList.ItemCode, ItemList.SCName FROM ItemList where Category = '" + comBCategory.SelectedItem + "'";
                categoryPass = true;
                searchDataGridView.Visible = true;
                switch (language)
                {
                    case "English":
                        UpdateGrid(tosqlStrEng);
                        searchDataGridView.Columns[0].HeaderText = "Item Code";
                        searchDataGridView.Columns[1].HeaderText = "Name";
                        break;

                    case "TraditionalChinese":
                        UpdateGrid(tosqlStrTC);
                        searchDataGridView.Columns[0].HeaderText = "貨品編號";
                        searchDataGridView.Columns[1].HeaderText = "貨品名稱";
                        break;

                    case "SimplifiedChinese":
                        UpdateGrid(tosqlStrSC);
                        searchDataGridView.Columns[0].HeaderText = "货品编号";
                        searchDataGridView.Columns[1].HeaderText = "货品名称";
                        break;
                }
            }else if (isSearched == true)
            {
                switch (language)
                {
                    case "English":
                        UpdateGrid(cusDS.tosqlStrEng);
                        searchDataGridView.Columns[0].HeaderText = "Item Code";
                        searchDataGridView.Columns[1].HeaderText = "Name";
                        searchDataGridView.Columns[2].HeaderText = "Detail Description";
                        searchDataGridView.Columns[3].HeaderText = "Price";
                        searchDataGridView.Columns[4].HeaderText = "Discounts";
                        searchDataGridView.Columns[5].HeaderText = "Member Price";
                        break;

                    case "TraditionalChinese":
                        UpdateGrid(cusDS.tosqlStrTC);
                        searchDataGridView.Columns[0].HeaderText = "貨品編號";
                        searchDataGridView.Columns[1].HeaderText = "貨品名稱";
                        searchDataGridView.Columns[2].HeaderText = "說明";
                        searchDataGridView.Columns[3].HeaderText = "售價";
                        searchDataGridView.Columns[4].HeaderText = "折扣";
                        searchDataGridView.Columns[5].HeaderText = "會員售價";
                        break;

                    case "SimplifiedChinese":
                        UpdateGrid(cusDS.tosqlStrSC);
                        searchDataGridView.Columns[0].HeaderText = "货品编号";
                        searchDataGridView.Columns[1].HeaderText = "货品名称";
                        searchDataGridView.Columns[2].HeaderText = "说明";
                        searchDataGridView.Columns[3].HeaderText = "售价";
                        searchDataGridView.Columns[4].HeaderText = "折扣";
                        searchDataGridView.Columns[5].HeaderText = "会员售价";
                        break;
                }

            }
            else
            {
                searchDataGridView.Visible = false;
                categoryPass = false;
            }

        }

        private void searchDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            IndexKey = searchDataGridView.CurrentCell.RowIndex;
            outputData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comBCategory.Enabled = true;
            tbItemCode.Enabled = true;
            comBCategory.SelectedItem = "--Select--";
            tbItemCode.Clear();
            lblSearchResult.Visible = false;
            itemCodeTextBox.Visible = false;
            nameTextBox.Visible = false;
            detailDescTextBox.Visible = false;
            priceTextBox.Visible = false;
            discountsTextBox.Visible = false;
            memberPriceTextBox.Visible = false;
            lblItemCode.Visible = false;
            lblName.Visible = false;
            lblDesc.Visible = false;
            lblPrice.Visible = false;
            lblDiscounts.Visible = false;
            lblMemberPrice.Visible = false;
            searchDataGridView.Visible = false;
            categoryPass = false;
            isSearched = false;
            btnDetailSearch.Enabled = true;
        }

        private void btnDetailSearch_Click(object sender, EventArgs e)
        {
            tbItemCode.Clear();
            comBCategory.SelectedItem = "--Select--";
            cusDS = new CusDetailSearch();
            cusDS.IEMCus = this;
            cusDS.changeLanguage(language);
            cusDS.Show();
            this.Hide();
        }

        private void ItemEnquiryforCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cusDS != null)
            {
                cusDS.IEMCus = null;
            }
            rSSMainFrm = new RSSMainMenu();
            rSSMainFrm.IEMcus = this;
            rSSMainFrm.language = this.language;
            rSSMainFrm.changeLanguage(language);
            rSSMainFrm.Show();
            this.Hide();
        }
    }
}
