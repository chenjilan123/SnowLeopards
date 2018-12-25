using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Model
{
    public class HerOrder
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public HerOrder(int id1, int id2)
        {
            this.Id1 = id1;
            this.Id2 = id2;
        }
    }
}
