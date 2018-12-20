using SnowLeopard.Model;
using SnowLeopard.Model.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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
            ClassMemory();
        }


        #region Memory
        private static void ClassMemory()
        {
            //RedundancyMemory(1000000); //475MB-500MB
            //RedundancyMemory(2000000); //948MB 1:5
            //LightWeightMemory(1000000); //40MB
            //LightWeightMemory(2000000); //73MB 1:0.4
            //LightWeightNodeMemory(1000000);//97MB
            //LightWeightNodeMemory(2000000); //193MB   1:1

            //MemoryTest<Redundancy>(1000000);//480MB
            //MemoryTest<Redundancy>(2000000);//955MB
            //MemoryTest<Vehicle>(1000000);   //814MB
            //MemoryTest<Vehicle>(2000000);   //1614MB
            //MemoryTest<Vehicle>(30000);     //28.192MB
            //MemoryTest<Vehicle>(20000);     //20.984MB
            //MemoryTest<Vehicle>(10000);       //13.364MB    ==>1：8
            //MemoryTest<TreeNode>(1000000);  //96.176MB
            //MemoryTest<TreeNode>(2000000);  //200.072MB
            //MemoryTest<TreeNode>(10000);  //6.396MB ==>1:1
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
    }
}
