using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class ThreadBegin
    {
        public static void Run()
        {
            Thread thread1 = new Thread(new ThreadStart(Thread1));
            thread1.Start();

            Thread thread2 = new Thread(new ParameterizedThreadStart(Thread2));
            thread2.Start(5);

            Console.WriteLine("Main thread completed");
        }

        private static void Thread2(object obj)
        {
            var i = (int)obj;
            Console.WriteLine($"Thread2 completed. Result : {i + 5}");
        }

        private static void Thread1()
        {
            Console.WriteLine("Thread1 completed");
        }
    }
}
