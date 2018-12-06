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
    public partial class StartupShotdown : Form
    {
        public StartupShotdown()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private StringBuilder sbMessage = new StringBuilder();
        private Form _form = null;
        private bool _deactivated = false;
        private bool _activated = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (null != Application.OpenForms["_form"])
            {
                _form.BringToFront();
            }
            else
            {
                var form = new Form();
                RefisterStartupEvents(form);
                RefisterShotdownEvents(form);
                form.Show();
            }
        }

        private void RefisterShotdownEvents(Form form)
        {   
            form.Closing += (sender, e) => sbMessage.Append($"Closing    \r\n");
            form.FormClosing += (sender, e) => sbMessage.Append($"FormClosing\r\n");
            form.Closed += (sender, e) => sbMessage.Append($"Closed     \r\n");
            form.FormClosed += (sender, e) => sbMessage.Append($"FormClosed \r\n");
            form.Deactivate += (sender, e) =>
            {
                if (!_deactivated)
                {
                    _deactivated = true;
                    sbMessage.Append($"Deactivate \r\n");
                }
            };
        }

        private void RefisterStartupEvents(Form form)
        {
            form.HandleCreated += (sender, e) =>
            {
                sbMessage.Clear();
                sbMessage.Append($"HandleCreated\r\n");
                button1.Enabled = false;
                button2.Enabled = true;
            };
            form.BindingContextChanged += (sender, e) => sbMessage.Append($"BindingContextChanged\r\n");
            form.Load += (sender, e) => sbMessage.Append($"Load\r\n");
            form.VisibleChanged += (sender, e) => sbMessage.Append($"VisibleChanged\r\n");
            form.Activated += (sender, e) =>
            {
                if (!_activated)
                {
                    _activated = true;
                    sbMessage.Append($"Activated\r\n");
                }
            };
            form.Shown += (sender, e) => sbMessage.Append($"Shown\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sbMessage.ToString());
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
