using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class GoogleCEF : BlueForm
    {
        public GoogleCEF()
        {
            InitializeComponent();
            InitBrowser();
        }
        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            //browser = new ChromiumWebBrowser("www.google.com");
            browser = new ChromiumWebBrowser("bing.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
