namespace SnowLeopard.ControlDemo
{
    partial class RichTextBoxDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextArea.Location = new System.Drawing.Point(8, 39);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(276, 181);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "";
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(209, 226);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "skinButton1";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // RichTextBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.TextArea);
            this.Name = "RichTextBoxDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextArea;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}
