using System.Text;

namespace _1340
{
    internal class Program
    {
        public enum MonthName
        {
            January = 1, February, March, 
            April, May, June, July, August, 
            September, October, November, December
        }
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string month = inputs[0];
            int day = int.Parse(inputs[1].Substring(0, 2));
            int year = int.Parse(inputs[2]);
            string time = inputs[3];

            int totalDays = ToDayNumber(year, month, day);
            int fullSeconds = IsLeapYear(year) ? 527040 : 525600;
            double totalSeconds = HourToSecond(time) + 1440 * (totalDays - 1);
            double answer = (totalSeconds / fullSeconds * 100);
            Console.WriteLine(answer);
            
        }

        static int ToDayNumber(int year, string month, int day)
        {
            int number = 0;
            MonthName monthEnum;
            Enum.TryParse(month, out monthEnum);
            int monthNumber = (int)monthEnum;

            int[] dayInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
            {
                dayInMonth[1] = 29;
            }

            for (int i = 1; i < monthNumber; i++)
            {
                number += dayInMonth[i - 1];
            }

            number += day;
            return number;
        }

        static int HourToSecond(string time)
        {
            int hour = int.Parse(time.Split(':')[0]);
            int second = int.Parse(time.Split(':')[1]);

            return hour * 60 + second;
        }

        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return year % 4 == 0;
        }
    }
}