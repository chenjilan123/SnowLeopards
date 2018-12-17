using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Model
{
    public struct Triangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return t1.Length == t2.Length && t1.Width == t2.Width;
        }
        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return !(t1 == t2);
        }
    }
}
