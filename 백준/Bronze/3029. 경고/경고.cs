using System.Collections.Generic;

namespace _3029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nowTime = Console.ReadLine();
            string throwTime = Console.ReadLine();
            int now = TimeToSecond(nowTime);
            int goal = TimeToSecond(throwTime);

            int left = goal - now;
            if (left <= 0)
            {
                left += 86400;
            }
            int hour = left / 3600;
            int minute = (left % 3600) / 60;
            int second = left % 60;

            Console.WriteLine($"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}");
        }
        static int TimeToSecond(string time)
        {
            int result = ((time[0] - '0') * 10 + (time[1] - '0')) * 3600 +
                         ((time[3] - '0') * 10 + (time[4] - '0')) * 60 +
                         ((time[6] - '0') * 10 + (time[7] - '0'));
            return result;
        }
    }
}