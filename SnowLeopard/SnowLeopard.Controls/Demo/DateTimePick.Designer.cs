namespace SnowLeopard.Controls.Demo
{
    partial class DateTimePick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimePick));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.skinDateTimePicker1 = new CCWin.SkinControl.SkinDateTimePicker();
            this.skinMonthCalendar1 = new CCWin.SkinControl.SkinMonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 48);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // skinDateTimePicker1
            // 
            this.skinDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.skinDateTimePicker1.DropDownHeight = 180;
            this.skinDateTimePicker1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.skinDateTimePicker1.DropDownWidth = 120;
            this.skinDateTimePicker1.font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.skinDateTimePicker1.Items = null;
            this.skinDateTimePicker1.Location = new System.Drawing.Point(249, 240);
            this.skinDateTimePicker1.Name = "skinDateTimePicker1";
            this.skinDateTimePicker1.Size = new System.Drawing.Size(114, 22);
            this.skinDateTimePicker1.TabIndex = 2;
            this.skinDateTimePicker1.text = "";
            // 
            // skinMonthCalendar1
            // 
            this.skinMonthCalendar1.BackColor = System.Drawing.Color.Transparent;
            this.skinMonthCalendar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinMonthCalendar1.BackgroundImage")));
            this.skinMonthCalendar1.Location = new System.Drawing.Point(249, 48);
            this.skinMonthCalendar1.Name = "skinMonthCalendar1";
            this.skinMonthCalendar1.Size = new System.Drawing.Size(180, 180);
            this.skinMonthCalendar1.TabIndex = 3;
            // 
            // DateTimePick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(543, 403);
            this.Controls.Add(this.skinMonthCalendar1);
            this.Controls.Add(this.skinDateTimePicker1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "DateTimePick";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CCWin.SkinControl.SkinDateTimePicker skinDateTimePicker1;
        private CCWin.SkinControl.SkinMonthCalendar skinMonthCalendar1;
    }
}
