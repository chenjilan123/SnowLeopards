using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Controls
{
    public class SpaceShip
    {
        private float weight;
        public SpaceShip(float weight, string name, string motive, string remark, DateTime produceYear)
        {
            this.weight = weight;
            ShipName = name;
            Motive = motive;
            Remark = remark;
            ProduceYear = produceYear;
        }
        public string Weight { get { return weight + "kg"; } }
        public string ShipName { get; set; }
        public string Motive { get; set; }
        public string Remark { get; set; }
        public DateTime ProduceYear { get; set; }
    }
}
