using SnowLeopard.Controls.Container;
using SnowLeopard.Controls.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class CommonOp : BlueForm
    {
        ISourceIcon _icon;
        public CommonOp()
        {
            InitializeComponent();
            _icon = new IconContainer();
            _icon.InitIcon();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var png = _icon.GetImage();

                pic.Image = png;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
