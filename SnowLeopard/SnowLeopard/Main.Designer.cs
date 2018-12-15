namespace SnowLeopard
{
    partial class Main
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
            this.text = new CCWin.SkinControl.SkinTextBox();
            this.Run = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.DownBack = null;
            this.text.Icon = null;
            this.text.IconIsButton = false;
            this.text.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text.IsPasswordChat = '\0';
            this.text.IsSystemPasswordChar = false;
            this.text.Lines = new string[0];
            this.text.Location = new System.Drawing.Point(4, 39);
            this.text.Margin = new System.Windows.Forms.Padding(0);
            this.text.MaxLength = 32767;
            this.text.MinimumSize = new System.Drawing.Size(28, 28);
            this.text.MouseBack = null;
            this.text.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.NormlBack = null;
            this.text.Padding = new System.Windows.Forms.Padding(5);
            this.text.ReadOnly = false;
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text.Size = new System.Drawing.Size(675, 447);
            // 
            // 
            // 
            this.text.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.text.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.text.SkinTxt.Multiline = true;
            this.text.SkinTxt.Name = "BaseText";
            this.text.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text.SkinTxt.Size = new System.Drawing.Size(665, 437);
            this.text.SkinTxt.TabIndex = 0;
            this.text.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text.SkinTxt.WaterText = "";
            this.text.TabIndex = 0;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text.WaterText = "";
            this.text.WordWrap = true;
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Run.BackColor = System.Drawing.Color.Transparent;
            this.Run.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Run.DownBack = null;
            this.Run.Location = new System.Drawing.Point(595, 457);
            this.Run.MouseBack = null;
            this.Run.Name = "Run";
            this.Run.NormlBack = null;
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 1;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 490);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.text);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox text;
        private CCWin.SkinControl.SkinButton Run;
    }
}