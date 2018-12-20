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
            webKitBrowser1.Url = new Uri("http://liulanmi.com/labs/core.html");
        }
    }
}
