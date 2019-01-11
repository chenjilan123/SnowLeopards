using SnowLeopard.Components;
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
    public partial class ImageButton : BlueForm
    {
        public ImageButton()
        {
            InitializeComponent();

            var ell = new ElipseControl();
            ell.TargetControl = round;
            ell.CornerRadius = 10;
        }

        private void btnFire_MouseLeave(object sender, EventArgs e)
        {
            this.btnFire.Image = global::SnowLeopard.Controls.Properties.Resources.A_状态_发送;
            this.btnFire.ForeColor = Color.Black;
        }

        private void btnFire_MouseEnter(object sender, EventArgs e)
        {
            this.btnFire.Image = global::SnowLeopard.Controls.Properties.Resources.B_状态_发送;
            this.btnFire.ForeColor = Color.White;
        }

        
    }
}
