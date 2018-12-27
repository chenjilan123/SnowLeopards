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
        public static void Run()
        {

            ThreadState state = ThreadState.Aborted;
            switch (state)
            {
                case ThreadState.Running:
                    break;
                case ThreadState.StopRequested:
                    break;
                case ThreadState.SuspendRequested:
                    break;
                case ThreadState.Background:
                    break;
                case ThreadState.Unstarted:
                    break;
                case ThreadState.Stopped:
                    break;
                case ThreadState.WaitSleepJoin:
                    break;
                case ThreadState.Suspended:
                    break;
                case ThreadState.AbortRequested:
                    break;
                case ThreadState.Aborted:
                    break;
                default:
                    break;
            }
        }
    }
}
