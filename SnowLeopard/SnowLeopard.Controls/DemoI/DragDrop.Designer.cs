using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Controls.DemoI
{
    public partial class DragDrop
    {
        private void InitializeComponent()
        {
            this.textbox = new CCWin.SkinControl.SkinChatRichTextBox();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox.Location = new System.Drawing.Point(24, 59);
            this.textbox.Margin = new System.Windows.Forms.Padding(0);
            this.textbox.Name = "textbox";
            this.textbox.SelectControl = null;
            this.textbox.SelectControlIndex = 0;
            this.textbox.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.textbox.Size = new System.Drawing.Size(479, 218);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "";
            // 
            // DragDrop
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(507, 281);
            this.Controls.Add(this.textbox);
            this.Name = "DragDrop";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.ResumeLayout(false);

        }

    }
}
