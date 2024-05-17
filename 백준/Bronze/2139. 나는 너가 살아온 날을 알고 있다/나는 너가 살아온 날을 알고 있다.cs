using System.Runtime.Intrinsics.X86;

namespace _2139
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0] == "0")
                {
                    return;
                }

                int day = int.Parse(inputs[0]);
                int month = int.Parse(inputs[1]);
                int year = int.Parse(inputs[2]);

                int totalDay = CalculateTotalDay(day, month, year);

                Console.WriteLine(totalDay);
            }
        }

        static int CalculateTotalDay(int day, int month, int year)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
            {
                daysInMonth[1] = 29;
            }

            int dayOfYear = 0;

            for (int i = 0; i < month - 1; i++)
            {
                dayOfYear += daysInMonth[i];
            }

            dayOfYear += day;

            return dayOfYear;
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }
    }
}