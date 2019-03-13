using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoII
{
    public partial class RedCross1 : Form
    {
        public RedCross1()
        {
            InitializeComponent();
        }
        Thread listData;
        DataTable dt = new DataTable();
        private void RedCross1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Value", typeof(int));
            dataGridView1.DataSource = dt;
            listData = new Thread(delegate () { InsertOrUpdateData(5); });
            listData.Start();
            listData.Join();
        }

        private void InsertOrUpdateData(int id)
        {
            try
            {
                dt.Rows.Add("x");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
