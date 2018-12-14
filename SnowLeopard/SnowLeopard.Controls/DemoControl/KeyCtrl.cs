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
            this.MouseClick += KeyCtrl_MouseClick;
        }

        private void KeyCtrl_MouseClick(object sender, MouseEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Button", e.Button);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Clicks", e.Clicks);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "X", e.X);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Y", e.Y);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Delta", e.Delta);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Location", e.Location);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MouseClick Event");
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
