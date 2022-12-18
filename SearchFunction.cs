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
    public partial class SearchFunction : Form
    {
        public ItemEnquiryandMaintenance eryfrm;
        public IEMMainMenu mM;
        private int selectCount = 0;
        public string tosqlStrEng = "SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemList.Category, ItemList.Packaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode";
        public string tosqlStrTC = "SELECT ItemList.ItemCode, ItemList.TCName, ItemList.TCDetailDesc, ItemList.Category, ItemList.TCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode";
        public string tosqlStrSC = "SELECT ItemList.ItemCode, ItemList.SCName, ItemList.SCDetailDesc, ItemList.Category, ItemList.SCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode";
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/RSSDatabase.mdb"; // a setting for the Database file.
        public string language = "";

        public SearchFunction()
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

        private void cBCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (cBCategory.Checked == false) { selectCount--; comBCategory.Visible = false; comBCategory.BackColor = SystemColors.ControlDark; }
            else { selectCount++; comBCategory.Visible = true; comBCategory.BackColor = SystemColors.ControlLightLight; comBCategory.SelectedItem = 1; }
        }

        private void cBLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (cBLocation.Checked == false) { selectCount--; comBLocation.Visible = false; comBLocation.BackColor = SystemColors.ControlDark; }
            else { selectCount++; comBLocation.Visible = true; comBLocation.BackColor = SystemColors.ControlLightLight; comBLocation.SelectedItem = 1; }
        }

        private void cBPackaging_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPackaging.Checked == false) { selectCount--; comBPackaging.Visible = false; comBPackaging.BackColor = SystemColors.ControlDark; }
            else { selectCount++; comBPackaging.Visible = true; comBPackaging.BackColor = SystemColors.ControlLightLight; comBPackaging.SelectedItem = 1; }
        }

        private void cBPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPrice.Checked == false) { selectCount--; tbPrice.ReadOnly = true; tbPrice.Visible = false; tbPrice.BackColor = SystemColors.ControlDark; }
            else { selectCount++; tbPrice.ReadOnly = false; tbPrice.Visible = true; tbPrice.BackColor = SystemColors.ControlLightLight; }
        }

        private void cBMemberPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMemberPrice.Checked == false) { selectCount--; tbMemberPrice.ReadOnly = true; tbMemberPrice.Visible = false; tbMemberPrice.BackColor = SystemColors.ControlDark; }
            else { selectCount++; tbMemberPrice.ReadOnly = false; tbMemberPrice.Visible = true; tbMemberPrice.BackColor = SystemColors.ControlLightLight; }
        }

        private void cBQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuantity.Checked == true) { selectCount++; }
            else { selectCount--; }
        }

        private void cBOP_CheckedChanged(object sender, EventArgs e)
        {
            if (cBOP.Checked == true) { selectCount++; }
            else { selectCount--; }
        }
        // Button and CheckBox Control
        // End

        // Language Control and Setting
        // Start

        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            //reset the Combo Box of Category and add the items for user selection.
            createComboData("Category", "ItemList", comBCategory);
            switch (Lang)
            {
                case "English":
                    language = "English";
                    this.Text = "Search Function";
                    cBCategory.Text = "Category";
                    cBCode.Text = "Code";
                    cBLocation.Text = "Location";
                    cBName.Text = "Name";
                    cBPackaging.Text = "Packaging";
                    cBMemberPrice.Text = "MemberPrice";
                    cBOP.Text = "onPromotion";
                    cBPrice.Text = "Price";
                    btnClear.Text = "Clear";
                    btnOK.Text = "Search";
                    btnLang.Text = "Select The Language to Use for The Search";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblSeaBy.Text = "Search By";
                    cbQuantity.Text = "Quantity > 0";
                    //reset the Combo Box of Location and add the items for user selection.
                    createComboData("Location", "ShopItem", comBLocation);
                    //reset End
                    createComboData("Packaging", "ItemList", comBPackaging);
                    tbName.ImeMode = System.Windows.Forms.ImeMode.Disable;
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    this.Text = "搜尋";
                    cBCategory.Text = "分類";
                    cBCode.Text = "貨品編號";
                    cBLocation.Text = "位置";
                    cBName.Text = "貨品名稱";
                    cBPackaging.Text = "包裝";
                    cBMemberPrice.Text = "會員售價";
                    cBOP.Text = "正進行促銷";
                    cBPrice.Text = "售價";
                    btnClear.Text = "清除";
                    btnOK.Text = "搜尋";
                    btnLang.Text = "選擇用於搜尋的語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblSeaBy.Text = "使用以下條件進行搜尋";
                    cbQuantity.Text = "存貨量 > 0";
                    //reset the Combo Box of Location and add the items for user selection.
                    createComboData("Location", "ShopItem", comBLocation);
                    //reset End
                    createComboData("TCPackaging", "ItemList", comBPackaging);
                    tbName.ImeMode = System.Windows.Forms.ImeMode.On;

                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    this.Text = "搜寻";
                    cBCategory.Text = "分类";
                    cBCode.Text = "货品编号";
                    cBLocation.Text = "位置";
                    cBName.Text = "货品名称";
                    cBPackaging.Text = "包装";
                    cBMemberPrice.Text = "会员售价";
                    cBOP.Text = "正进行促销";
                    cBPrice.Text = "售价";
                    btnClear.Text = "清除";
                    btnOK.Text = "搜寻";
                    btnLang.Text = "选择用于搜寻的语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblSeaBy.Text = "使用以下条件进行搜寻";
                    cbQuantity.Text = "存货量 > 0";
                    //reset the Combo Box of Location and add the items for user selection.
                    createComboData("Location", "ShopItem", comBLocation);
                    //reset End
                    createComboData("SCPackaging", "ItemList", comBPackaging);
                    tbName.ImeMode = System.Windows.Forms.ImeMode.On;
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
            if (cbQuantity.Checked == true || cBCategory.Checked == true || (cBCode.Checked == true && tbCode.Text != "") || cBLocation.Checked == true || (cBMemberPrice.Checked == true && tbMemberPrice.Text != "") || (cBName.Checked == true && tbName.Text != "") || cBOP.Checked == true || cBPackaging.Checked == true || (cBPrice.Checked == true && tbPrice.Text != ""))
            {
                eryfrm.language = this.language;
                eryfrm.isSearched = true;
                tosqlStrEng += " where ";
                tosqlStrTC += " where ";
                tosqlStrSC += " where ";

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

                //3 Price Check Start
                if (cBPrice.Checked && (!string.IsNullOrEmpty(tbPrice.Text)))
                //checking when cbPrice is checked and TextBox of Price Not null, then return the sql query part of price. 
                {
                    tosqlStrEng += (" (ItemPrice.Price Like " + "'%" + tbPrice.Text + "%') and");
                    tosqlStrTC += (" (ItemPrice.Price Like " + "'%" + tbPrice.Text + "%') and");
                    tosqlStrSC += (" (ItemPrice.Price Like " + "'%" + tbPrice.Text + "%') and");

                    deleteOverAnd();
                }
                else if (cBPrice.Checked && (string.IsNullOrEmpty(tbPrice.Text))) { selectCount--; }
                //Price Check End

                //4 MemberPrice Check Start
                if (cBMemberPrice.Checked && (!string.IsNullOrEmpty(tbMemberPrice.Text)))
                //checking when cBMemberPrice is checked and TextBox of MemberPrice Not null, then return the sql query part of MemberPrice. 
                {
                    tosqlStrEng += (" (ItemPrice.MemberPrice Like " + "'%" + tbMemberPrice.Text + "%') and");
                    tosqlStrTC += (" (ItemPrice.MemberPrice Like " + "'%" + tbMemberPrice.Text + "%') and");
                    tosqlStrSC += (" (ItemPrice.MemberPrice Like " + "'%" + tbMemberPrice.Text + "%') and");

                    deleteOverAnd();
                }
                else if (cBMemberPrice.Checked && (string.IsNullOrEmpty(tbMemberPrice.Text))) { selectCount--; }
                //Price Check End

                //5 Category Check Start
                if (cBCategory.Checked)
                //checking when cbCategory is checked and Combo Box of Category Not null, then return the sql query part of Category. 
                {
                    tosqlStrEng += (" (ItemList.Category Like " + "'%" + comBCategory.SelectedValue + "%') and");
                    tosqlStrTC += (" (ItemList.Category Like " + "'%" + comBCategory.SelectedValue + "%') and");
                    tosqlStrSC += (" (ItemList.Category Like " + "'%" + comBCategory.SelectedValue + "%') and");

                    deleteOverAnd();
                }
                //Category Check End

                //6 Location Check Start
                if (cBLocation.Checked)
                //checking when cbLocation is checked and Combo Box of Location Not null, then return the sql query part of Location. 
                {
                    tosqlStrEng += (" (ShopItem.Location Like " + "'%" + comBLocation.SelectedValue + "%') and");
                    tosqlStrTC += (" (ShopItem.Location Like " + "'%" + comBLocation.SelectedValue + "%') and");
                    tosqlStrSC += (" (ShopItem.Location Like " + "'%" + comBLocation.SelectedValue + "%') and");

                    deleteOverAnd();
                }
                //Location Check End

                //7 Packaging Check Start
                if (cBPackaging.Checked)
                //checking when cBPackaging is checked and Combo Box of cBPackaging Not null, then return the sql query part of Packaging. 
                {
                    tosqlStrEng += (" ((ItemList.Packaging Like " + "'%" + comBPackaging.SelectedValue + "%') or ( ItemList.TCPackaging Like " + "'%" + comBPackaging.SelectedValue + "%') or (ItemList.SCPackaging Like " + "'%" + comBPackaging.SelectedValue + "%')) and");
                    tosqlStrTC += (" ((ItemList.Packaging Like " + "'%" + comBPackaging.SelectedValue + "%') or ( ItemList.TCPackaging Like " + "'%" + comBPackaging.SelectedValue + "%') or (ItemList.SCPackaging Like " + "'%" + comBPackaging.SelectedValue + "%')) and");
                    tosqlStrSC += (" ((ItemList.Packaging Like " + "'%" + comBPackaging.SelectedValue + "%') or ( ItemList.TCPackaging Like " + "'%" + comBPackaging.SelectedValue + "%') or (ItemList.SCPackaging Like " + "'%" + comBPackaging.SelectedValue + "%')) and");

                    deleteOverAnd();
                }
                //Location Check End

                //8 onPromation Check Start
                if (cBOP.Checked == true)
                //A method to search by onPromotion.
                {
                    //checking when cBOP is checked, then return the sql query part of onPromotion.                     
                    tosqlStrEng += " (ShopItem.onPromotion = true) and";
                    tosqlStrTC += " (ShopItem.onPromotion = true) and";
                    tosqlStrSC += " (ShopItem.onPromotion = true) and";
                    //Setting End

                    deleteOverAnd();
                }
                //onPromation Check End


                //9 Quantity Check Start
                if (cbQuantity.Checked == true)
                //A method to search by Quantity.
                {
                    //checking when cbQuantity is checked, then return the sql query part of Quantity which > 0.                     
                    tosqlStrEng += " (ShopItem.Quantity > 0) and";
                    tosqlStrTC += " (ShopItem.Quantity > 0) and";
                    tosqlStrSC += " (ShopItem.Quantity > 0) and";
                    //Setting End

                    deleteOverAnd();
                }
                //Quantity Check End

                createEndingAnd();
                switch (language)
                {
                    case "English":
                        eryfrm.UpdateGrid(tosqlStrEng);
                        break;
                    case "TradionalChinese":
                        eryfrm.UpdateGrid(tosqlStrTC);
                        break;
                    case "SimplifiedChinese":
                        eryfrm.UpdateGrid(tosqlStrSC);
                        break;
                }

                eryfrm.Visible = true;
                eryfrm.changeLanguage(language);
                mM.changeLanguage(language);
                mM.btnLang.Visible = true;
                mM.btnery.Visible = true;
                mM.btnUM.Visible = true;
                this.Hide();

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

                ;
            }

            // Language Control and Setting
            // End
        }

        private void SearchFunction_FormClosed(object sender, FormClosedEventArgs e)
        {
            eryfrm.Visible = true;
            mM.btnLang.Visible = true;
            mM.btnery.Visible = true;
            mM.btnUM.Visible = true;
        }

        //Only accect to input number in following TextBox (Price, MemberPrice)
        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbPrice.Text == "" && (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMemberPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tbMemberPrice.Text == "" && (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
            tbPrice.Text = "";
            tbMemberPrice.Text = "";
            tbName.Text = "";
            cBOP.Checked = false;
            cBPackaging.Checked = false;
            cBPrice.Checked = false;
            cBName.Checked = false;
            cBMemberPrice.Checked = false;
            cBLocation.Checked = false;
            cBCode.Checked = false;
            cBCategory.Checked = false;
            tbCode.Visible = false;
            tbMemberPrice.Visible = false;
            tbPrice.Visible = false;
            tbName.Visible = false;
            comBCategory.Visible = false;
            comBLocation.Visible = false;
            comBPackaging.Visible = false;

            //reset all comboBox Item to selected language.
            switch (language)
                {
                    case "English":
                        createComboData("Category", "ItemList", comBCategory);
                        //reset the Combo Box of Location and add the items for user selection.
                        createComboData("Location", "ShopItem", comBLocation);
                        //reset End
                        createComboData("Packaging", "ItemList", comBPackaging);
                        break;
                    case "TradionalChinese":
                        createComboData("Category", "ItemList", comBCategory);
                        //reset the Combo Box of Location and add the items for user selection.
                        createComboData("Location", "ShopItem", comBLocation);
                        //reset End
                        createComboData("TCPackaging", "ItemList", comBPackaging);
                        break;
                    case "SimplifiedChinese":
                        createComboData("Category", "ItemList", comBCategory);
                        //reset the Combo Box of Location and add the items for user selection.
                        createComboData("Location", "ShopItem", comBLocation);
                        //reset End
                        createComboData("SCPackaging", "ItemList", comBPackaging);
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

        private void createComboData(string colunm, string Table, ComboBox comboBox)
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
            comboBox.DataSource = dt1;
            comboBox.DisplayMember = colunm;
            comboBox.ValueMember = colunm;

        }
    }
}
