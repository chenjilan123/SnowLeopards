using SnowLeopard.Controls.DemoII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Web.BSObject
{
    public class BSFullScrean : BSObject
    {
        private readonly IEBrowser _browser;
        public BSFullScrean(IEBrowser browser, HtmlDocument doc) : base(doc)
        {
            this._browser = browser;
        }

        public void Test()
        {
            base.InvokeAction(nameof(Test));
        }
    }
}
