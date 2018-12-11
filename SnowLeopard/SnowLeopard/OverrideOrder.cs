using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class OverrideOrder
    {
        public virtual void Print()
        {
            Console.WriteLine("OverrideOrder");
        }
    }
    public class OverrideOrder1 : OverrideOrder
    {
        //public override void Print()
        //{
        //    Console.WriteLine("OverrideOrder1");
        //    base.Print();
        //}
    }
    public class OverrideOrder2 : OverrideOrder1
    {
        public override void Print()
        {
            Console.WriteLine("OverrideOrder2");
            base.Print();
        }
    }
}
