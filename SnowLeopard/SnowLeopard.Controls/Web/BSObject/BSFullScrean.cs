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
        public BSFullScrean(HtmlDocument doc) : base(doc) { }

        public void Test()
        {
            base.InvokeAction(nameof(Test));
        }
    }
}
