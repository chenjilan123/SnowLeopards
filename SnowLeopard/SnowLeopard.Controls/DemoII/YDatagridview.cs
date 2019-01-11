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
            this.spaceships.DataSource = SpaceShips.GetSpaceShips();

            spaceships.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 240, 250);
        }
    }


    public static class SpaceShips
    {
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
