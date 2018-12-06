using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.WFs
{
    public partial class BorderTimer : Form
    {
        public BorderTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var formBorderStyle = (int)this.FormBorderStyle;
            switch (formBorderStyle)
            {
                case 6:
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                default:
                    this.FormBorderStyle = (FormBorderStyle)(formBorderStyle + 1);
                    break;
            }
        }
    }
}
