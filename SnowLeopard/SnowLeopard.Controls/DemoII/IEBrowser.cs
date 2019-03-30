using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoII
{
    public partial class IEBrowser : Form
    {
        public IEBrowser()
        {
            InitializeComponent();
        }

        private void IEBrowser_Load(object sender, EventArgs e)
        {
            wb.Url = new Uri("http://127.0.0.1/WebBrowsers/");

            InvokeScript();
        }

        #region 提供全屏接口给BS

        #region 执行BS脚本
        private void InvokeScript()
        {

        }
        #endregion

        #region 供BS脚本

        #endregion

        #region 全屏

        #endregion

        #endregion
    }
}
