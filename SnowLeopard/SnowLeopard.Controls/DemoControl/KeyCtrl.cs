using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoControl
{
    public partial class KeyCtrl : UserControl
    {
        public KeyCtrl()
        {
            InitializeComponent();
            this.PreviewKeyDown += KeyCtrl_PreviewKeyDown;
        }

        private void KeyCtrl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.IsInputKey = true;
            }
        }
        protected override bool IsInputKey(Keys keyData)
        {
            MessageBox.Show("IsInputKey Event Raised");
            return base.IsInputKey(keyData);
        }
    }
}
