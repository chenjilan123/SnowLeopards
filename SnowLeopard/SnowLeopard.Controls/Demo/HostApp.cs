﻿

namespace SnowLeopard.Controls.Demo
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class HostApp : System.Windows.Forms.Form
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;
        protected internal SnowLeopard.Controls.FlashTrackBar.FlashTrackBar flashTrackBar1;

        public HostApp()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

        }

        /// <summary>
        ///    Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flashTrackBar1 = new SnowLeopard.Controls.FlashTrackBar.FlashTrackBar();
            this.SuspendLayout();
            // 
            // flashTrackBar1
            // 
            this.flashTrackBar1.BackColor = System.Drawing.Color.Black;
            this.flashTrackBar1.DarkenBy = ((byte)(200));
            this.flashTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flashTrackBar1.EndColor = System.Drawing.Color.Lime;
            this.flashTrackBar1.ForeColor = System.Drawing.Color.White;
            this.flashTrackBar1.Location = new System.Drawing.Point(0, 0);
            this.flashTrackBar1.Name = "flashTrackBar1";
            this.flashTrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flashTrackBar1.Size = new System.Drawing.Size(600, 450);
            this.flashTrackBar1.TabIndex = 0;
            this.flashTrackBar1.Text = "Drag the Mouse and say Wow!";
            this.flashTrackBar1.Value = 64;
            // 
            // HostApp
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.flashTrackBar1);
            this.Name = "HostApp";
            this.Text = "Control Example";
            this.ResumeLayout(false);

        }
    }
}
