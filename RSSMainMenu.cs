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
    public partial class RSSMainMenu : Form
    {
        public string language = "English";
        public RSSIEM loginFrm;
        public ItemEnquiryforCustomer IEMcus;
        
        public RSSMainMenu()
        {
            InitializeComponent();
        }

        private void btnIEM_Click(object sender, EventArgs e)
        {
            loginFrm = new RSSIEM();
            if (loginFrm != null)
            {

                loginFrm.rSSMainFrm = this;
                loginFrm.language = language;
                loginFrm.changeLanguage(language);
                loginFrm.Show();
                this.Hide();
            }
        }

        private void RSSMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            switch (Lang)
            {
                case "English":
                    language = "English";
                    btnLang.Text = "Language";
                    btnEng.Text = "English";
                    btnSC.Text = "Simplified Chinese";
                    btnTC.Text = "Traditional Chinese";
                    this.Text = "RSSMainMenu";
                    btnIEM.Text = "Item Enquiry and Maintenance System";
                    btnCIE.Text = "Item Enquiry System For Customer Use";
                    btnOIE.Text = "Online Item Enquiry";
                    break;

                case "TraditionalChinese":
                    language = "TraditionalChinese";
                    btnLang.Text = "選擇語言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "簡體中文(Simplified Chinese)";
                    btnTC.Text = "繁體中文(Traditional Chinese)";
                    this.Text = "零售系統主選單";
                    btnIEM.Text = "貨品及貨存維護系統";
                    btnCIE.Text ="客戶使用的貨品查詢系統";
                    btnOIE.Text ="線上商品查詢";
                    break;

                case "SimplifiedChinese":
                    language = "SimplifiedChinese";
                    btnLang.Text = "选择语言";
                    btnEng.Text = "英文(English)";
                    btnSC.Text = "简体中文(Simplified Chinese)";
                    btnTC.Text = "繁体中文(Traditional Chinese)";
                    this.Text = "零售系统主选单";
                    btnIEM.Text = "货品及货存维护系统";
                    btnCIE.Text ="客户使用的货品查询系统";
                    btnOIE.Text ="线上商品查询";
                    break;
            }
        }

        private void btnCIE_Click(object sender, EventArgs e)
        {
            IEMcus = new ItemEnquiryforCustomer();
            if (IEMcus != null)
            {
                IEMcus.rSSMainFrm = this;
                IEMcus.language = language;
                IEMcus.changeLanguage();
                IEMcus.Show();
                this.Hide();
            }
        }

        private void btnOIE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:53804/Default");
        }
    }
}
