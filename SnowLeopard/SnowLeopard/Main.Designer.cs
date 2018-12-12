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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnLoad = new CCWin.SkinControl.SkinButton();
            this.Number = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLoad.DownBack = null;
            this.btnLoad.Location = new System.Drawing.Point(368, 457);
            this.btnLoad.MouseBack = null;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.NormlBack = null;
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.Transparent;
            this.Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number.DownBack = null;
            this.Number.Icon = null;
            this.Number.IconIsButton = false;
            this.Number.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Number.IsPasswordChat = '\0';
            this.Number.IsSystemPasswordChar = false;
            this.Number.Lines = new string[0];
            this.Number.Location = new System.Drawing.Point(8, 39);
            this.Number.Margin = new System.Windows.Forms.Padding(0);
            this.Number.MaxLength = 32767;
            this.Number.MinimumSize = new System.Drawing.Size(28, 28);
            this.Number.MouseBack = null;
            this.Number.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Number.Multiline = true;
            this.Number.Name = "Number";
            this.Number.NormlBack = null;
            this.Number.Padding = new System.Windows.Forms.Padding(3);
            this.Number.ReadOnly = false;
            this.Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Number.Size = new System.Drawing.Size(443, 447);
            // 
            // 
            // 
            this.Number.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Number.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Number.SkinTxt.Location = new System.Drawing.Point(3, 3);
            this.Number.SkinTxt.Multiline = true;
            this.Number.SkinTxt.Name = "BaseText";
            this.Number.SkinTxt.Size = new System.Drawing.Size(437, 441);
            this.Number.SkinTxt.TabIndex = 0;
            this.Number.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Number.SkinTxt.WaterText = "";
            this.Number.TabIndex = 1;
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Number.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Number.WaterText = "";
            this.Number.WordWrap = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 494);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.Number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLoad;
        private CCWin.SkinControl.SkinTextBox Number;
    }
}