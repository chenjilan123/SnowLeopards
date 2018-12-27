using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class ThreadPriorities
    {
        public static void Run()
        {
            var thread1 = new Thread(Thread1);

            ThreadPriority priority = ThreadPriority.Normal;
            switch (priority)
            {
                case ThreadPriority.Lowest:
                    break;
                case ThreadPriority.BelowNormal:
                    break;
                case ThreadPriority.Normal:
                    break;
                case ThreadPriority.AboveNormal:
                    break;
                case ThreadPriority.Highest:
                    break;
                default:
                    break;
            }
        }

        private static void Thread1()
        {
            Console.WriteLine("Thread 1 completed.");
        }
    }
}
