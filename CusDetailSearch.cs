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
    public partial class CusDetailSearch : Form
    {
        public ItemEnquiryforCustomer IEMCus;
        private int selectCount = 0;
        public string tosqlStrEng = "SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice FROM ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode where";
        public string tosqlStrTC = "SELECT ItemList.ItemCode, ItemList.TCName, ItemList.TCDetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice FROM ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode where";
        public string tosqlStrSC = "SELECT ItemList.ItemCode, ItemList.SCName, ItemList.SCDetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice FROM ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode where";
        public string language = "";

        public CusDetailSearch()
        {
            InitializeComponent();
        }


        // Button and CheckBox Control
        // Start
        private void cBName_CheckedChanged(object sender, EventArgs e)
        {
            if (cBName.Checked == false) { selectCount--; tbName.ReadOnly = true; tbName.Visible = false; tbName.BackColor = SystemColors.ControlDark; }
            else { selectCount++; tbName.ReadOnly = false; tbName.Visible = true; tbName.BackColor = SystemColors.ControlLightLight; }
        }

        private void cBCode_CheckedChanged(object sender, EventArgs e)
        {
            if (cBCode.Checked == false) { selectCount--; tbCode.ReadOnly = true; tbCode.Visible = false; tbCode.BackColor = SystemColors.ControlDark; }
            else { selectCount++; tbCode.ReadOnly = false; tbCode.Visible = true; tbCode.BackColor = SystemColors.ControlLightLight; }
        }

        private void cBDetailDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (cBDetailDesc.Checked == false) { selectCount--; tbDetailDesc.ReadOnly = true; tbDetailDesc.Visible = false; tbDetailDesc.BackColor = SystemColors.ControlDark; }
            else { selectCount++; tbDetailDesc.ReadOnly = false; tbDetailDesc.Visible = true; tbDetailDesc.BackColor = SystemColors.ControlLightLight; }
        }

        // Button and CheckBox Control
        // End

        // Language Control and Setting
        // Start

        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            //reset the Combo Box of Category and add the items for user selection.
            switch (Lang)
            {
                case "English":
                    language = "English";
                    this.Text = "Search Function";
                    cBCode.Text = "Code";
                    cBName.Text = "Name";
                    cBDetailDesc.Text = "Description";
                    btnClear.Text = "Clear";
                    btnOK.Text = "Search";
                    btnLang.Text = "Language";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblSeaBy.Text = "Search By";
                    tbName.ImeMode = System.Windows.Forms.ImeMode.Disable;
                    tbDetailDesc.ImeMode = System.Windows.Forms.ImeMode.Disable;
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    this.Text = "搜尋";
                    cBCode.Text = "貨品編號";
                    cBName.Text = "貨品名稱";
                    cBDetailDesc.Text = "貨品說明";
                    btnClear.Text = "清除";
                    btnOK.Text = "搜尋";
                    btnLang.Text = "語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblSeaBy.Text = "使用以下條件進行搜尋";
                    tbName.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    tbDetailDesc.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    this.Text = "搜寻";
                    cBCode.Text = "货品编号";
                    cBName.Text = "货品名称";
                    cBDetailDesc.Text = "货品说明";
                    btnClear.Text = "清除";
                    btnOK.Text = "搜寻";
                    btnLang.Text = "语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblSeaBy.Text = "使用以下条件进行搜寻";
                    tbName.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    tbDetailDesc.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    break;
            }
        }

        private void SearchFunction_Load(object sender, EventArgs e)
        {
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
            this.TopMost = true;
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            changeLanguage("English");
            clearAll();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            changeLanguage("SimplifiedChinese");
            clearAll();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            changeLanguage("TraditionalChinese");
            clearAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((cBCode.Checked == true && tbCode.Text != "") || (cBDetailDesc.Checked == true && tbDetailDesc.Text != "") || (cBName.Checked == true && tbName.Text != ""))
            {
                IEMCus.language = this.language;
                IEMCus.isSearched = true;

                //1 Name Check Start
                if (cBName.Checked == true && (!string.IsNullOrEmpty(tbName.Text)))
                //checking when cbName is checked and TextBox of Name Not null, then return the sql query part of name. 
                {
                    tosqlStrEng += (" ((ItemList.Name Like " + "'%" + tbName.Text + "%') or (ItemList.TCName like " + "'%" + tbName.Text + "%') or (ItemList.SCName like " + "'%" + tbName.Text + "%')) and");
                    tosqlStrTC += (" ((ItemList.Name Like " + "'%" + tbName.Text + "%') or (ItemList.TCName like " + "'%" + tbName.Text + "%') or (ItemList.SCName like " + "'%" + tbName.Text + "%')) and");
                    tosqlStrSC += (" ((ItemList.Name Like " + "'%" + tbName.Text + "%') or (ItemList.TCName like " + "'%" + tbName.Text + "%') or (ItemList.SCName like " + "'%" + tbName.Text + "%')) and");

                    deleteOverAnd();
                }
                else if (cBName.Checked == true && (string.IsNullOrEmpty(tbName.Text))) { selectCount--; }
                //Name Check End

                //2 Code Check Start
                if (cBCode.Checked == true && (!string.IsNullOrEmpty(tbCode.Text)))
                //checking when cbCode is checked and TextBox of Code Not null, then return the sql query part of Code. 
                {
                    tosqlStrEng += (" (ItemList.ItemCode Like " + "'%" + tbCode.Text + "%') and");
                    tosqlStrTC += (" (ItemList.ItemCode Like " + "'%" + tbCode.Text + "%') and");
                    tosqlStrSC += (" (ItemList.ItemCode Like " + "'%" + tbCode.Text + "%') and");

                    deleteOverAnd();
                }
                else if (cBCode.Checked == true && (string.IsNullOrEmpty(tbCode.Text))) { selectCount--; }
                //Code Check End


                //3 DetailDesc Check Start
                if (cBDetailDesc.Checked == true && (!string.IsNullOrEmpty(tbDetailDesc.Text)))
                //checking when cBDetailDesc is checked and TextBox of DetailDesc Not null, then return the sql query part of DetailDesc. 
                {
                    tosqlStrEng += (" ((ItemList.DetailDesc Like " + "'%" + tbDetailDesc.Text + "%') or (ItemList.SCDetailDesc like " + "'%" + tbDetailDesc.Text + "%') or (ItemList.TCDetailDesc like " + "'%" + tbDetailDesc.Text + "%')) and");
                    tosqlStrTC += (" ((ItemList.DetailDesc Like " + "'%" + tbDetailDesc.Text + "%') or (ItemList.SCDetailDesc like " + "'%" + tbDetailDesc.Text + "%') or (ItemList.TCDetailDesc like " + "'%" + tbDetailDesc.Text + "%')) and");
                    tosqlStrSC += (" ((ItemList.DetailDesc Like " + "'%" + tbDetailDesc.Text + "%') or (ItemList.SCDetailDesc like " + "'%" + tbDetailDesc.Text + "%') or (ItemList.TCDetailDesc like " + "'%" + tbDetailDesc.Text + "%')) and");

                    deleteOverAnd();
                }
                else if (cBDetailDesc.Checked && (string.IsNullOrEmpty(tbDetailDesc.Text))) { selectCount--; }
                //DetailDesc Check End

                deleteOverAnd();
                createEndingAnd();
                switch (language)
                {
                    case "English":
                        IEMCus.UpdateGrid(tosqlStrEng);
                        IEMCus.tosqlStrEng = tosqlStrEng;
                        break;
                    case "TradionalChinese":
                        IEMCus.UpdateGrid(tosqlStrTC);
                        IEMCus.tosqlStrTC = tosqlStrTC;

                        break;
                    case "SimplifiedChinese":
                        IEMCus.UpdateGrid(tosqlStrSC);
                        IEMCus.tosqlStrSC = tosqlStrSC;

                        break;
                }
                
                IEMCus.Visible = true;
                IEMCus.changeLanguage();
                this.Hide();
                IEMCus.searchDataGridView.Visible = true;
                IEMCus.btnDetailSearch.Enabled = false;
                IEMCus.comBCategory.Enabled = false;
                IEMCus.tbItemCode.Enabled = false;
            }

            else //if User not select any search criteria, will do this part.
            {
                switch (language)
                {
                    case "English":
                        MessageBox.Show("Please Select at least one of Search Criteria.");
                        break;
                    case "TraditionalChinese":
                        MessageBox.Show("請至少選擇一個搜尋條件。");
                        break;
                    case "SimplifiedChinese":
                        MessageBox.Show("请至少选择一个搜寻条件。");
                        break;
                }
            }

            // Language Control and Setting
            // End
        }

        private void SearchFunction_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IEMCus != null)
                IEMCus.Visible = true;
        }


        private void deleteOverAnd()
        {
            if (selectCount == 1)
            {
                string toRemove1 = " and";
                int[] i1 = new int[3];
                i1[0] = tosqlStrEng.IndexOf(toRemove1);
                i1[1] = tosqlStrTC.IndexOf(toRemove1);
                i1[2] = tosqlStrSC.IndexOf(toRemove1);
                if (i1[0] >= 0)
                {
                    tosqlStrEng = tosqlStrEng.Remove(i1[0], toRemove1.Length);
                    tosqlStrTC = tosqlStrTC.Remove(i1[1], toRemove1.Length);
                    tosqlStrSC = tosqlStrSC.Remove(i1[2], toRemove1.Length);
                }
            }
        }

        private void clearAll()
        {
            tbCode.Text = "";
            tbDetailDesc.Text = "";
            tbName.Text = "";
            cBName.Checked = false;
            cBDetailDesc.Checked = false;
            cBCode.Checked = false;
            tbCode.Visible = false;
            tbDetailDesc.Visible = false;
            tbName.Visible = false;

            //reset all comboBox Item to selected language.
            switch (language)
            {
                case "English":
                    break;
                case "TradionalChinese":
                    break;
                case "SimplifiedChinese":
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void createEndingAnd()
        {
            // MessageBox.Show(tosqlStrEng + "/r/n Selected: " + selectCount);  For Debug
            //End of sqlString setting
            tosqlStrEng += ";";
            tosqlStrTC += ";";
            tosqlStrSC += ";";
            if (selectCount > 1)
            {
                string toRemove2 = " and;";
                int[] i2 = new int[3];
                i2[0] = tosqlStrEng.IndexOf(toRemove2);
                i2[1] = tosqlStrTC.IndexOf(toRemove2);
                i2[2] = tosqlStrSC.IndexOf(toRemove2);
                if (i2[0] >= 0)
                {
                    tosqlStrEng = tosqlStrEng.Remove(i2[0], toRemove2.Length);
                    tosqlStrTC = tosqlStrTC.Remove(i2[1], toRemove2.Length);
                    tosqlStrSC = tosqlStrSC.Remove(i2[2], toRemove2.Length);
                }
                tosqlStrEng += ";";
                tosqlStrTC += ";";
                tosqlStrSC += ";";
            }
            // MessageBox.Show(tosqlStrEng + "/r/n Selected: " + selectCount);   For Debug
        }
    }
}
