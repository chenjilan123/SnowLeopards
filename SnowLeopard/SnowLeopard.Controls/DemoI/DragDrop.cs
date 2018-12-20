using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class DragDrop : BlueForm
    {
        //private System.ComponentModel.IContainer components;
        private CCWin.SkinControl.SkinChatRichTextBox textbox;

        public DragDrop()
        {
            InitializeComponent();
            this.DragEnter += (s, e) => AppendText("DragEnter");
            this.DragOver += (s, e) => AppendText("DragOver");
            this.DragLeave += (s, e) => AppendText("DragLeave");

            textbox.QueryContinueDrag += (s, e1) => AppendText("Button QueryContinueDrag");
            textbox.DragEnter += (s, e1) => AppendText("Button DragEnter");
            textbox.DragOver += (s, e1) => AppendText("Button DragOver");
            textbox.DragLeave += (s, e1) => AppendText("Button DragLeave");
            textbox.AllowDrop = true;
        }

        private void AppendText(string msg)
        {
            textbox.Text += $"{msg}{Environment.NewLine}";
        }

        private void dragButton1_Click(object sender, EventArgs e)
        {
            //btn.QueryContinueDrag += (s, e1) => AppendText("Button QueryContinueDrag");
            //btn.DragEnter += (s, e1) => AppendText("Button DragEnter");
            //btn.DragOver += (s, e1) => AppendText("Button DragOver");
            //btn.DragLeave += (s, e1) => AppendText("Button DragLeave");

            //DragEventArgs e2;
            //e2.AllowedEffect = DragDropEffects.All | DragDropEffects.Copy | DragDropEffects.Scroll;
            //e2.Data;
            //e2.Effect
            //e2.KeyState
            //DragAction.Cancel | DragAction.Continue | DragAction.Drop;
            //ListBox b;
            //b.FindForm();
        }

        //private void ListDragSource_QueryContinueDrag(object sender, System.Windows.Forms.QueryContinueDragEventArgs e)
        //{
        //    // Cancel the drag if the mouse moves off the form.
        //    ListBox lb = sender as ListBox;

        //    if (lb != null)
        //    {

        //        Form f = lb.FindForm();

        //        // Cancel the drag if the mouse moves off the form. The screenOffset
        //        // takes into account any desktop bands that may be at the top or left
        //        // side of the screen.
        //        if (((Control.MousePosition.X - screenOffset.X) < f.DesktopBounds.Left) ||
        //            ((Control.MousePosition.X - screenOffset.X) > f.DesktopBounds.Right) ||
        //            ((Control.MousePosition.Y - screenOffset.Y) < f.DesktopBounds.Top) ||
        //            ((Control.MousePosition.Y - screenOffset.Y) > f.DesktopBounds.Bottom))
        //        {

        //            e.Action = DragAction.Cancel;
        //        }
        //    }
        //}
    }
}
