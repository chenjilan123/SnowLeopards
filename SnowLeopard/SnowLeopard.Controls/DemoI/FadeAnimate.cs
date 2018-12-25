using SnowLeopard.Controls.Animate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class FadeAnimate : BlueForm
    {
        public FadeAnimate()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            var frm = new FocusedForm();
            frm.Show(this);
            //ShowAnimal();
        }
        private void ShowAnimal()
        {
            var animal = new Animal();
            animal.Show();
            //animal.Show(this);
        }
        
        private async void ShowAnimalSync()
        {
            await Task.Run(() => Thread.Sleep(2000));
            var animal = new Animal();
            animal.Show();
        }
        private void ShowAnimalAsync()
        {
            try
            {
                var t = DateTime.Now;
                var animal = new Animal();
                //animal.MdiParent = this;
                animal.TopMost = true;
                //animal.Owner = this;
                animal.Activated += Animal_Activated;
                animal.Show();
                //animal.BringToFront();
                while (animal.Visible)
                {
                    Application.DoEvents();
                    if ((DateTime.Now - t).TotalSeconds > 5)
                    {
                        break;
                    }
                }
                animal.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Animal_Activated(object sender, EventArgs e)
        {
            //((Control)sender).Parent = this;
        }

        private void FadeAnimate_Load(object sender, EventArgs e)
        {
            ShowAfterTwoSecond();
        }

        private async void ShowAfterTwoSecond()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                ShowAnimalAsync();
            });
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            ShowAfterTwoSecond();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            ShowAnimalSync();
        }
    }
}
