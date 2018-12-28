//#define IsRaceUse

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class ThreadRaceCondition
    {
        public static void Run()
        {
            var car = new Car();

            var t1 = new Task(() => Loop(car));
            var t2 = new Task(() => Loop(car));
            t1.Start();
            t2.Start();
            Task.WhenAll(t1, t2);
        }

        public static void Loop(Car car)
        {
            while (true)
            {
#if IsRaceUse
                car.AddOil();
#else
                car.AddOilSafely();
#endif
            }
        }

    }

    public class Car
    {
        private object _safeLck = new object();
        public int OilWeight { get; set; }
        public void AddOil()
        {
            try
            {
                if (OilWeight == 0)
                {
                    OilWeight += 50;
                    Trace.Assert(OilWeight == 50, "Oil weight wrong.");
                }
                OilWeight = 0;
            }
            catch (Exception ex)
            {
                //断言不是异常，捕捉不到
                Console.WriteLine(ex.ToString());
            }
        }
        public void AddOilSafely()
        {
            try
            {
                //此时，该方法为线程安全的方法。
                //若对象内的全部操作均线程安全，则对象称为线程安全的对象。
                lock (_safeLck)
                {
                    //全部关于OilWeight的运算都得包进来
                    if (OilWeight == 0)
                    {
                        OilWeight += 50;
                        Trace.Assert(OilWeight == 50, "Oil weight wrong.");
                    }
                    OilWeight = 0;
                }
            }
            catch (Exception ex)
            {
                //断言不是异常，捕捉不到
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
