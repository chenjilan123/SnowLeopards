using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class ShortcutDemo : SnowLeopard.Controls.Blue
    {
        public ShortcutDemo()
        {
            InitializeComponent();
            this.pictureBox1.Image = Image.FromFile($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\JollyRoger.jpg");

            //AccessibilityObject
            button1.AccessibleDefaultActionDescription = "Say Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
