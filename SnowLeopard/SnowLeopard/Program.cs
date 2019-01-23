using SnowLeopard.Model;
using SnowLeopard.Model.Memory;
using SnowLeopard.Pub;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SnowLeopard
{
    static class Program
    {
        static void Main()
        {
            ChineseNumber();
            //SqlXmlProcess();

            Console.ReadLine();
        }

        #region ChineseNumber
        private static void ChineseNumber()
        {
            ChineseHelper.ConsoleTest();
        }
        #endregion

        #region SqlXmlProcess
        private const string Transport =
@"<TransportInfo>
  <Transport>
    <TransportName>李某某</TransportName>
    <TransportTelephone>13550550560</TransportTelephone>
    <TransportLevel>1</TransportLevel>
  </Transport>
  <Transport>
    <TransportName>123</TransportName>
    <TransportLevel>2</TransportLevel>
  </Transport>
  <Transport>
    <TransportName>张三</TransportName>
    <TransportTelephone>15120200457</TransportTelephone>
    <TransportLevel>3</TransportLevel>
  </Transport>
</TransportInfo>";
        private static void SqlXmlProcess()
        {
            var xEle = XElement.Parse(Transport);
            foreach (var xTransport in xEle.Elements())
            {
                var xName = xTransport.Element("TransportName");
                var xTelephone = xTransport.Element("TransportTelephone");
                var xLevel = xTransport.Element("TransportLevel");

                var sTransportInfo = GetTransportInfo(xName, xTelephone, xLevel);
                Console.WriteLine(sTransportInfo.TrimEnd(new char[] { ';', ' ' }));
            }
            //Console.WriteLine(xEle);
        }

        private static string GetTransportInfo(XElement xName, XElement xTelephone, XElement xLevel)
        {
            var sName = string.Empty;
            var sTelephone = string.Empty;
            int iLevel = 0;

            if (xName != null)
            {
                sName = xName.Value;
            }
            if (xTelephone != null)
            {
                sTelephone = xTelephone.Value;
            }
            if (xLevel != null)
            {
                iLevel = int.Parse(xLevel.Value);
            }
            var sTransportLevel = ChineseHelper.GetNumber(iLevel);
            if (!string.IsNullOrEmpty(sTransportLevel))
            {
                sTransportLevel = "第" + sTransportLevel;
            }
            return $"{sTransportLevel}押运员：{sName}-{sTelephone}; ";
        }
        #endregion

        #region NameofObject
        private static void NameofObject()
        {
            var iValue = 0;
            Console.WriteLine(nameof(iValue));
            Console.WriteLine(nameof(Main));
            Console.WriteLine(nameof(Program));
            Console.WriteLine(nameof(SnowLeopard));

            var generic1 = new GenericClass<int>();
            var generic2 = new GenericClass<Student>();
            generic1.PrintName();
            generic2.PrintName();
        }

        public class GenericClass<T>
        {
            public void PrintName()
            {
                Console.WriteLine(nameof(T));
            }
        }
        #endregion

        #region MathAlgorithm
        private static void MathAlgorithm()
        {
            //Console.WriteLine(Math.Pow(50.0, 3));

            var sLon = "123.501057";
            var sLat = "27.475012";
            var lonBase = 123.501058D;
            var latBase = 27.475055D;

            var i = 50000000;

            var sw = Stopwatch.StartNew();
            while (i-- > 0)
            {
                if (double.TryParse(sLon, out double lon) && double.TryParse(sLat, out double lat))
                {
                    var dis = Math.Sqrt((Math.Pow(lonBase - lon, 2) + Math.Pow(latBase - lat, 2)));
                    //Console.WriteLine(dis.ToString("0.000000"));
                }
            }
            sw.Stop();
            Console.WriteLine($"Total times: {sw.Elapsed.TotalSeconds}s");
        }
        #endregion

        #region DifferentBetweenClassAndStruct
        private static void DifferentBetweenClassAndStruct()
        {
            BookReceived += b =>
            {
                Console.WriteLine($"1.Receive book: {b.Value}");
                b.Value = 5;
            };
            BookReceived += b => Console.WriteLine($"2.Receive book: {b.Value}");
            BookReceived += b => Console.WriteLine($"3.Receive book: {b.Value}");

            AppleReceived += a =>
            {
                Console.WriteLine($"1.Receive apple: {a.Value}");
                a.Value = 5;
            };
            AppleReceived += a => Console.WriteLine($"2.Receive apple: {a.Value}");
            AppleReceived += a => Console.WriteLine($"3.Receive apple: {a.Value}");

            var book = new Book() { Value = 1 };
            var apple = new Apple() { Value = 1 };
            OnBookReceived(book);
            OnAppleReceived(apple);
        }
        private static event Action<Book> BookReceived;
        private static event Action<Apple> AppleReceived;

        private static void OnBookReceived(Book book)
        {
            BookReceived?.Invoke(book);
        }
        private static void OnAppleReceived(Apple apple)
        {
            AppleReceived?.Invoke(apple);
        }

        private class Book
        {
            public int Value { get; set; }
        }

        private struct Apple
        {
            public int Value { get; set; }
        }
        #endregion

        #region BoolOpOrder
        private static void BoolOpOrder()
        {
            Console.WriteLine(false && false || true);
            Console.WriteLine(true || false && false);
        }
        #endregion

        #region UintParse
        private static void UintParse()
        {
            string s = "50";
            if (uint.TryParse(s, System.Globalization.NumberStyles.HexNumber, null, out uint value))
            //if (uint.TryParse(s, out uint value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        #endregion

        #region XmlDocumentBuild
        private static void XmlDocumentBuild()
        {
            //Not format
            var xmlDoc = new XElement("PathParam");
            xmlDoc.Add();
            xmlDoc.Add(new XElement("Segment", "50"));
            Console.WriteLine(xmlDoc);

            //format
            var doc = new XDocument();
            doc.Add(xmlDoc);

            Console.WriteLine(doc.ToString());
        }
        #endregion

        #region NumberFormation
        private static void NumberFormation()
        {
            var f = 500F;
            Console.WriteLine(f.ToString("0.00秒"));

            var s = "5秒";
            //var chars = "秒".ToCharArray();
            //foreach (var c in chars)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine(s.TrimEnd(chars));
            Console.WriteLine(s.TrimEnd('秒'));

        }
        #endregion

        #region AutoReset
        private static void AutoReset()
        {
            //var auto1 = new AutoResetEvent(false);
            //var auto2 = new AutoResetEvent(true);
            //PrintAutoReset(auto1);
            //PrintAutoReset(auto2);
            //void PrintAutoReset(AutoResetEvent auto)
            //{
            //    Console.WriteLine($"{auto..ToString()}");
            //}
            //WaitHandle.WaitAll()
            {
                //Wait first
                var auto = new AutoResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(false) notice send.");
                    auto.Set();
                }));
                auto.WaitOne();
                Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(false) signal received.\r\n");
            }
            {
                //Set first
                var auto = new AutoResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
                {
                    Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(false) notice send.");
                    auto.Set();
                }));
                Thread.Sleep(3000);
                auto.WaitOne();
                Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(false) signal received.\r\n");
            }
            {
                //特例=================================================================================================
                //Wait first
                var auto = new AutoResetEvent(true);
                ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
                {
                    Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(true) notice send.");
                    Thread.Sleep(3000);
                    auto.Set();
                }));
                auto.WaitOne();
                Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(true) signal received.");
                auto.WaitOne();
                Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(true) signal received.\r\n");
            }
            {
                //Set first
                var auto = new AutoResetEvent(true);
                ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
                {
                    Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(true) notice send.");
                    auto.Set();
                }));
                Thread.Sleep(3000);
                auto.WaitOne();
                Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]AutoResetEvent(true) signal received.\r\n");
            }
        }
        #endregion

        #region FrontAndBackThreadExecuteCompare
        private static void FrontAndBackThreadExecuteCompare()
        {
            //Sync
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < 3; i++)
            {
                LongTimeRequest();
            }
            sw.Stop();
            Console.WriteLine($"Long time sync handler success. used {sw.Elapsed.TotalSeconds.ToString("0.00")}s");

            //Async
            //Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(一些长期任务));
            sw.Restart();
            var autoReset1 = new AutoResetEvent(false);
            var autoReset2 = new AutoResetEvent(false);
            var autoReset3 = new AutoResetEvent(false);
            ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
            {
                LongTimeRequest();
                autoReset1.Set();
            }));
            ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
            {
                LongTimeRequest();
                autoReset2.Set();
            }));
            ThreadPool.QueueUserWorkItem(new WaitCallback(o =>
            {
                LongTimeRequest();
                Thread.Sleep(5000);
                autoReset3.Set();
            }));
            autoReset1.WaitOne();
            autoReset2.WaitOne();
            autoReset3.WaitOne();
            sw.Stop();
            Console.WriteLine($"Long time async handler success. used {sw.Elapsed.TotalSeconds.ToString("0.00")}s");
        }

        private static void LongTimeRequest()
        {
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] [{Thread.CurrentThread.ManagedThreadId}] Complex http request started. IsThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");

            object _lock = new object();
            int k = 0;
            //100 000 000 = 1.98~2.32s
            for (int i = 0; i < 200_000_000; i++)
            {
                lock (_lock)
                {
                    k++;
                }
            }
            //Thread.Sleep(seconds);
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] [{Thread.CurrentThread.ManagedThreadId}] Complex http request ended. Result: {k}");
        }
        private static void ShortTimeRequest()
        {
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Lightweight http request started.");
            Thread.Sleep(3000);
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Lightweight http request ended.");
        }

        private static void InvokeThread(Action action, AutoResetEvent autoReset)
        {
            new Thread(new ThreadStart(() =>
            {
                action.Invoke();
                autoReset.Set();
            }))
            {
                IsBackground = true
            }.Start();
        }
        #endregion

        #region LINQOrderByMultiProp
        /// <summary>
        /// LINQOrderByMultiProp
        /// </summary>
        private static void LINQOrderByMultiProp()
        {
            List<HerOrder> lst = new List<HerOrder>
            {
                new HerOrder(1, 1),
                new HerOrder(7, 4),
                new HerOrder(7, 2),
                new HerOrder(8, 1),
                new HerOrder(3, 1),
                new HerOrder(7, 3),
                new HerOrder(3, 3),
                new HerOrder(3, 5),
                new HerOrder(4, 1),
                new HerOrder(5, 1),
                new HerOrder(2, 1),
                new HerOrder(3, 4),
                new HerOrder(6, 1),
                new HerOrder(9, 1),
                new HerOrder(7, 1),
            };

            //var queryOrder = from i in lst
            //                 orderby i.Id1, i.Id2
            //                 select i;

            var queryOrder = lst.OrderBy(i => i.Id1).ThenBy(i => i.Id2);

            foreach (var herorder in queryOrder)
            {
                Console.WriteLine($"Id1: {herorder.Id1}, Id2: {herorder.Id2}");
            }
        }
        #endregion

        #region Memory
        private static void ClassMemory()
        {
            //RedundancyMemory(1000000); //475MB-500MB
            //RedundancyMemory(2000000); //948MB 1:5
            //LightWeightMemory(1000000); //40MB
            //LightWeightMemory(2000000); //73MB 1:0.4
            //LightWeightNodeMemory(1000000);//97MB
            //LightWeightNodeMemory(2000000); //193MB   1:1

            MemoryTest<Redundancy>(1000000);//480MB
            MemoryTest<Redundancy>(2000000);//955MB
            MemoryTest<Vehicle>(1000000);   //814MB
            MemoryTest<Vehicle>(2000000);   //1614MB
            MemoryTest<Vehicle>(30000);     //28.192MB
            MemoryTest<Vehicle>(20000);     //20.984MB
            MemoryTest<Vehicle>(10000);       //13.364MB    ==>1：8
            MemoryTest<TreeNode>(1000000);  //96.176MB
            MemoryTest<TreeNode>(2000000);  //200.072MB
            MemoryTest<TreeNode>(10000);  //6.396MB ==>1:1
        }
        private static void MemoryTest<T>(int count)
        {
            var monitor = new MemoryMonitor<T>();
            monitor.Test(count);
        }
        private static void RedundancyMemory(int count)
        {
            List<Redundancy> _lst = new List<Redundancy>();
            for (int i = 0; i < count; i++)
            {
                _lst.Add(new Redundancy());
            }
            Console.ReadLine();
        }
        private static void LightWeightMemory(int count)
        {
            List<LightWeight> _lst = new List<LightWeight>();
            for (int i = 0; i < count; i++)
            {
                _lst.Add(new LightWeight());
            }
            Console.ReadLine();
        }
        private static void LightWeightNodeMemory(int count)
        {
            List<LightWeightNode> _lst = new List<LightWeightNode>();
            for (int i = 0; i < count; i++)
            {
                _lst.Add(new LightWeightNode());
            }
            Console.ReadLine();
        }
        //[DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        //public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        //public static void ClearMemory()
        //{
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();
        //    if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        //    {
        //        App.SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        //    }
        //}
        #endregion

        #region Others
        private static Triangle t;
        private static void CustomStructDefaultValue()
        {
            Console.WriteLine(t.Length);
            Console.WriteLine(t.Width);
        }

        private static void StructCompare()
        {
            var t1 = new Triangle() { Length = 1, Width = 2 };
            var t2 = new Triangle() { Length = 1, Width = 2 };

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
        }

        private static void SplitString()
        {
            var s = "1_1, 1_1_2, 1_2, 1_2_2, 1_4, 1_4_2, 1_8, 1_8_2, 1_16, 1_16_2, 1_32, 1_32_2, 2_2147483648, 2_2147483648_2, 2_4294967296, 2_4294967296_2, 2_8589934592, 2_8589934592_2, 2_17179869184, 2_17179869184_2, 2_34359738368, 2_34359738368_2, 2_68719476736, 2_68719476736_2";
            var arr = s.Split(',');

            foreach (var item in arr)
            {
                var arrAlarmFlag = item.Split('_');
                Console.WriteLine(arrAlarmFlag[0]);
                Console.WriteLine(arrAlarmFlag[1]);
                if (arrAlarmFlag.Length == 2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(arrAlarmFlag[2]);
                }
            }
        }
        private static void StringStartWithNumber()
        {
            while (true)
            {
                Console.WriteLine("Please input a string: ");
                var sInput = Console.ReadLine();
                if (Regex.IsMatch(sInput, @"^[\d][_]"))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        private static void Output()
        {
            List<Student> lst = new List<Student>()
            {
                new Student("Mike", "13500"),
                new Student("Jack", "13501"),
                new Student("Mark", "13503"),
            };
            var xEle = new XElement("StudentInfo");

            foreach (var student in lst)
            {
                //var xStu = new XElement("Student");
                //xStu.Add(new XElement("Name", student.Name));
                //xStu.Add(new XElement("No", student.No));

                //层次
                var xStu = new XElement("Student"
                            , new XElement("Name", student.Name)
                            , new XElement("No", student.No));
                xEle.Add(xStu);
            }

            var child = xEle.Element("Student");
            if (child == null)
            {
                Console.WriteLine("Student isn't exists in xEle.");
            }
            else
            {
                child.SetValue("12321321321");
                Console.WriteLine(child);
            }
            Console.WriteLine(xEle.ToString(SaveOptions.DisableFormatting));
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
        #endregion
    }
}
