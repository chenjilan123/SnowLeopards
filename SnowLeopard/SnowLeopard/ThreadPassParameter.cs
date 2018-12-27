using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class ThreadPassParameter
    {
        public static void Run()
        {
            var thread1 = new Thread(Thread1);
            thread1.Start(new Data1() { Id = 5, Name = "Data1" });

            var data2 = new Data2() { Id = 10, Name = "Data2" };
            var thread2 = new Thread(data2.Run);
            thread2.Start();
        }
        
        private static void Thread1(object data)
        {
            var data1 = data as Data1;
            Console.WriteLine($"Thread1 result: {data1.Id}-{data1.Name}");
        }
    }

    public class Data1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Data2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Run()
        {
            Console.WriteLine($"Data2 Result: {Id}-{Name}");
        }
    }
}
