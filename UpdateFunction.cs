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

    public partial class UpdateFunction : Form
    {
        public int changeIndex;
        public ItemEnquiryandMaintenance eryfrm;
        public IEMMainMenu mM;
        public string tosqlStr = "";
        public string insertsqlStr = "";
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/RSSDatabase.mdb"; // a setting for the Database file.
        public string language = "";

        public UpdateFunction()
        {
            InitializeComponent();
        }

        private void UpdateFunction_Load(object sender, EventArgs e)
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
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            changeLanguage("SimplifiedChinese");
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            changeLanguage("TraditionalChinese");
        }


        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            createComboData("ItemCode", "ItemList", comBSelectCode);
            switch (Lang)
            {
                case "English":
                    language = "English";
                    this.Text = "Update Function";
                    btnLang.Text = "Select The Language";
                    btnEng.Text = "English";
                    btnSC.Text = "Simplified Chinese";
                    btnTC.Text = "Traditional Chinese";
                    lblCode.Text = "Item Code:";
                    lblLocat.Text = "Location: ";
                    lblShelf.Text = "Shelf Number: ";
                    lblShelfUpdate.Text = "Shelf Number: ";
                    lblUpdateLocat.Text = "Location: ";
                    lblDescBefore.Text = "Select The Data you want to update";
                    lblDescAfter.Text = "Enter Value For Update.\r\nBlank Box if you don't want to modify.";
                    btnUpdate.Text = "Update";
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    this.Text = "更新";
                    btnLang.Text = "選擇語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "簡體中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    lblCode.Text = "貨品編號:";
                    lblLocat.Text = "位置: ";
                    lblShelf.Text = "貨架編號: ";
                    lblShelfUpdate.Text = "貨架編號: ";
                    lblUpdateLocat.Text = "位置: ";
                    lblDescBefore.Text = "選擇你想更改的貨品資料";
                    lblDescAfter.Text = "如無需更改之項目，可將其留空。";
                    btnUpdate.Text = "更新";
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    this.Text = "更新";
                    btnLang.Text = "选择语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁体中文(Traditional Chinese)";
                    lblCode.Text = "货品编号:";
                    lblLocat.Text = "位置: ";
                    lblShelf.Text = "货架编号: ";
                    lblShelfUpdate.Text = "货架编号: ";
                    lblUpdateLocat.Text = "位置: ";
                    lblDescBefore.Text = "选择你想更改的货品资料";
                    lblDescAfter.Text = "如无需更改之项目，可将其留空。";
                    btnUpdate.Text = "更新";
                    break;
            }
            mM.changeLanguage(language);
            eryfrm.changeLanguage(language);
        }

        //A method For create combo box item by using SQL without condition to get the data for Database.
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

        //A method For create combo box item by using SQL with condition to get the data for Database.
        private void createComboData(string colunm, string Table, string condition, ComboBox comboBox1)
        {
            string sqlStr = "Select DISTINCT " + colunm + " FROM " + Table + " WHERE " + condition;
            OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter(sqlStr, connStr);
            DataTable dt2 = new DataTable();
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            dt2.Clear();
            dt2.Rows.Clear();
            dt2.Columns.Clear();
            dataAdapter2.Fill(dt2);
            dataAdapter2.Dispose();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = colunm;
            comboBox1.ValueMember = colunm;
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (language)
            {
                case "English":
                     if (!string.IsNullOrEmpty(comBShelfNumUpdate.Text) && !string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        //Comfirm Message For modify the Location and ShelfNum.
                        if (MessageBox.Show(
                         "Before Update: \r\n" + "Location: " + comBLocat.SelectedValue + "\r\nShelf Number: " + comBShelfNum.SelectedValue + "\r\n \r\nAfter Update: " + "\r\nLocation: " + comBLocationUpdate.Text + "\r\nShelf Number: " + comBShelfNumUpdate.Text + "\r\n\r\nDo you really want to Update the record?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 2;
                            tosqlStr = "UPDATE ShopItem SET ShelfNum = @ShelfNum" + ", Location = @Location" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else if (!string.IsNullOrEmpty(comBShelfNumUpdate.Text) && string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        //Comfirm Message For modify the ShelfNum only.
                        if (MessageBox.Show(
                         "Before Update: \r\n" + "Location: " + comBLocat.SelectedValue + "\r\nShelf Number: " + comBShelfNum.SelectedValue + "\r\n \r\nAfter Update: " + "\r\nLocation: " + comBLocat.SelectedValue + "\r\nShelf Number: " + comBShelfNumUpdate.Text + "\r\n\r\nDo you really want to Update the record?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 1;
                            tosqlStr = "UPDATE ShopItem SET ShelfNum = @ShelfNum" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else if (string.IsNullOrEmpty(comBShelfNumUpdate.Text) && !string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        //Comfirm Message For modify the Location only.
                        if (MessageBox.Show(
                         "Before Update: \r\n" + "Location: " + comBLocat.SelectedValue + "\r\nShelf Number: " + comBShelfNum.SelectedValue + "\r\n \r\nAfter Update: " + "\r\nLocation: " + comBLocationUpdate.Text + "\r\nShelf Number: " + comBShelfNum.SelectedValue + "\r\n\r\nDo you really want to Update the record?",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 0;
                            tosqlStr = "UPDATE ShopItem SET Location = @Location" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter at least one Value you want to Modifying.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "TraditionalChinese":
                    if (!string.IsNullOrEmpty(comBShelfNumUpdate.Text) && !string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        if (MessageBox.Show(
                         "更新前: \r\n" + "位置: " + comBLocat.SelectedValue + "\r\n貨架編號: " + comBShelfNum.SelectedValue + "\r\n \r\n更新後: " + "\r\n位置: " + comBLocationUpdate.Text + "\r\n貨架編號: " + comBShelfNumUpdate.Text + "\r\n\r\n你確定要進行以上更改嗎？",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 2;
                            tosqlStr = "UPDATE ShopItem SET ShelfNum = @ShelfNum" + ", Location = @Location" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else if (!string.IsNullOrEmpty(comBShelfNumUpdate.Text) && string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        if (MessageBox.Show(
                         "更新前: \r\n" + "位置: " + comBLocat.SelectedValue + "\r\n貨架編號: " + comBShelfNum.SelectedValue + "\r\n \r\n更新後: " + "\r\n位置: " + comBLocat.SelectedValue + "\r\n貨架編號: " + comBShelfNumUpdate.Text + "\r\n\r\n你確定要進行以上更改嗎？",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 1;
                            tosqlStr = "UPDATE ShopItem SET ShelfNum = @ShelfNum" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else if (string.IsNullOrEmpty(comBShelfNumUpdate.Text) && !string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        if (MessageBox.Show(
                         "更新前: \r\n" + "位置: " + comBLocat.SelectedValue + "\r\n貨架編號: " + comBShelfNum.SelectedValue + "\r\n \r\n更新後: " + "\r\n位置: " + comBLocationUpdate.Text + "\r\n貨架編號: " + comBShelfNum.SelectedValue + "\r\n\r\n你確定要進行以上更改嗎？",
                          "Warning", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 0;
                            tosqlStr = "UPDATE ShopItem SET Location = @Location" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入至少一項更改。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "SimplifiedChinese":
                    if (!string.IsNullOrEmpty(comBShelfNumUpdate.Text) && !string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        if (MessageBox.Show(
                        "更新前: \r\n" + "位置: " + comBLocat.SelectedValue + "\r\n货架编号: " + comBShelfNum.SelectedValue + "\r\n \r\n更新后: " + "\r \n位置: " + comBLocationUpdate.Text + "\r\n货架编号: " + comBShelfNumUpdate.Text + "\r\n\r\n你确定要进行以上更改吗？",
                        "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 2;
                            tosqlStr = "UPDATE ShopItem SET ShelfNum = @ShelfNum" + ", Location = @Location" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "';";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else if (!string.IsNullOrEmpty(comBShelfNumUpdate.Text) && string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        if (MessageBox.Show(
                        "更新前: \r\n" + "位置: " + comBLocat.SelectedValue + "\r\n货架编号: " + comBShelfNum.SelectedValue + "\r\n \r\n更新后: " + "\r \n位置: " + comBLocat.SelectedValue + "\r\n货架编号: " + comBShelfNumUpdate.Text + "\r\n\r\n你确定要进行以上更改吗？",
                        "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 1;
                            tosqlStr = "UPDATE ShopItem SET ShelfNum = @ShelfNum" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "'; ";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else if (string.IsNullOrEmpty(comBShelfNumUpdate.Text) && !string.IsNullOrEmpty(comBLocationUpdate.Text))
                    {
                        if (MessageBox.Show(
                        "更新前: \r\n" + "位置: " + comBLocat.SelectedValue + "\r\n货架编号: " + comBShelfNum.SelectedValue + "\r\n \r\n更新后: " + "\r \n位置: " + comBLocationUpdate.Text + "\r\n货架编号: " + comBShelfNum.SelectedValue + "\r\n\r\n你确定要进行以上更改吗？",
                        "Warning", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            changeIndex = 0;
                            tosqlStr = "UPDATE ShopItem SET Location = @Location" + " WHERE ItemCode = '" + comBSelectCode.SelectedValue + "' and Location = '" + comBLocat.SelectedValue + "' and ShelfNum = '" + comBShelfNum.SelectedValue + "'; ";
                            upDateTable(connStr, tosqlStr);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入至少一项更改。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
            eryfrm.modifyRecordTableAdapter.Fill(eryfrm.rSSDatabaseDataSet.ModifyRecord);
        }

        private void UpdateFunction_FormClosed(object sender, FormClosedEventArgs e)
        {
            eryfrm.Visible = true;
            mM.btnLang.Visible = true;
            mM.btnery.Visible = true;
            mM.btnUM.Visible = true;
            resetTable();
        }

        private void comBSelectCode_SelectedValueChanged(object sender, EventArgs e)
        {
            createComboData("Location", "ShopItem", "ItemCode = '" + comBSelectCode.SelectedValue+"'", comBLocat);
        }

        private void comBLocat_SelectedValueChanged(object sender, EventArgs e)
        {
            createComboData("ShelfNum", "ShopItem", "ItemCode = '" + comBSelectCode.SelectedValue + "' and " + "Location = '" + comBLocat.Text + "'", comBShelfNum);
        }

        private void comBShelfNum_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comBShelfNum.SelectedValue != null && comBLocat.SelectedValue != null)
            {
                createComboData("Location", "ShopItem", "Location <> '" + comBLocat.SelectedValue + "'", comBLocationUpdate);
                createComboData("ShelfNum", "ShopItem", "ShelfNum <> '" + comBShelfNum.SelectedValue + "'", comBShelfNumUpdate);
                comBLocationUpdate.SelectedItem = null;
                comBShelfNumUpdate.SelectedItem = null;
            }
        }

        private void upDateTable(string constr, string sqlstr)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection connection;
            connection = new OleDbConnection(constr);
            cmd.Connection = connection;
            cmd.CommandText = sqlstr;
            if(changeIndex == 0)
                cmd.Parameters.AddWithValue("@Location", comBLocationUpdate.Text);
            if (changeIndex == 1)
                cmd.Parameters.AddWithValue("@ShelfNum", comBShelfNumUpdate.Text);
            if (changeIndex == 2)
            {
                cmd.Parameters.AddWithValue("@ShelfNum", comBShelfNumUpdate.Text);
                cmd.Parameters.AddWithValue("@Location", comBLocationUpdate.Text);
            }
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            insertsqlStr = "INSERT INTO ModifyRecord(ModifyNum,ItemCode,StaffNumber,BShelfNumber,AShelfNumber,BLocation,ALocation,ModifyDate) VALUES (@ModifyNum,@ItemCode,@StaffNumber,@BShelfNumber,@AShelfNumber,@BLocation,@ALocation,@ModifyDate)";
            upDateRecord(connStr, insertsqlStr);
            switch (language)
            {
                case "English":
                    MessageBox.Show("Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case "TraditionalChinese":
                    MessageBox.Show("已成功進行更新。", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case "SimplifiedChinese":
                    MessageBox.Show("已成功进行更新。", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
            }
            reset();
            string Directory = System.IO.Directory.GetCurrentDirectory() + "\\RSSDatabase.mdb";
            string ToDirectory = @"..\..\..\OnlineItemEnquiry\RSSDatabase.mdb";
            System.IO.File.Copy(Directory, ToDirectory, true);
        }

        private void upDateRecord(string constr, string sqlstr)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection connection;
            connection = new OleDbConnection(constr);
            cmd.Connection = connection;
            cmd.CommandText = sqlstr;
            connection.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = connection;
            cmd1.CommandText = "SELECT COUNT(*) FROM ModifyRecord";
            Int32 count = (Int32)cmd1.ExecuteScalar();
            DateTime time = DateTime.Now;
            string timeFormat = "yyyy-MM-dd HH:mm:ss";

            cmd.Parameters.AddWithValue("@ModifyNum", count);
            cmd.Parameters.AddWithValue("@ItemCode", comBSelectCode.SelectedValue);
            cmd.Parameters.AddWithValue("@StaffNumber", mM.SNum);
            
            if (changeIndex == 0)
            {//Modify Location Only.
                cmd.Parameters.AddWithValue("@BShelfNumber", "N/A");
                cmd.Parameters.AddWithValue("@AShelfNumber", "N/A");
                cmd.Parameters.AddWithValue("@BLocation", comBLocat.SelectedValue);
                cmd.Parameters.AddWithValue("@ALocation", comBLocationUpdate.Text);
            }
            else if (changeIndex == 1)
            {//Modify Shelf Number Only.
                cmd.Parameters.AddWithValue("@BShelfNumber", comBShelfNum.SelectedValue);
                cmd.Parameters.AddWithValue("@AShelfNumber", comBShelfNumUpdate.Text);
                cmd.Parameters.AddWithValue("@BLocation", "N/A");
                cmd.Parameters.AddWithValue("@ALocation", "N/A");
            }
            else if (changeIndex == 2)
            {//Modify Shelf Number and Location.
                cmd.Parameters.AddWithValue("@BShelfNumber", comBShelfNum.SelectedValue);
                cmd.Parameters.AddWithValue("@AShelfNumber", comBShelfNumUpdate.Text);
                cmd.Parameters.AddWithValue("@BLocation", comBLocat.SelectedValue);
                cmd.Parameters.AddWithValue("@ALocation", comBLocationUpdate.Text);
            }
            cmd.Parameters.AddWithValue("@ModifyDate", time.ToString(timeFormat));
            cmd.ExecuteNonQuery();
            connection.Close();
            reset();
        }

        private void resetTable()
        {
            eryfrm.isSearched = false;
            switch (language)
            {
                case "English":
                    language = "English";
                    eryfrm.UpdateGrid("SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemList.Category, ItemList.Packaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    eryfrm.UpdateGrid("SELECT ItemList.ItemCode, ItemList.TCName, ItemList.TCDetailDesc, ItemList.Category, ItemList.TCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    eryfrm.UpdateGrid("SELECT ItemList.ItemCode, ItemList.SCName, ItemList.SCDetailDesc, ItemList.Category, ItemList.SCPackaging, ShopItem.Location, ShopItem.ShelfNum, ShopItem.Quantity, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.onPromotion FROM(ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode) INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode;");
                    break;
            }

        }

        private void reset()
        {
            createComboData("ItemCode", "ItemList", comBSelectCode);
        }
    }
}
