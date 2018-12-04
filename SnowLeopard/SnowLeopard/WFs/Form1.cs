using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.WFs
{
    public class Form1: Form
    {
        public Button button1;
        public Form1()
        {
            button1 = new Button();
            button1.Size = new Size(80, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1); //add to controls collection so that Button is show in the form.
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mouse position to client: {PointToClient(MousePosition).ToString()}\r\n" +
                $"Mouse position to screen: {PointToScreen(MousePosition).ToString()}");
            //MessageBox.Show("Hello World");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
