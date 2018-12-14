namespace SnowLeopard.Controls.Demo
{
    partial class ClickDemo
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
            this.demoButton = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.demoButton.BackColor = System.Drawing.Color.Transparent;
            this.demoButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.demoButton.DownBack = null;
            this.demoButton.Location = new System.Drawing.Point(11, 49);
            this.demoButton.MouseBack = null;
            this.demoButton.Name = "skinButton1";
            this.demoButton.NormlBack = null;
            this.demoButton.Size = new System.Drawing.Size(75, 23);
            this.demoButton.TabIndex = 0;
            this.demoButton.Text = "Click Here";
            this.demoButton.UseVisualStyleBackColor = false;
            // 
            // ClickDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 83);
            this.Controls.Add(this.demoButton);
            this.Name = "ClickDemo";
            this.Text = "ClickDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton demoButton;
    }
}