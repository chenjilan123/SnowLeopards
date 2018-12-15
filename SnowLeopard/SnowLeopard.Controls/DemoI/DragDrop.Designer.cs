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
            this.components = new System.ComponentModel.Container();
            this.textbox = new CCWin.SkinControl.SkinChatRichTextBox();
            this.btn = new SnowLeopard.Controls.DragButton();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox.Location = new System.Drawing.Point(4, 39);
            this.textbox.Margin = new System.Windows.Forms.Padding(0);
            this.textbox.Name = "textbox";
            this.textbox.SelectControl = null;
            this.textbox.SelectControlIndex = 0;
            this.textbox.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.textbox.Size = new System.Drawing.Size(499, 238);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "";
            // 
            // dragButton1
            // 
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn.DownBack = null;
            this.btn.Location = new System.Drawing.Point(425, 251);
            this.btn.MouseBack = null;
            this.btn.Name = "dragButton1";
            this.btn.NormlBack = null;
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "dragButton1";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.dragButton1_Click);
            // 
            // DragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(507, 281);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textbox);
            this.Name = "DragDrop";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ResumeLayout(false);

        }

    }
}
