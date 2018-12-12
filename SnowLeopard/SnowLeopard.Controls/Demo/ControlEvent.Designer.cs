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
            // ControlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(135, 72);
            this.Controls.Add(this.skinButton1);
            this.Name = "ControlEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
    }
}
