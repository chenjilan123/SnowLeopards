namespace SnowLeopard
{
    partial class MenuContext
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
            this.ShowContext = new CCWin.SkinControl.SkinButton();
            this.cms = new CCWin.SkinControl.SkinContextMenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowContext
            // 
            this.ShowContext.BackColor = System.Drawing.Color.Transparent;
            this.ShowContext.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ShowContext.DownBack = null;
            this.ShowContext.Location = new System.Drawing.Point(11, 52);
            this.ShowContext.MouseBack = null;
            this.ShowContext.Name = "ShowContext";
            this.ShowContext.NormlBack = null;
            this.ShowContext.Size = new System.Drawing.Size(114, 52);
            this.ShowContext.TabIndex = 0;
            this.ShowContext.Text = "显示菜单";
            this.ShowContext.UseVisualStyleBackColor = false;
            this.ShowContext.Click += new System.EventHandler(this.ShowContext_Click);
            // 
            // cms
            // 
            this.cms.Arrow = System.Drawing.Color.Black;
            this.cms.Back = System.Drawing.Color.White;
            this.cms.BackRadius = 4;
            this.cms.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.cms.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cms.Fore = System.Drawing.Color.Black;
            this.cms.HoverFore = System.Drawing.Color.White;
            this.cms.ItemAnamorphosis = true;
            this.cms.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cms.ItemBorderShow = true;
            this.cms.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cms.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cms.ItemRadius = 4;
            this.cms.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.cms.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cms.Name = "cms";
            this.cms.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cms.Size = new System.Drawing.Size(84, 114);
            this.cms.SkinAllColor = true;
            this.cms.TitleAnamorphosis = true;
            this.cms.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.cms.TitleRadius = 4;
            this.cms.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "5";
            // 
            // MenuContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 129);
            this.Controls.Add(this.ShowContext);
            this.Name = "MenuContext";
            this.ShowIcon = false;
            this.Text = "上下文菜单演示";
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton ShowContext;
        private CCWin.SkinControl.SkinContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}