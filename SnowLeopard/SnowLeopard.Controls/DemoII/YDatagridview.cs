using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoII
{
    public partial class YDatagridview : BlueForm
    {
        public YDatagridview()
        {
            InitializeComponent();
        }

        private void YDatagridview_Load(object sender, EventArgs e)
        {
            this.spaceships.DataSource = SpaceShips.GetSpaceShipsTable();//SpaceShips.GetSpaceShips();

            spaceships.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 240, 250);
        }

        private void spaceships_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    public static class SpaceShips
    {
        public static DataTable GetSpaceShipsTable()
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Weight", typeof(float)));
            dt.Columns.Add(new DataColumn("ShipName"));
            dt.Columns.Add(new DataColumn("Motive"));
            dt.Columns.Add(new DataColumn("Remark"));
            dt.Columns.Add(new DataColumn("ProduceYear"));

            dt.Columns.Add(new DataColumn("Number", typeof(int), "Weight * 2"));
            //dt.Columns.Add(new DataColumn("NumberStr", typeof(string), "[Weight]秒"));

            dt.Rows.Add(8000.745F, "Shenzhou 5", "500khz", "First", new DateTime(2006, 1, 1));
            dt.Rows.Add(9500.455F, "Shenzhou 6", "500khz", "Second", new DateTime(2006, 1, 1));
            dt.Rows.Add(6500.740F, "Shenzhou 7", "500khz", "Third", new DateTime(2006, 1, 1));
            dt.Rows.Add(7010.421F, "Shenzhou 8", "500khz", "Fourth", new DateTime(2006, 1, 1));



            return dt;
        }
        public static SpaceShip[] GetSpaceShips()
        {
            return new[]
            {
                new SpaceShip(8000.745F, "Shenzhou 5", "500khz", "First", new DateTime(2006, 1, 1)),
                new SpaceShip(9500.455F, "Shenzhou 6", "500khz", "Second", new DateTime(2006, 1, 1)),
                new SpaceShip(6500.740F, "Shenzhou 7", "500khz", "Third", new DateTime(2006, 1, 1)),
                new SpaceShip(7010.421F, "Shenzhou 8", "500khz", "Fourth", new DateTime(2006, 1, 1)),
            };
        }
    }
}
