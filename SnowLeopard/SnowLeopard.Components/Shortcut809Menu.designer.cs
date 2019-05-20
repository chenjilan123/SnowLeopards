namespace TopMonitor.Component
{
    partial class Shortcut809Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendTxt = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnTrackReplay = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendTxt
            // 
            this.btnSendTxt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSendTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendTxt.Location = new System.Drawing.Point(19, 8);
            this.btnSendTxt.Name = "btnSendTxt";
            this.btnSendTxt.Size = new System.Drawing.Size(75, 25);
            this.btnSendTxt.TabIndex = 0;
            this.btnSendTxt.Text = "发送消息";
            this.btnSendTxt.UseVisualStyleBackColor = true;
            this.btnSendTxt.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(115, 8);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(75, 25);
            this.btnPicture.TabIndex = 1;
            this.btnPicture.Text = "拍照";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnTrackReplay
            // 
            this.btnTrackReplay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTrackReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackReplay.Location = new System.Drawing.Point(19, 43);
            this.btnTrackReplay.Name = "btnTrackReplay";
            this.btnTrackReplay.Size = new System.Drawing.Size(75, 25);
            this.btnTrackReplay.TabIndex = 2;
            this.btnTrackReplay.Text = "轨迹回放";
            this.btnTrackReplay.UseVisualStyleBackColor = true;
            this.btnTrackReplay.Click += new System.EventHandler(this.btnPlayTrack_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Location = new System.Drawing.Point(115, 43);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(75, 25);
            this.btnProperty.TabIndex = 3;
            this.btnProperty.Text = "属性";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // Shortcut809Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnTrackReplay);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnSendTxt);
            this.Name = "Shortcut809Menu";
            this.Size = new System.Drawing.Size(212, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendTxt;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnTrackReplay;
        private System.Windows.Forms.Button btnProperty;
    }
}
