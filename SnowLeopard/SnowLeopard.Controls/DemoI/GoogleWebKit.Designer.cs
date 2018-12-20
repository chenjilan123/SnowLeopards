namespace SnowLeopard.Controls.DemoI
{
    partial class GoogleWebKit
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
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webKitBrowser1.TabIndex = 0;
            this.webKitBrowser1.Url = null;
            // 
            // GoogleWebKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webKitBrowser1);
            this.Name = "GoogleWebKit";
            this.Text = "GoogleWebKit";
            this.Load += new System.EventHandler(this.GoogleWebKit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WebKit.WebKitBrowser webKitBrowser1;
    }
}