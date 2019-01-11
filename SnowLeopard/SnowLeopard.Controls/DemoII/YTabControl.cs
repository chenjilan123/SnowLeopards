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
    public partial class YTabControl : BlueForm
    {
        public YTabControl()
        {
            InitializeComponent();

            xtraTabControl1.Appearance.BackColor = Color.FromArgb(215, 230, 240);
            xtraTabControl1.AppearancePage.Header.BackColor = Color.FromArgb(215, 230, 240);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
