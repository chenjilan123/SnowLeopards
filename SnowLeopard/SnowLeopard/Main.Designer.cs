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
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SelectForm = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(146, 52);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "显示";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // SelectForm
            // 
            this.SelectForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectForm.FormattingEnabled = true;
            this.SelectForm.Location = new System.Drawing.Point(11, 51);
            this.SelectForm.Name = "SelectForm";
            this.SelectForm.Size = new System.Drawing.Size(121, 22);
            this.SelectForm.TabIndex = 2;
            this.SelectForm.WaterText = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(232, 86);
            this.Controls.Add(this.SelectForm);
            this.Controls.Add(this.skinButton1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinComboBox SelectForm;
    }
}