namespace SnowLeopard.Controls.DemoII
{
    partial class YDatagridview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spaceships = new System.Windows.Forms.DataGridView();
            this.ShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduceYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spaceships)).BeginInit();
            this.SuspendLayout();
            // 
            // spaceships
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.spaceships.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.spaceships.BackgroundColor = System.Drawing.SystemColors.Window;
            this.spaceships.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spaceships.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spaceships.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.spaceships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spaceships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipName,
            this.Motive,
            this.Weight,
            this.ProduceYear,
            this.Remark,
            this.Empty});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.spaceships.DefaultCellStyle = dataGridViewCellStyle4;
            this.spaceships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spaceships.EnableHeadersVisualStyles = false;
            this.spaceships.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.spaceships.Location = new System.Drawing.Point(8, 39);
            this.spaceships.Name = "spaceships";
            this.spaceships.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.spaceships.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.spaceships.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.spaceships.RowTemplate.Height = 23;
            this.spaceships.Size = new System.Drawing.Size(765, 424);
            this.spaceships.TabIndex = 1;
            this.spaceships.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spaceships_CellContentClick);
            // 
            // ShipName
            // 
            this.ShipName.DataPropertyName = "ShipName";
            this.ShipName.HeaderText = "名称";
            this.ShipName.Name = "ShipName";
            // 
            // Motive
            // 
            this.Motive.DataPropertyName = "Motive";
            this.Motive.HeaderText = "动力";
            this.Motive.Name = "Motive";
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle3.Format = "0.00kg";
            dataGridViewCellStyle3.NullValue = null;
            this.Weight.DefaultCellStyle = dataGridViewCellStyle3;
            this.Weight.HeaderText = "重量";
            this.Weight.Name = "Weight";
            // 
            // ProduceYear
            // 
            this.ProduceYear.DataPropertyName = "ProduceYear";
            this.ProduceYear.HeaderText = "生产年份";
            this.ProduceYear.Name = "ProduceYear";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // Empty
            // 
            this.Empty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empty.HeaderText = "";
            this.Empty.Name = "Empty";
            // 
            // YDatagridview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 471);
            this.Controls.Add(this.spaceships);
            this.Name = "YDatagridview";
            this.Text = "YDatagridview";
            this.Load += new System.EventHandler(this.YDatagridview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spaceships)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView spaceships;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empty;
    }
}