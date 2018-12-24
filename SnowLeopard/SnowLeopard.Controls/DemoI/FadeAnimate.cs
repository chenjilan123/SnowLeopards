using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class FadeAnimate : BlueForm
    {
        private const int SW_TIME = 2000;
        private const int CL_TIME = 2000;
        private bool _UseSlideAnimation;
        public FadeAnimate()
        {
            InitializeComponent();
            _UseSlideAnimation = true;
            this.TopMost = false;

            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FadeAnimate_FormClosing);
            //this.Load += new System.EventHandler(this.FadeAnimate_Load);
        }
        

        const int AW_HIDE = 0X10000;
        const int AW_ACTIVATE = 0X20000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_SLIDE = 0X40000;
        const int AW_BLEND = 0X80000;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

        //private void FadeAnimate_Load(object sender, EventArgs e)
        //{

        //    AnimateWindow(this.Handle, SW_TIME, AW_ACTIVATE | (_UseSlideAnimation ?
        //                  AW_HOR_POSITIVE | AW_SLIDE : AW_BLEND));
        //}

        //private void FadeAnimate_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.Cancel == false)
        //    {
        //        AnimateWindow(this.Handle, CL_TIME, AW_HIDE | (_UseSlideAnimation ?
        //                      AW_HOR_NEGATIVE | AW_SLIDE : AW_BLEND));
        //    }
        //}
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //AnimateWindow(this.Handle, SW_TIME, AW_ACTIVATE | (_UseSlideAnimation ?
            //              AW_HOR_POSITIVE | AW_SLIDE : AW_BLEND));
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //if (e.Cancel == false)
            //{
            //    AnimateWindow(this.Handle, CL_TIME, AW_HIDE | (_UseSlideAnimation ?
            //                  AW_HOR_NEGATIVE | AW_SLIDE : AW_BLEND));
            //}
        }

        protected override void OnActivated(EventArgs e)
        {
            //base.OnActivated(e);
        }
        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;

            }
        }

        #region 没用1
        //声明常量：(释义可参见windows API)
        const int WS_EX_NOACTIVATE = 0x08000000;
        //重载Form的CreateParams属性，添加不获取焦点属性值。
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }
        #endregion

    }
}
