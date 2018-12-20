using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class MSIE : SnowLeopard.Controls.BlueForm
    {
        public MSIE()
        {
            InitializeComponent();
        }

        private void MSIE_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://liulanmi.com/labs/core.html");
        }
    }
}
