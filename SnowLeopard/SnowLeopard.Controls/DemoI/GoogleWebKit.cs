using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class GoogleWebKit : BlueForm
    {
        public GoogleWebKit()
        {
            InitializeComponent();
        }

        private void GoogleWebKit_Load(object sender, EventArgs e)
        {
            var sTest = "http://liulanmi.com/labs/core.html";
            var sAuth = "https://cloud.roadefend.com/loginRDFEmbedded.action?username=zhuser&password=961bd6e205c7accf70be384161a3aae2b8bb2104e93642393e578369172b13ef47461a67f4a95770f58f7ab88dc3111c6a199a001ae29a5c53208681b4158c1c";

            webKitBrowser2.Url = new Uri(sAuth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sPage = "https://cloud.roadefend.com/";
            webKitBrowser2.Url = new Uri(sPage);
        }
    }
}
