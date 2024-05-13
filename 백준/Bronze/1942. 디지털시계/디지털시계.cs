namespace _1942
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] times = Console.ReadLine().Split(' ');
                string start = times[0];
                string end = times[1];
                Console.WriteLine(CntMultiplesOfThree(start, end));
            }
        }
        static int CntMultiplesOfThree(string startTime, string endTime)
        {
            DateTime start = ConvertToDateTime(startTime);
            DateTime end = ConvertToDateTime(endTime);

            int cnt = 0;

            if (start > end)
            {
                cnt += CntInRange(start, new DateTime(start.Year, start.Month, start.Day, 23, 59, 59));
                cnt += CntInRange(new DateTime(end.Year, end.Month, end.Day, 0, 0, 0), end);
            }
            else
            {
                cnt += CntInRange(start, end);
            }

            return cnt;
        }
        static int CntInRange(DateTime start, DateTime end)
        {
            int cnt = 0;
            for (DateTime cur = start; cur <= end; cur = cur.AddSeconds(1))
            {
                int number = ConvertToInt(cur);
                if (number % 3 == 0) cnt++;
            }

            return cnt;
        }
        static DateTime ConvertToDateTime(string time)
        {
            string[] parts = time.Split(':');
            int hours = int.Parse(parts[0]);
            int minutes = int.Parse(parts[1]);
            int seconds = int.Parse(parts[2]);
            return new DateTime(2000, 1, 1, hours, minutes, seconds);
        }
        static int ConvertToInt(DateTime time)
        {
            return time.Hour * 10000 + time.Minute * 100 + time.Second;
        }
    }
}