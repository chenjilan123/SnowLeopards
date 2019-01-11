namespace SnowLeopard.Controls.Demo
{
    partial class CommonOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonOp));
            this.btnOK = new System.Windows.Forms.Button();
            this.pic = new CCWin.SkinControl.SkinPictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(117, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Location = new System.Drawing.Point(11, 42);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 106);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // btnImg
            // 
            this.btnImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImg.BackgroundImage")));
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Location = new System.Drawing.Point(117, 42);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(20, 20);
            this.btnImg.TabIndex = 2;
            this.btnImg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(117, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CommonOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnOK);
            this.Name = "CommonOp";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private CCWin.SkinControl.SkinPictureBox pic;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}