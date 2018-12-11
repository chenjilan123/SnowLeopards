using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard
{
    static class Program
    {
        static void Main()
        {
            OverrideOrderDemo();
        }
        private static void OverrideOrderDemo()
        {
            var o = new OverrideOrder2();
            o.Print();
        }
        private static void InfinityRoutine()
        {
            var ac = new InfinityProperty();
            ac.Number1 = 5;
        }
        private static void Aggre()
        {
            Console.WriteLine("Hehe");
            var lst = new List<string>
            {
                "1","2","3","4"
            };
            Console.WriteLine(lst.Aggregate<string>((sBegin, sCur) =>
            {
                return $"{sBegin},{sCur}";
            }));
        }
    }
}
