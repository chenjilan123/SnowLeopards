using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class InfinityProperty
    {
        private int number1 = 0;
        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                Number2 = value;
                number1 = value;
            }
        }
        private int number2 = 0;

        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                Number1 = value;
                number2 = value;
            }
        }

    }
}
