using SnowLeopard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
            StructCompare();
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
