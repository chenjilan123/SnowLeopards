using SnowLeopard.Controls.Web.BSObject;
using SnowLeopard.Controls.Web.CSObject;
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
        #region 字段
        private bool _isDocumentCompleted = false;
        private BSFullScrean _bsFullScrean = null;
        #endregion

        #region 构造
        public IEBrowser()
        {
            InitializeComponent();

        }
        #endregion

        #region 加载
        private void IEBrowser_Load(object sender, EventArgs e)
        {
            wb.Url
                //= new Uri("http://127.0.0.1/FullScrean/");
                = new Uri(@"P:\IIS\Test\FullScrean\index.html");
            wb.DocumentCompleted += Wb_DocumentCompleted;
            //初始化BS对象
            InitBSScript();
        }
        #endregion

        #region 文档加载完成
        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this._isDocumentCompleted = true;
            //初始化CS对象
            InitCSScript(wb);
        }
        #endregion

        #region 初始化CS对象
        private void InitCSScript(WebBrowser browser)
        {
            _bsFullScrean = new BSFullScrean(browser.Document);
        }
        #endregion

        #region 初始化BS对象
        private void InitBSScript()
        {
            var csFullScrean = new ObjForFullScrean(this
                //, this.pnlBrowser);
                , this.wb);
            
            wb.ObjectForScripting = csFullScrean;
        }
        #endregion

        #region 提供全屏接口给BS

        #region 执行BS脚本
        private void InvokeScript()
        {
            if (!_isDocumentCompleted)
            {
                MessageBox.Show("文档未加载完成");
                return;
            }
            _bsFullScrean.Test();
        }
        #endregion

        #region 全屏

        #endregion

        #endregion

        private void btnTestBS_Click(object sender, EventArgs e)
        {
            InvokeScript();
        }
    }
}
