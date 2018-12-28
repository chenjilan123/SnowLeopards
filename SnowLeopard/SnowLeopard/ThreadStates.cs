using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class ThreadStates
    {
        static bool isstop = false;
        static object objLock = new object();
        static int j = 0;
        public static async void Run()
        {
            //case ThreadPriority.Lowest:
            //    break;
            //case ThreadPriority.BelowNormal:
            //    break;
            //case ThreadPriority.Normal:
            //    break;
            //case ThreadPriority.AboveNormal:
            //    break;
            //case ThreadPriority.Highest:
            //优先级高的已启动线程会分配更多的CPU资源。
            //晚创建的Lowest优先级的线程会比早创建的更早完成。
            //Hightest享有远远多于Lowest的资源。

            //以下测试时，线程有三种状态
            //unstarted, running, stopped
            var priority = 0;
            var threads = new Thread[20];
            for (int i = 0; i < threads.Length; i++)
            {
                //120个线程，同时Running？操作系统调度器允许同时运行120个线程？
                threads[i] = new Thread(CalThread); //{ IsBackground = true };
                threads[i].Priority = (ThreadPriority)priority;
                threads[i].Name = $"Thread{i}[{(ThreadPriority)priority}]";
                priority++;
                if (priority > 4) priority = 0;
            }
            ThreadStateMonitor(threads);
            ThreadMonitorStopper();
            foreach (var thread in threads)
            {
                thread.Start();
                Console.WriteLine($"{thread.Name} has started");
            }

            //State enum
            //ThreadState state = ThreadState.Aborted;
            //switch (state)
            //{
            //    case ThreadState.Running:
            //        break;
            //    case ThreadState.StopRequested:
            //        break;
            //    case ThreadState.SuspendRequested:
            //        break;
            //    case ThreadState.Background:
            //        break;
            //    case ThreadState.Unstarted:
            //        break;
            //    case ThreadState.Stopped:
            //        break;
            //    case ThreadState.WaitSleepJoin:
            //        break;
            //    case ThreadState.Suspended:
            //        break;
            //    case ThreadState.AbortRequested:
            //        break;
            //    case ThreadState.Aborted:
            //        break;
            //    default:
            //        break;
            //}

        }

        private static async void ThreadMonitorStopper()
        {
            await Task.Run(() =>
            {
                while(true)
                {
                    var s1 = isstop ? "restart" : "stop";
                    var s2 = isstop ? "started" : "stopped";
                    Console.WriteLine($"Input 'Enter' to {s1} the console logger");
                    var input = Console.ReadLine();
                    isstop = !isstop;
                    Console.WriteLine($"Console logger has been {s2}");
                }
            });
        }

        private static async void ThreadStateMonitor(Thread[] threads)
        {
            await Task.Run(() =>
            {
                do
                {
                    if (isstop)
                    {
                        Thread.Sleep(2000);
                        continue;
                    }
                    foreach (var thread in threads)
                    {
                        //无法访问优先级？
                        //Console.WriteLine($"{thread.Name} state: {thread.ThreadState}, priority: {thread.Priority}");
                        Console.WriteLine($"{thread.Name} state: \t\t{thread.ThreadState}");
                    }
                    Console.WriteLine();
                    Thread.Sleep(2000);
                } while (true);
            });
        }

        private static void CalThread()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (objLock)
                {
                    j++;
                }
            }
        }
    }
}
