using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Model.Memory
{
    public class MemoryMonitor<T>
    {
        public void Test(int count)
        {
            var type = typeof(T);
            var assembly = Assembly.GetAssembly(type);

            var lst = new List<T>();
            for (int i = 0; i < count; i++)
            {
                lst.Add((T)assembly.CreateInstance(type.FullName));
            }
            Console.ReadLine();
        }
    }
}
