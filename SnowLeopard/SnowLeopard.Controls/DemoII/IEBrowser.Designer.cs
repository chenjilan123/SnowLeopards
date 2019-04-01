namespace SnowLeopard.Controls.DemoII
{
    partial class IEBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEBrowser));
            this.wb = new System.Windows.Forms.WebBrowser();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.btnTestBS = new System.Windows.Forms.Button();
            this.pnlBrowser.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(800, 412);
            this.wb.TabIndex = 0;
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Controls.Add(this.wb);
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 38);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(800, 412);
            this.pnlBrowser.TabIndex = 1;
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.btnTestBS);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(800, 38);
            this.pnlOperation.TabIndex = 1;
            // 
            // btnTestBS
            // 
            this.btnTestBS.Location = new System.Drawing.Point(12, 9);
            this.btnTestBS.Name = "btnTestBS";
            this.btnTestBS.Size = new System.Drawing.Size(75, 23);
            this.btnTestBS.TabIndex = 0;
            this.btnTestBS.Text = "测试BS";
            this.btnTestBS.UseVisualStyleBackColor = true;
            this.btnTestBS.Click += new System.EventHandler(this.btnTestBS_Click);
            // 
            // IEBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.pnlOperation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IEBrowser";
            this.Text = "IEBrowser";
            this.Load += new System.EventHandler(this.IEBrowser_Load);
            this.pnlBrowser.ResumeLayout(false);
            this.pnlOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Button btnTestBS;
    }
}