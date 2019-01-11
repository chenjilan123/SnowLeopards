using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Controls
{
    public class SpaceShip
    {
        public SpaceShip(float weight, string name, string motive, string remark, DateTime produceYear)
        {
            Weight = weight;
            ShipName = name;
            Motive = motive;
            Remark = remark;
            ProduceYear = produceYear;
        }
        public float Weight { get; set; }
        public string ShipName { get; set; }
        public string Motive { get; set; }
        public string Remark { get; set; }
        public DateTime ProduceYear { get; set; }
    }
}
