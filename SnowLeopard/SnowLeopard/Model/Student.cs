using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Model
{
    public class Student
    {
        public string Name { get; set; }
        public string No { get; set; }

        public Student(string name, string no)
        {
            this.Name = name;
            this.No = no;
        }
    }
}
