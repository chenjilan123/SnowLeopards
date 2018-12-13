namespace SnowLeopard.Controls.Demo
{
    partial class ControlEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.keyCtrl1 = new SnowLeopard.Controls.DemoControl.KeyCtrl();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(11, 42);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "Press Here";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skinButton1_KeyDown);
            this.skinButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skinButton1_KeyPress);
            this.skinButton1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.skinButton1_KeyUp);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(92, 42);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 1;
            this.skinButton2.Text = "Show";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            this.skinButton2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PreviewKeyDownHandler);
            // 
            // keyCtrl1
            // 
            this.keyCtrl1.Location = new System.Drawing.Point(173, 42);
            this.keyCtrl1.Name = "keyCtrl1";
            this.keyCtrl1.Size = new System.Drawing.Size(87, 23);
            this.keyCtrl1.TabIndex = 2;
            // 
            // ControlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(319, 112);
            this.Controls.Add(this.keyCtrl1);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Name = "ControlEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private DemoControl.KeyCtrl keyCtrl1;
    }
}
