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
    public partial class UserMaintenance : Form
    {
        private string EditingNum;
        public string language = "";
        private bool isAdding = false;
        private bool isEditing = false;
        private IEMMainMenu mMfrm;
        private string sqlStr;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/RSSDatabase.mdb"; // a setting for the Database file.
        public UserMaintenance()
        {
            InitializeComponent();
        }

        public UserMaintenance(IEMMainMenu mMfrm1)
        {
            InitializeComponent();
            this.mMfrm = mMfrm1;
            this.language = mMfrm1.language;
            changeLanguage(language);
        }

        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            switch (Lang)
            {
                case "English":
                    language = "English";
                    this.Text = "User Maintenance";
                    staffNumberLabel.Text = "Staff Number:";
                    lblAR.Text = "AccessRight:";
                    lblFN.Text = "FirstName:";
                    lblLN.Text = "LastName:";
                    lblPW.Text = "Password:";
                    lblJT.Text = "JobTitle:";
                    bindingNavigatorDeleteItem.Text = "Delete";
                    bindingNavigatorClearandAdd.Text = "Clear and Add";
                    btnConfirmAdd.Text = "Confirm Add or Modify";
                    bindingNavigatorMoveLastItem.Text = "Last";
                    bindingNavigatorMoveNextItem.Text = "Next";
                    bindingNavigatorMovePreviousItem.Text = "Previous";
                    bindingNavigatorMoveFirstItem.Text = "First";
                    lblDesc.Text = "Control Tools";
                    lblRecord.Text = "Staff Account Record";
                    staffDataGridView.Columns[0].HeaderText = "Staff Number";
                    staffDataGridView.Columns[1].HeaderText = "Last Name";
                    staffDataGridView.Columns[2].HeaderText = "First Name";
                    staffDataGridView.Columns[3].HeaderText = "Job Title";
                    staffDataGridView.Columns[4].HeaderText = "Password";
                    staffDataGridView.Columns[5].HeaderText = "AccessRight";
                    firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    this.Text = "用戶管理系統";
                    staffNumberLabel.Text = "員工編號:";
                    lblAR.Text = "進階權限:";
                    lblFN.Text = "名稱:";
                    lblLN.Text = "姓氏:";
                    lblPW.Text = "密碼:";
                    lblJT.Text = "職位:";
                    bindingNavigatorDeleteItem.Text ="刪除";
                    bindingNavigatorClearandAdd.Text ="清空以新增";
                    btnConfirmAdd.Text = "確定新增或修改";
                    bindingNavigatorMoveLastItem.Text ="尾";
                    bindingNavigatorMoveNextItem.Text ="下一個";
                    bindingNavigatorMovePreviousItem.Text ="上一個";
                    bindingNavigatorMoveFirstItem.Text = "首";
                    lblDesc.Text = "控制工具";
                    lblRecord.Text = "員工帳號記錄";
                    staffDataGridView.Columns[0].HeaderText = "員工編號";
                    staffDataGridView.Columns[1].HeaderText = "姓氏";
                    staffDataGridView.Columns[2].HeaderText = "名稱";
                    staffDataGridView.Columns[3].HeaderText = "職位";
                    staffDataGridView.Columns[4].HeaderText = "密碼";
                    staffDataGridView.Columns[5].HeaderText = "進階權限";
                    firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    this.Text = "用户管理系统";
                    staffNumberLabel.Text = "员工编号:";
                    lblAR.Text = "进阶权限:";
                    lblFN.Text = "名称:";
                    lblLN.Text = "姓氏:";
                    lblPW.Text = "密码:";
                    lblJT.Text = "职位:";
                    bindingNavigatorDeleteItem.Text = "删除";
                    bindingNavigatorClearandAdd.Text = "清空以新增";
                    btnConfirmAdd.Text = "确定新增或修改";
                    bindingNavigatorMoveLastItem.Text = "尾";
                    bindingNavigatorMoveNextItem.Text = "下一个";
                    bindingNavigatorMovePreviousItem.Text = "上一个";
                    bindingNavigatorMoveFirstItem.Text = "首";
                    lblDesc.Text ="控制工具";
                    lblRecord.Text = "员工帐号记录";
                    staffDataGridView.Columns[0].HeaderText = "员工编号";
                    staffDataGridView.Columns[1].HeaderText = "姓氏";
                    staffDataGridView.Columns[2].HeaderText = "名称";
                    staffDataGridView.Columns[3].HeaderText = "职位";
                    staffDataGridView.Columns[4].HeaderText = "密码";
                    staffDataGridView.Columns[5].HeaderText = "进阶权限";
                    firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
                    break;
            }
        }

        private void UserMaintenance_Load(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.rSSDatabaseDataSet.Staff);
            firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            isAdding = false;
            if (staffBindingNavigator.AddNewItem != null)
            {
                if (staffNumberTextBox.Text == mMfrm.SNum)
                {
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show("You Can't Delete This Account When you are login with this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("你無法移除當前登入的帳號。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("你无法移除当前登入的帐号。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    if (staffNumberTextBox.Text != "")
                    {
                        switch (language)
                        {
                            case "English":
                                if (MessageBox.Show(
                                "Do you really want to delete this user?\r\nDelect a User: " + "which Staff Number is " + staffNumberTextBox.Text.ToString(),
                                "Warning", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    MessageBox.Show("Data Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    this.rSSDatabaseDataSet.Staff.Rows[staffBindingSource.Position].Delete();
                                    this.Validate();
                                    this.tableAdapterManager.UpdateAll(this.rSSDatabaseDataSet);
                                    staffDataGridView.Enabled = true;
                                }
                                break;

                            case "TraditionalChinese":
                                if (MessageBox.Show(
                                " 確定要刪除這名用戶嗎？\r\n刪除下列用戶: " + "，其員工編號為 " + staffNumberTextBox.Text.ToString(),
                                "Warning", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    MessageBox.Show("資料已更新.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    this.rSSDatabaseDataSet.Staff.Rows[staffBindingSource.Position].Delete();
                                    this.Validate();
                                    this.tableAdapterManager.UpdateAll(this.rSSDatabaseDataSet);
                                    staffDataGridView.Enabled = true;
                                }
                                break;


                            case "SimplifiedChinese":
                                if (MessageBox.Show(
                                " 确定要删除这名用户吗？\r\n删除下列用户: " + "，其员工编号为 " + staffNumberTextBox.Text.ToString(),
                                "Warning", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                                {
                                    MessageBox.Show("资料已更新.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    this.rSSDatabaseDataSet.Staff.Rows[staffBindingSource.Position].Delete();
                                    this.Validate();
                                    this.tableAdapterManager.UpdateAll(this.rSSDatabaseDataSet);
                                    staffDataGridView.Enabled = true;
                                }
                                break;
                        }
                    }
                    else
                    {
                        staffNumberTextBox.Text = staffDataGridView.Rows[staffBindingSource.Position].Cells[0].Value.ToString();
                    }
                }
            }
            else
            {
                staffBindingSource.RemoveCurrent();
                staffBindingNavigator.AddNewItem = bindingNavigatorClearandAdd;
                staffBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
                staffBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
                staffBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
                staffBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
                bindingNavigatorMoveLastItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMoveNextItem.Enabled = true;
                btnConfirmAdd.Enabled = false;
                staffDataGridView.Enabled = true;
            }
        }


        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
                if (staffNumberTextBox.Text != "" && lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && jobTitleTextBox.Text != "" && passwordTextBox.Text != "")
                {
                if(passwordTextBox.Text.Count() > 7) {
                    if (CheckStaffNum())
                    {
                        if (isAdding == true)
                        {
                            switch (language)
                            {
                                case "English":
                                    MessageBox.Show("Add a User: " + "with\r\nStaff Number " + staffNumberTextBox.Text + "\r\nName " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\r\nJob Title " + jobTitleTextBox.Text + "\r\nAccessRight" + accessRightCheckBox.Checked.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    addUser();
                                    break;

                                case "TraditionalChinese":
                                    MessageBox.Show("新增用戶: " + "\r\n員工編號為： " + staffNumberTextBox.Text + "\r\n姓名： " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\r\n職位： " + jobTitleTextBox.Text + "\r\n進階權限： " + accessRightCheckBox.Checked.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    addUser();
                                    break;

                                case "SimplifiedChinese":
                                    MessageBox.Show("新增用户: " + "\r\n员工编号为： " + staffNumberTextBox.Text + "\r\n姓名： " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\r\n职位： " + jobTitleTextBox.Text + "\r\n进阶权限： " + accessRightCheckBox.Checked.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    addUser();
                                    break;
                            }
                            //this.tableAdapterManager.StaffTableAdapter.Insert(staffNumberTextBox.Text, lastNameTextBox.Text, firstNameTextBox.Text, jobTitleTextBox.Text, passwordTextBox.Text, accessRightCheckBox.Checked);
                        }
                    }
                    else if (isAdding == true)
                    {
                        switch (language)
                        {
                            case "English":
                                MessageBox.Show(staffNumberTextBox.Text + ", This Staff Number is already used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case "TraditionalChinese":
                                MessageBox.Show(staffNumberTextBox.Text + ", 已被使用.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case "SimplifiedChinese":
                                MessageBox.Show(staffNumberTextBox.Text + ", 已被使用.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        staffNumberTextBox.Text = "";
                    }
                    else if (staffNumberTextBox.Text == EditingNum && isEditing == true)
                    {
                        staffNumberTextBox.Text = EditingNum;
                        staffBindingSource.EndEdit();
                        staffTableAdapter.Update(rSSDatabaseDataSet.Staff);
                        staffDataGridView.Enabled = true;
                        staffBindingSource.Position = staffDataGridView.CurrentRow.Index;
                        bindingNavigatorDeleteItem.Enabled = true;
                        staffBindingNavigator.AddNewItem = bindingNavigatorClearandAdd;
                        staffBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
                        staffBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
                        staffBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
                        staffBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
                        bindingNavigatorMoveLastItem.Enabled = true;
                        bindingNavigatorMovePreviousItem.Enabled = true;
                        bindingNavigatorMoveFirstItem.Enabled = true;
                        bindingNavigatorMoveNextItem.Enabled = true;
                        btnConfirmAdd.Enabled = false;
                        staffDataGridView.Enabled = true;
                        bindingNavigatorDeleteItem.Enabled = true;
                        isEditing = false;
                    }
                    else
                    {
                        refreshData();
                        isEditing = false;
                    }
                }
                else
                {
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show("Password length must be more than 7.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("密碼必須大於7位字元", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("密码必须大于7位字元", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }


            }
            else {
                switch (language)
                {
                    case "English":
                        MessageBox.Show("Please Fill all item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case "TraditionalChinese":
                        MessageBox.Show("請填上所有資料", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case "SimplifiedChinese":
                        MessageBox.Show("请填上所有资料", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }      
        }
        private bool CheckStaffNum()
        {
            DataTable dt = new DataTable();
            sqlStr = "Select * from Staff";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            bool Pass = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (staffNumberTextBox.Text == (dt.Rows[i]["StaffNumber"].ToString()))
                {
                    Pass = false;
                    break;
                }
                else { Pass = true; }
            }
            return Pass;
        }

        private void bindingNavigatorClearandAdd_Click(object sender, EventArgs e)
        {
            firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            if (isEditing == false)
            {
                isAdding = true;
                if ((staffNumberTextBox.Text == "" || lastNameTextBox.Text == "" || firstNameTextBox.Text == "" || jobTitleTextBox.Text == "" || passwordTextBox.Text == "") && staffBindingNavigator.AddNewItem == null)
                {
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show("Please Fill all item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("請填上所有資料", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("请填上所有资料", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
                if ((staffNumberTextBox.Text != "" && lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && jobTitleTextBox.Text != "" && passwordTextBox.Text != "") && staffBindingNavigator.AddNewItem == null)
                {
                    switch (language)
                    {
                        case "English":
                            MessageBox.Show("If you want to add this user, please click 'confirm to add' button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        case "TraditionalChinese":
                            MessageBox.Show("請按「確定新增或修改」以進行新增用戶。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;

                        case "SimplifiedChinese":
                            MessageBox.Show("请按「确定新增或修改」以进行新增用户。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
                else { disableAll(); }
            }
            else
            {
                switch (language)
                {
                    case "English":
                        MessageBox.Show("If you want to Edit this user, please click 'Confirm Add or Modify' button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case "TraditionalChinese":
                        MessageBox.Show("請按「確定新增或修改」以進行修改用戶。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case "SimplifiedChinese":
                        MessageBox.Show("请按「确定新增或修改」以进行修改用户。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }

            }
        }

        private void staffNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (isAdding == false)
            {
                isEditing = true;
                disableAll();
                foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                {
                    EditingNum = row.Cells[0].Value.ToString();
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void disableAll()
        {
            staffBindingNavigator.AddNewItem = null;
            staffBindingNavigator.MoveFirstItem = null;
            staffBindingNavigator.MoveLastItem = null;
            staffBindingNavigator.MoveNextItem = null;
            staffBindingNavigator.MovePreviousItem = null;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            btnConfirmAdd.Enabled = true;
            staffDataGridView.Enabled = false;
            firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            if (isAdding == false)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            lastNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;

            if (isAdding == false)
            {
                isEditing = true;
                disableAll();
                foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                {
                    EditingNum = row.Cells[0].Value.ToString();
                }
            }

        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            firstNameTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;

            if (isAdding == false)
            {
                isEditing = true;
                disableAll();
                foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                {
                    EditingNum = row.Cells[0].Value.ToString();
                }
            }

        }

        private void jobTitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            jobTitleTextBox.ImeMode = System.Windows.Forms.ImeMode.OnHalf;

            if (isAdding == false)
            {
                isEditing = true;
                disableAll();
                foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                {
                    EditingNum = row.Cells[0].Value.ToString();
                }
            }

        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (isAdding == false)
            {
                isEditing = true;
                disableAll();
                foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                {
                    EditingNum = row.Cells[0].Value.ToString();
                }
            }
        }

        private void refreshData()
        {
            switch (language)
            {
                case "English":
                    this.Validate();
                    this.staffBindingSource.EndEdit();
                    MessageBox.Show("Data Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if(isAdding == false)
                        staffTableAdapter.Update(rSSDatabaseDataSet.Staff);
                    staffBindingNavigator.Refresh();
                    staffBindingSource.Position = staffDataGridView.CurrentRow.Index;
                    staffDataGridView.Enabled = true;
                    isAdding = false;
                    bindingNavigatorDeleteItem.Enabled = true;
                    break;

                case "TraditionalChinese":
                    this.Validate();
                    this.staffBindingSource.EndEdit();
                    MessageBox.Show("資料已更新.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (isAdding == false)
                        staffTableAdapter.Update(rSSDatabaseDataSet.Staff);
                    staffBindingNavigator.Refresh();
                    staffBindingSource.Position = staffDataGridView.CurrentRow.Index;
                    staffDataGridView.Enabled = true;
                    isAdding = false;
                    bindingNavigatorDeleteItem.Enabled = true;
                    break;

                case "SimplifiedChinese":

                    this.Validate();
                    this.staffBindingSource.EndEdit();
                    MessageBox.Show("资料已更新.", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (isAdding == false)
                        staffTableAdapter.Update(rSSDatabaseDataSet.Staff);
                    staffBindingNavigator.Refresh();
                    staffBindingSource.Position = staffDataGridView.CurrentRow.Index;
                    staffDataGridView.Enabled = true;
                    isAdding = false;
                    bindingNavigatorDeleteItem.Enabled = true;
                    break;
            }
            staffBindingNavigator.AddNewItem = bindingNavigatorClearandAdd;
            staffBindingNavigator.MoveFirstItem = bindingNavigatorMoveFirstItem;
            staffBindingNavigator.MoveLastItem = bindingNavigatorMoveLastItem;
            staffBindingNavigator.MoveNextItem = bindingNavigatorMoveNextItem;
            staffBindingNavigator.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            btnConfirmAdd.Enabled = false;
            staffDataGridView.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void accessRightCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isAdding == false)
            {
                isEditing = true;
                disableAll();
                foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                {
                    EditingNum = row.Cells[0].Value.ToString();
                    string OldcheckBox = row.Cells[5].Value.ToString();
                    if (accessRightCheckBox.Checked == true && OldcheckBox == mMfrm.SRight && EditingNum == mMfrm.SNum)
                    {
                        switch (language)
                        {
                            case "English":
                                MessageBox.Show("You Cannot change your accrss right when you login with this account.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                accessRightCheckBox.Checked = true;
                                break;

                            case "TraditionalChinese":
                                MessageBox.Show("你無法改變現時登入帳號的進階權限。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                accessRightCheckBox.Checked = true;
                                break;

                            case "SimplifiedChinese":
                                MessageBox.Show("你无法改变现时登入帐号的进阶权限。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                accessRightCheckBox.Checked = true;
                                break;
                        }
                    }
                }
            }
        }

        private void addUser()
        {
            RSSDatabaseDataSet.StaffRow row = rSSDatabaseDataSet.Staff.NewStaffRow();
            row.SetField(0, staffNumberTextBox.Text);
            row.SetField(1, lastNameTextBox.Text);
            row.SetField(2, firstNameTextBox.Text);
            row.SetField(3, jobTitleTextBox.Text);
            row.SetField(4, passwordTextBox.Text);
            row.SetField(5, accessRightCheckBox.Checked);
            isAdding = false;
            refreshData();
        }
    }
}
