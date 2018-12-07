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
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.AutoSize = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
