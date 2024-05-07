namespace _1408
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nowTime = Console.ReadLine();
            string startTime = Console.ReadLine();
            int now = ((nowTime[0] - '0') * 10 + (nowTime[1] - '0')) * 3600 +
                      ((nowTime[3] - '0') * 10 + (nowTime[4] - '0')) * 60 + 
                      ((nowTime[6] - '0') * 10 + (nowTime[7] - '0'));
            int start = ((startTime[0] - '0') * 10 + (startTime[1] - '0')) * 3600 +
                        ((startTime[3] - '0') * 10 + (startTime[4] - '0')) * 60 +
                        ((startTime[6] - '0') * 10 + (startTime[7] - '0'));

            int limit = start - now;
            if (limit < 0)
            {
                limit += 86400;
            }

            int hour = limit / 3600;
            int minute = (limit % 3600) / 60;
            int second = limit % 60;

            Console.WriteLine($"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}");
        }
    }
}