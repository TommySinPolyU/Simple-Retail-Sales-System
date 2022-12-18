using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Sales_SystemV1._0
{
    public partial class IEMMainMenu : Form
    {
        public string SName = "";
        public string SNum = "";
        public string SPos = "";
        public string SRight;
        public string language = "";
        public RSSIEM loginfrm;
        private ItemEnquiryandMaintenance eryfrm;
        private UserMaintenance mtcfrm;
        public SearchFunction sF;
        public UpdateFunction uF;
        public IEMMainMenu()
        {
            InitializeComponent();
        }

        private void btnLout_Click(object sender, EventArgs e)
        {
            loginfrm.language = this.language;
            if(sF!=null)
                sF.Close();
            if (uF != null)
                uF.Close();
            this.Hide();
            loginfrm.Show();   
        }

        private void btnery_Click(object sender, EventArgs e)
        {
            foreach(Form child in this.MdiChildren)
            {
                if (!child.Name.Equals("ItemEnquiryandMaintenance" ) || !child.Focused) //!child.Focused
                {
                    child.Close();
                }
            }

            eryfrm = new ItemEnquiryandMaintenance(this);
            eryfrm.MdiParent = this;
            eryfrm.Dock = DockStyle.Fill;
            System.Threading.Thread.Sleep(200);
            eryfrm.mMfrm = this;
            eryfrm.Show();
         }

        private void btnUM_Click(object sender, EventArgs e)
        {
            
            foreach (Form child in this.MdiChildren)
            {
                if (!child.Name.Equals("UserMaintenance")||!child.Focused)
                {
                    child.Close();
                }
            }
            if (SRight == "True" || SRight == "true")
            {
                mtcfrm = new UserMaintenance(this);
                mtcfrm.MdiParent = this;
                mtcfrm.Dock = DockStyle.Fill;
                System.Threading.Thread.Sleep(200);
                mtcfrm.Show();
            }
            else
            {
                mtcfrm = new UserMaintenance(this);
                mtcfrm.MdiParent = this;
                mtcfrm.Dock = DockStyle.Fill;
                System.Threading.Thread.Sleep(200);
                mtcfrm.Hide();
                switch (language)
                {

                    case "English":
                        MessageBox.Show("You are not allow to manage user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "TraditionalChinese":
                        MessageBox.Show("你沒有權限去管理用戶。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "SimplifiedChinese":
                        MessageBox.Show("你没有权限去管理用户。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'rSSDatabaseDataSet.ModifyRecord' 資料表。您可以視需要進行移動或移除。
            this.modifyRecordTableAdapter.Fill(this.rSSDatabaseDataSet.ModifyRecord);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // auto maximize the main menu   
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        // call the method to change the language to english.
        {
            changeLanguage("English");
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "UserMaintenance" && mtcfrm != null)
                {
                    mtcfrm.changeLanguage(language);
                }

                if (frm.Name == "ItemEnquiryandMaintenance" && eryfrm != null)
                {
                    eryfrm.changeLanguage(language);
                }

            }
        }

        private void traditionalChineseToolStripMenuItem_Click(object sender, EventArgs e)
        // call the method to change the language to Traditional Chinese.
        {
            changeLanguage("TraditionalChinese");
            foreach (Form frm in Application.OpenForms )
            {
                if (frm.Name == "UserMaintenance" && mtcfrm != null)
                {
                    mtcfrm.changeLanguage(language);
                }

                if (frm.Name == "ItemEnquiryandMaintenance" && eryfrm != null)
                {
                    eryfrm.changeLanguage(language);
                }
            }
        }

        private void simplifiedChineseToolStripMenuItem_Click(object sender, EventArgs e)
        // call the method to change the language to Simplified Chinese.
        {
            changeLanguage("SimplifiedChinese");
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "UserMaintenance" && mtcfrm != null)
                {
                    mtcfrm.changeLanguage(language);
                }

                if (frm.Name == "ItemEnquiryandMaintenance" && eryfrm != null)
                {
                    eryfrm.changeLanguage(language);
                }
            }
        }

        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            switch (Lang)
            {
                case "English":
                    language = "English";
                    tbInfo.Text = "StaffName: " + SName + "\r\nNumber: \t" + SNum + "\r\nPosition: \t" + SPos;
                    btnery.Text = "Item Enquiry and Maintenance";
                    btnLout.Text = "Logout";
                    btnUM.Text = "User Management";
                    btnLang.Text = "Language";
                    btnEng.Text = "English";
                    btnSC.Text = "Simplified Chinese";
                    btnTC.Text = "Traditional Chinese";
                    this.Text = "RSS - Item Enquiry and Maintenance";
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    tbInfo.Text = "員工名稱: " + SName + "\r\n員工編號: " + SNum + "\r\n員工職位: " + SPos;
                    btnery.Text = "貨品查詢及維護";
                    btnLout.Text = "登出";
                    btnUM.Text = "用戶管理";
                    btnLang.Text = "語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "簡體中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    this.Text = "零售系統 - 貨品及貨存維護";
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    tbInfo.Text = "员工名称: " + SName + "\r\n员工编号: " + SNum + "\r\n员工职位: " + SPos;
                    btnery.Text = "货品查询及维护";
                    btnLout.Text = "登出";
                    btnUM.Text = "用户管理";
                    btnLang.Text = "语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁体中文(Traditional Chinese)";
                    this.Text = "零售系统 - 货品及货存维护";  
                    break;
            }
            loginfrm.changeLanguage(language);
        }

        private void modifyRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modifyRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rSSDatabaseDataSet);

        }

        private void IEMMainMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // auto maximize the main menu   
        }
    }
}
