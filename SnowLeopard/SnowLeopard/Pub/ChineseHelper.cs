using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Pub
{
    public static class ChineseHelper
    {
        public static void ConsoleTest()
        {
            //Console.WriteLine(GetNumber(101015));
            PrintAllNumber(0, 92000);

            //PrintFullNumer();
        }

        private static void PrintAllNumber(int iStart, int iEnd)
        {
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.WriteLine(GetNumber(i));
            }
        }

        private static void PrintFullNumer()
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    var sNumber = GetChineseNumber(i, j);
                    if (sNumber.IndexOf("一十") == 0)
                    {
                        sNumber = sNumber.TrimStart('一');
                    }
                    Console.WriteLine(sNumber);
                }
            }
        }

        public static string GetNumber(int iNum)
        {
            var sb = new StringBuilder();
            var iMaxPower = iNum.ToString().Length - 1;
            var bIsPreZero = false;
            for (int i = iMaxPower; i >= 0; i--)
            {
                var iCurrent = (int)Math.Pow(10, i);
                var iUnit = iNum / iCurrent;
                if (iUnit == 0)
                {
                    if (!bIsPreZero)
                    {
                        bIsPreZero = true;
                        sb.Append("零");
                    }
                }
                else
                {
                    bIsPreZero = false;
                    sb.Append(GetChineseNumber(iUnit, i));
                }
                iNum %= iCurrent;
            }
            var sNumber = sb.ToString().TrimEnd('零');
            if (sNumber.IndexOf("一十") == 0)
            {
                sNumber = sNumber.TrimStart('一');
            }
            return sNumber;
        }
        private static string[] arrChineseNumber = new string[] { "", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
        private static string[] arrChineseUnit = new string[] { "", "十", "百", "千", "万", "十万", "百万", "千万" };
        private static string GetChineseNumber(int iUnit, int iPower)
        {
            if (iUnit == 0) return string.Empty;
            return arrChineseNumber[iUnit] + arrChineseUnit[iPower];
        }
    }
}
