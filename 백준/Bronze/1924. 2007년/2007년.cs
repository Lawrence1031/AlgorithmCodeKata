using System;

namespace _1924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int month = int.Parse(inputs[0]);
            int day = int.Parse(inputs[1]);

            int now = MonthToDay(month) + day;

            string[] dayName = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};

            Console.WriteLine(dayName[now % 7]);
        }

        static int MonthToDay(int month)
        {
            int[] dayInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int day = 0;

            if (month == 1)
            {
                return 0;
            }

            for (int i = 0; i < month - 1; i++)
            {
                day += dayInMonth[i];
            }

            return day;
        }
    }
}