using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntarJaal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            browser=new ChromiumWebBrowser(txtUrl.Text);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                browser.Load(txtUrl.Text);
        }

        

        private void btnGo_Click(object sender, EventArgs e)
        {
            browser.Load(txtUrl.Text);
        }
        ChromiumWebBrowser browser;

    }
}
