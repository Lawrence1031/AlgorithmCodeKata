namespace _25044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            List<TimeSpan> shutoffTimes = new List<TimeSpan>();

            TimeSpan[] dailyShutoffs = { new TimeSpan(15, 0, 0), new TimeSpan(18, 0, 0), new TimeSpan(21, 0, 0) };

            TimeSpan additionalTime = TimeSpan.Zero;
            int totalShutoffs = 0;

            for (int day = 0; day <= N; day++)
            {
                for (int i = 0; i < 3; i++)
                {
                    TimeSpan currentTime = dailyShutoffs[i] + new TimeSpan(day * 24, 0, 0) + additionalTime;
                    shutoffTimes.Add(currentTime);
                    totalShutoffs++;

                    if (totalShutoffs % 3 == 0)
                    {
                        additionalTime += new TimeSpan(0, K, 0);
                    }
                }
            }

            List<string> resultTimes = new List<string>();
            foreach (var time in shutoffTimes)
            {
                int dayNumber = (int)time.TotalDays;
                if (dayNumber == N)
                {
                    int hours = (int)time.TotalHours % 24;
                    int minutes = time.Minutes;
                    resultTimes.Add($"{hours:D2}:{minutes:D2}");
                }
            }

            Console.WriteLine(resultTimes.Count);
            foreach (var time in resultTimes)
            {
                Console.WriteLine(time);
            }
        }
    }
}