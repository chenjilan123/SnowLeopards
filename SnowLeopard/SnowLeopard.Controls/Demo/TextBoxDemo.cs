using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class TextBoxDemo : SnowLeopard.Controls.BlueForm
    {
        public TextBoxDemo()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(skinTextBox1.Text);
            MessageBox.Show(textBox1.Text);


        }
        
    }
}
