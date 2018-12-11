using SnowLeopard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private static void Output()
        {
            OverrideOrderDemo();
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
