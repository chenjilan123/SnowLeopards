using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls
{
    public partial class UserInput : UserControl
    {
        public UserInput()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override bool IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            return base.ProcessDialogKey(keyData);
        }
        protected override bool IsInputChar(char charCode)
        {
            return base.IsInputChar(charCode);
        }
        protected override bool ProcessDialogChar(char charCode)
        {
            return base.ProcessDialogChar(charCode);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }
        protected override bool ProcessMnemonic(char charCode)
        {
            return base.ProcessMnemonic(charCode);
        }

    }
}
