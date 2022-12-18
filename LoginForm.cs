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
    public partial class RSSIEM : Form
    {
        
        public string language = "English"; // a varible to identify the language.
        private IEMMainMenu mMfrm; // a varible to set the mainmenu.
        public RSSMainMenu rSSMainFrm;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/RSSDatabase.mdb"; // a setting for the Database file.
        public string SName = ""; // a varible to save the user name.
        public string SNum = ""; // a variable to save the staff number.
        public string SPos = ""; // a variable to save the staff Job Title.
        public string SRight;
        public bool Login = false; // a variable to identify the Login information is / is not correct.
        public Message msg;
        private string mMissing = "Missing Staff Number or Password. " + "Please try again."; // a message setting for missing any information.
        private string mSuccess = "Successful Login. Welcome To Use a Retail Sales System. "; // a message setting for sucessfully Login.
        private string mWrong = "Incorrect Staff Number or Password. " + "Please try again."; // a message setting for Failed Login.
        public RSSIEM()
        {
            InitializeComponent();
        }

        private void RSSIEM_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            AcceptButton = btnLogin; // set the default accept button to Login button.
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            Login = false;
            int Fskey = 0;
            if (tbSN.Text.Length == 0 || tbPW.Text.Length == 0)
            // if user not input anything and press the login button.
            {
                MessageBox.Show(mMissing, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSN.Clear();
                tbPW.Clear();
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    sqlStr = "Select * from Staff";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    for (int i = 0; i < dt.Rows.Count && !Login; i++)
                    {
                        if (tbSN.Text.Equals(dt.Rows[i]["StaffNumber"].ToString()) && tbPW.Text.Equals(dt.Rows[i]["Password"].ToString()))
                        {
                            Login = true;
                            if (Login)
                                Fskey = i; // return the matching information index and store in FsKey.
                        }
                    }
                    // store the user information to these variable which using for show the information to main menu.
                    SName = dt.Rows[Fskey]["FirstName"].ToString() + " " + dt.Rows[Fskey]["LastName"].ToString();
                    SPos = dt.Rows[Fskey]["JobTitle"].ToString();
                    SNum = dt.Rows[Fskey]["StaffNumber"].ToString();
                    SRight = dt.Rows[Fskey]["AccessRight"].ToString();
                    if (Login)
                    // if Login successful, the screen will hide and close, and show the main menu screen.
                    {
                        MessageBox.Show(mSuccess, "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Hide();
                        mMfrm = new IEMMainMenu();
                        mMfrm.SName = this.SName;
                        mMfrm.SNum = this.SNum;
                        mMfrm.SPos = this.SPos;
                        mMfrm.SRight = this.SRight;
                        mMfrm.language = this.language;
                        mMfrm.loginfrm = this;
                        tbSN.Clear();
                        tbPW.Clear();
                        mMfrm.Closed += (s, args) => this.Close();
                        mMfrm.Show();
                    }
                    else
                    // if login not success, the system will clean all inputed information.
                    {
                        MessageBox.Show(mWrong, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbSN.Clear();
                        tbPW.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nSQL: " + sqlStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        // call the method to change the language to english.
        {
            changeLanguage("English");
        }

        private void traditionalChineseToolStripMenuItem_Click(object sender, EventArgs e)
        // call the method to change the language to Traditional Chinese.
        {
            changeLanguage("TraditionalChinese");
        }

        private void simplifiedChineseToolStripMenuItem_Click(object sender, EventArgs e)
        // call the method to change the language to Simplified Chinese.
        {
            changeLanguage("SimplifiedChinese");
        }

        public void changeLanguage(string Lang)
        // a method to handle all Language change.
        {
            switch (Lang)
            {
                case "English":
                    descr1.Text = "Please Enter The user information for login to system: ";
                    descrSN.Text = "Staff Number: ";
                    descrPW.Text = "Password: ";
                    btnLogin.Text = "Login";
                    btnClear.Text = "Clean";
                    language = "English";
                    btnLang.Text = "Language";
                    btnEng.Text = "English";
                    btnSC.Text = "Simplified Chinese";
                    btnTC.Text = "Traditional Chinese";
                    mMissing = "Missing Staff Number or Password. " + "Please try again.";
                    mSuccess = "Successful Login. Welcome To Use a Retail Sales System. ";
                    mWrong = "Incorrect Staff Number or Password. " + "Please try again.";
                    this.Text = "RSS - Item Enquiry and Maintenance - Login System";
                    labelbottom.Text = "648 Games House Retail Sales System - For Staff Only";
                    break;

                case "TraditionalChinese":
                    descr1.Text = "請輸入你的用戶資訊以登入本系統: ";
                    descrSN.Text = "員工編號: ";
                    descrPW.Text = "密碼: ";
                    btnLogin.Text = "登入";
                    btnClear.Text = "清除";
                    language = "TraditionalChinese";
                    btnLang.Text = "選擇語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "簡體中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    mWrong = "錯誤的員工編號或密碼，請再次輸入。";
                    mSuccess = "成功登入，歡迎使用本零售系統。";
                    mMissing = "請輸入員工編號及密碼。";
                    this.Text = "零售系統 - 貨品及貨存維護 - 登入系統";
                    labelbottom.Text = "648 Games House 零售系統 - 員工專用";
                    break;

                case "SimplifiedChinese":
                    descr1.Text = "请输入你的用户资讯以登入本系统: ";
                    descrSN.Text = "员工编号: ";
                    descrPW.Text = "密码: ";
                    btnLogin.Text = "登入";
                    btnClear.Text = "清除";
                    language = "SimplifiedChinese";
                    btnLang.Text = "选择语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁体中文(Traditional Chinese)";
                    mWrong = "错误的员工编号或密码，请再次输入。";
                    mSuccess = "成功登入，欢迎使用本零售系统。";
                    mMissing = "请输入员工编号及密码。";
                    this.Text = "零售系统 - 货品及货存维护 - 登入系统";
                    labelbottom.Text = "648 Games House 零售系统 - 员工专用";
                    break;
            }
            rSSMainFrm.changeLanguage(language);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbSN.Clear();
            tbPW.Clear();
        }

        private void RSSIEM_FormClosed(object sender, FormClosedEventArgs e)
        {
            rSSMainFrm = new RSSMainMenu();
            rSSMainFrm.loginFrm = this;
            rSSMainFrm.language = this.language;
            rSSMainFrm.changeLanguage(language);
            rSSMainFrm.Show();
            this.Hide();
        }

    }

}
