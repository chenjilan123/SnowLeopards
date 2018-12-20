using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Model.Memory
{
    public class MemoryInfo
    {
        public int Count { get; set; }
        public long WorkingSet { get; set; }
        public string TypeName { get; set; }
    }
}
