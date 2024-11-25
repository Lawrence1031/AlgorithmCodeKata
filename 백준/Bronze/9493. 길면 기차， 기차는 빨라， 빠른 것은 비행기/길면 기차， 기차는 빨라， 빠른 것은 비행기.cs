namespace _9493
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0] == "0" && inputs[1] == "0" && inputs[2] == "0")
                {
                    return;
                }

                int M = int.Parse(inputs[0]);
                int A = int.Parse(inputs[1]);
                int B = int.Parse(inputs[2]);

                double diff = (double)M * (B - A) / (A * B) * 3600;
                int hour = (int)diff / 3600;
                int minute = (int)(diff % 3600) / 60;
                int second = (int)Math.Round(diff % 60);

                if (second == 60)
                {
                    minute++;
                    second = 0;
                }

                if (minute == 60)
                {
                    hour++;
                    minute = 0;
                }

                Console.WriteLine($"{hour}:{minute:D2}:{second:D2}");
            }
        }
    }
}