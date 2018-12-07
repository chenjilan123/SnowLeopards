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
