using SnowLeopard.Controls.DemoII;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Web.CSObject
{
    [ComVisible(true)]
    public class ObjForFullScrean
    {
        private bool _bIsFullScrean = false;
        private IEBrowser _browser = null;
        private Control _ctrlFullScrean = null;

        public ObjForFullScrean(IEBrowser browser, Control ctrlFullScrean)
        {
            this._browser = browser;
            this._ctrlFullScrean = ctrlFullScrean;
        }

        public void Test() => MessageBox.Show("Test");

        public void FullScrean()
        {
            if (_bIsFullScrean) return;
            _browser.ShowInTaskbar = false;
            _browser.Visible = false;

            Form frm = new Form();
            frm.Icon = _browser.Icon;
            frm.FormClosing += frm_FormClosing;
            frm.Tag = _ctrlFullScrean.Parent;
            frm.Controls.Add(_ctrlFullScrean);
            frm.FormBorderStyle = FormBorderStyle.None;
            _bIsFullScrean = true;
            Rectangle rect = new Rectangle();
            rect = Screen.GetBounds(_ctrlFullScrean);

            frm.Show();
            frm.DesktopBounds = rect;
            frm.BringToFront();
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Form frm = sender as Form;
                if (frm != null && frm.Tag != null)
                {
                    Control objTag = frm.Tag as Control;
                    if (objTag != null && !objTag.IsDisposed)
                    {
                        objTag.Controls.Add(_ctrlFullScrean);
                    }
                    //frm.Controls.Remove(this);
                    //frm.Close();
                }
                _browser.ShowInTaskbar = true;
                _browser.Visible = true;

                _bIsFullScrean = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CancelFullScrean()
        {
            if (!_bIsFullScrean) return;
            try
            {
                Form frm = _ctrlFullScrean.Parent as Form;
                if (frm != null && frm.Tag != null)
                {
                    Control objTag = frm.Tag as Control;
                    if (objTag != null && !objTag.IsDisposed)
                    {
                        //    objTag.Controls.Add(this);
                        frm.Close();
                    }
                    ////frm.Controls.Remove(this);
                }
                _bIsFullScrean = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool IsFullScrean()
        {
            return _bIsFullScrean;
        }
    }
}
