using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoII
{
    public class DataErrorForm : Form
    {
        private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();

        public DataErrorForm()
        {
            // Initialize the form.
            this.dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            // Attach the DataError event to the corresponding event handler.
            //this.dataGridView1.DataError +=
            //    new DataGridViewDataErrorEventHandler(dataGridView1_DataError);

            // Initialize the BindingSource and bind the DataGridView to it.

            Thread thread = new Thread(() =>
            {
                bindingSource1.DataSource = GetData("select * from Customers");
            });
            thread.Start();
            thread.Join();

            //bindingSource1.DataSource = GetData("select * from dbo.Config");
            this.dataGridView1.DataSource = bindingSource1;
            this.dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        private static DataTable GetData(string selectCommand)
        {
            string connectionString =
                "Integrated Security=SSPI;Persist Security Info=False;" +
                "Initial Catalog=Northwind;Data Source=localhost;Packet Size=4096";
            //string connectionString =
            //    "Integrated Security=SSPI;Persist Security Info=False;" +
            //    "Initial Catalog=Sapphire;Data Source=localhost;Packet Size=4096";

            //string connectionString =
            //    "Data Source=localhost;" +
            //    "Initial Catalog=Sapphire;" +
            //    "Integrated Security=True";

            // Connect to the database and fill a data table, including the 
            // schema information that contains the CustomerID column 
            // constraint.
            SqlDataAdapter adapter =
                new SqlDataAdapter(selectCommand, connectionString);
            DataTable data = new DataTable();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(data);
            adapter.FillSchema(data, SchemaType.Source);

            return data;
        }
        private void dataGridView1_DataError(object sender,
   DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is 
            // commited, display an error message.
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("CustomerID value must be unique.");
            }
        }
    }
}
