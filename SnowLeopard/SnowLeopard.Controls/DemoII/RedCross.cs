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
    public partial class RedCross : Form
    {
        DataTable table = new DataTable();
        DataRow deleteRow;
        public RedCross()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            dataGridView1.DataSource = table;
            table.Columns.AddRange(new[]
            {
                new DataColumn("Column1"),
                new DataColumn("Column2"),
                new DataColumn("Column3"),
                new DataColumn("Column4"),
            });
        }

        private void RedCross_Load(object sender, EventArgs e) => RefreshData();

        private void RefreshData()
        {
            var thread = new Thread(() =>
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var newRow = table.NewRow();
                        newRow["Column1"] = i * 2 + 4;
                        newRow["Column2"] = i * 3 + 4;
                        newRow["Column3"] = i * 4 + 4;
                        newRow["Column4"] = DateTime.Now;
                        table.Rows.Add(newRow);
                    }
                    {
                        var newRow = table.NewRow();
                        newRow["Column1"] = 10000;
                        newRow["Column2"] = 3 * 3 + 4;
                        newRow["Column3"] = 3 * 4 + 4;
                        newRow["Column4"] = 3 * 5 + 4;
                        table.Rows.Add(newRow);
                        deleteRow = newRow;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
            thread.Start();
            thread.Join();
            Thread.Sleep(200);

            table.Rows.Remove(deleteRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            RefreshData();

            return;
            var table = new DataTable();
            table.Columns.AddRange(new[]
            {
                new DataColumn("Column1"),
                new DataColumn("Column2"),
                new DataColumn("Column3"),
                new DataColumn("Column4"),
            });
            for (int i = 0; i < 10; i++)
            {
                var newRow = table.NewRow();
                newRow["Column1"] = i * 2 + 10;
                newRow["Column2"] = i * 3 + 10;
                newRow["Column3"] = i * 4 + 10;
                newRow["Column4"] = i * 5 + 10;
                table.Rows.Add(newRow);
            }
            dataGridView1.DataSource = table;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
