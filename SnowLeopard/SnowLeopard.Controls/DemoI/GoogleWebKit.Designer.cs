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
            this.button1 = new System.Windows.Forms.Button();
            this.webKitBrowser2 = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webKitBrowser2
            // 
            this.webKitBrowser2.BackColor = System.Drawing.Color.White;
            this.webKitBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser2.Location = new System.Drawing.Point(8, 39);
            this.webKitBrowser2.Name = "webKitBrowser2";
            this.webKitBrowser2.Size = new System.Drawing.Size(784, 403);
            this.webKitBrowser2.TabIndex = 2;
            this.webKitBrowser2.Url = null;
            // 
            // GoogleWebKit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webKitBrowser2);
            this.Controls.Add(this.button1);
            this.Name = "GoogleWebKit";
            this.Text = "GoogleWebKit";
            this.Load += new System.EventHandler(this.GoogleWebKit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private WebKit.WebKitBrowser webKitBrowser2;
    }
}