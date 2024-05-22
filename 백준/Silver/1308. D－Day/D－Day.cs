namespace _1308
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int todayYear = int.Parse(inputs[0]);
            int todayMonth = int.Parse(inputs[1]);
            int todayDay = int.Parse(inputs[2]);
            inputs = Console.ReadLine().Split(' ');
            int dDayYear = int.Parse(inputs[0]);
            int dDayMonth = int.Parse(inputs[1]);
            int dDayDay = int.Parse(inputs[2]);

            if (dDayYear > todayYear + 1000 || (dDayYear == todayYear + 1000 && dDayMonth >= todayMonth && dDayDay >= todayDay))
            {
                Console.WriteLine("gg");
                return;
            }
            int today = ToDayNumber(todayYear, todayMonth, todayDay);
            int dDay = ToDayNumber(dDayYear, dDayMonth, dDayDay);
            Console.WriteLine($"D-{dDay - today}");
        }
        static int ToDayNumber(int year, int month, int day)
        {
            int number = 0;
            for (int i = 1; i < year; i++)
            {
                number += IsLeapYear(i) ? 366 : 365;
            }

            int[] dayInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            
            if (IsLeapYear(year))
            {
                dayInMonth[1] = 29;
            }

            for (int i = 1; i < month; i++)
            {
                number += dayInMonth[i - 1];
            }

            number += day;
            return number;
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}