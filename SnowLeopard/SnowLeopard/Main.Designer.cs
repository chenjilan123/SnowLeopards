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
            this.show1 = new CCWin.SkinControl.SkinButton();
            this.combo1 = new CCWin.SkinControl.SkinComboBox();
            this.show2 = new CCWin.SkinControl.SkinButton();
            this.combo2 = new CCWin.SkinControl.SkinComboBox();
            this.isMinimization = new CCWin.SkinControl.SkinCheckBox();
            this.show3 = new CCWin.SkinControl.SkinButton();
            this.combo3 = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // show1
            // 
            this.show1.BackColor = System.Drawing.Color.Transparent;
            this.show1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.show1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.show1.DownBack = null;
            this.show1.Location = new System.Drawing.Point(142, 72);
            this.show1.MouseBack = null;
            this.show1.Name = "show1";
            this.show1.NormlBack = null;
            this.show1.Size = new System.Drawing.Size(75, 23);
            this.show1.TabIndex = 1;
            this.show1.Text = "显示";
            this.show1.UseVisualStyleBackColor = false;
            this.show1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // combo1
            // 
            this.combo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(11, 73);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(121, 22);
            this.combo1.TabIndex = 2;
            this.combo1.WaterText = "";
            // 
            // show2
            // 
            this.show2.BackColor = System.Drawing.Color.Transparent;
            this.show2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.show2.DownBack = null;
            this.show2.Location = new System.Drawing.Point(142, 101);
            this.show2.MouseBack = null;
            this.show2.Name = "show2";
            this.show2.NormlBack = null;
            this.show2.Size = new System.Drawing.Size(75, 23);
            this.show2.TabIndex = 1;
            this.show2.Text = "显示";
            this.show2.UseVisualStyleBackColor = false;
            this.show2.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // combo2
            // 
            this.combo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(11, 102);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(121, 22);
            this.combo2.TabIndex = 2;
            this.combo2.WaterText = "";
            // 
            // isMinimization
            // 
            this.isMinimization.AutoSize = true;
            this.isMinimization.BackColor = System.Drawing.Color.Transparent;
            this.isMinimization.Checked = true;
            this.isMinimization.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isMinimization.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.isMinimization.DownBack = null;
            this.isMinimization.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isMinimization.Location = new System.Drawing.Point(11, 46);
            this.isMinimization.MouseBack = null;
            this.isMinimization.Name = "isMinimization";
            this.isMinimization.NormlBack = null;
            this.isMinimization.SelectedDownBack = null;
            this.isMinimization.SelectedMouseBack = null;
            this.isMinimization.SelectedNormlBack = null;
            this.isMinimization.Size = new System.Drawing.Size(87, 21);
            this.isMinimization.TabIndex = 3;
            this.isMinimization.Text = "自动最小化";
            this.isMinimization.UseVisualStyleBackColor = false;
            // 
            // show3
            // 
            this.show3.BackColor = System.Drawing.Color.Transparent;
            this.show3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.show3.DownBack = null;
            this.show3.Location = new System.Drawing.Point(142, 129);
            this.show3.MouseBack = null;
            this.show3.Name = "show3";
            this.show3.NormlBack = null;
            this.show3.Size = new System.Drawing.Size(75, 23);
            this.show3.TabIndex = 1;
            this.show3.Text = "显示";
            this.show3.UseVisualStyleBackColor = false;
            this.show3.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // combo3
            // 
            this.combo3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo3.FormattingEnabled = true;
            this.combo3.Location = new System.Drawing.Point(11, 130);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(121, 22);
            this.combo3.TabIndex = 2;
            this.combo3.WaterText = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(235, 166);
            this.Controls.Add(this.isMinimization);
            this.Controls.Add(this.combo3);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.show3);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.show2);
            this.Controls.Add(this.show1);
            this.Name = "Main";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.Text = "演示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton show1;
        private CCWin.SkinControl.SkinComboBox combo1;
        private CCWin.SkinControl.SkinButton show2;
        private CCWin.SkinControl.SkinComboBox combo2;
        private CCWin.SkinControl.SkinCheckBox isMinimization;
        private CCWin.SkinControl.SkinButton show3;
        private CCWin.SkinControl.SkinComboBox combo3;
    }
}