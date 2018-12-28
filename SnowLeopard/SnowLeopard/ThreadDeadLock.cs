using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class ThreadDeadLock
    {
        /// <summary>
        /// Deadlock时，线程状态为WaitSleepJoin，与Sleep时一样。(占用较少资源？)
        /// 调试模式时，可能较晚发生Deadlock？
        /// 直接运行时，几乎立即发生。
        /// </summary>
        public static void Run()
        {
            //var lck1 = new Object();
            //var lck2 = new Object();
            //var locker1 = new DeadLocker(lck1, lck2);
            //var locker2 = new DeadLocker(lck2, lck1);
            //var thread1 = new Thread(locker1.ChangeState) { Name = "thread1" };
            //var thread2 = new Thread(locker2.ChangeState) { Name = "thread2" };

            var dead = new DeadLocker2();
            var thread1 = new Thread(dead.ToDead1) { Name = "thread1" };
            var thread2 = new Thread(dead.ToDead2) { Name = "thread2" };

            var thread3 = new Thread(NormalOperator) { Name = "thread3" };

            thread1.Start();
            thread2.Start();
            thread3.Start();
            ThreadStateMonitor(thread1, thread2, thread3);
        }

        private static void NormalOperator()
        {
            Thread.Sleep(3000);
            while (true)
            {

            }
        }

        private static async void ThreadStateMonitor(params Thread[] threads)
        {
            await Task.Run(() =>
            {
                do
                {
                    foreach (var thread in threads)
                    {
                        //无法访问优先级？
                        //Console.WriteLine($"{thread.Name} state: {thread.ThreadState}, priority: {thread.Priority}");
                        Console.WriteLine($"{thread.Name} state: \t\t{thread.ThreadState}\t, ApartmentState: {thread.ApartmentState}");
                    }
                    Console.WriteLine();
                    Thread.Sleep(2000);
                } while (true);
            });
        }

    }

    public class DeadLocker
    {
        private object lck1;
        private object lck2;
        public DeadLocker(object lck1, object lck2)
        {
            this.lck1 = lck1;
            this.lck2 = lck2;
        }
        public void ChangeState()
        {
            while (true)
            {
                lock (lck1)
                {
                    //Thread.Sleep(200);
                    Console.WriteLine("Running...");
                    lock (lck2)
                    {
                        Console.WriteLine("Running...");
                    }
                }
            }
        }

    }

    public class DeadLocker2
    {
        private object lck1 = new object();
        private object lck2 = new object();

        public void ToDead1()
        {
            while (true)
            {
                lock (lck1)
                {
                    lock (lck2)
                    {
                        Console.WriteLine("Running");
                    }
                }
            }
        }
        public void ToDead2()
        {
            while (true)
            {
                lock (lck2)
                {
                    lock (lck1)
                    {
                        Console.WriteLine("Running");
                    }
                }
            }
        }
    }
}
