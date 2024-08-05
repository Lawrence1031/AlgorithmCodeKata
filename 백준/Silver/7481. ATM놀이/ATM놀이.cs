namespace _7481
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int S = int.Parse(inputs[2]);

                bool isFound = false;
                long minBills = long.MaxValue;
                long aCnt = 0;
                long bCnt = 0;

                int limit = (int)Math.Sqrt(S);
                for (int x = 0; x <= limit; x++)
                {
                    if (S >= a * x && (S - a * x) % b == 0)
                    {
                        long y = (S - a * x) / b;
                        long totalBills = x + y;
                        if (totalBills < minBills)
                        {
                            minBills = totalBills;
                            aCnt = x;
                            bCnt = y;
                            isFound = true;
                        }
                    }

                    if (S >= b * x && (S - b * x) % a == 0)
                    {
                        long y = (S - b * x) / a;
                        long totalBills = x + y;
                        if (totalBills < minBills)
                        {
                            minBills = totalBills;
                            aCnt = y;
                            bCnt = x;
                            isFound = true;
                        }
                    }
                }

                if (isFound)
                {
                    Console.WriteLine($"{aCnt} {bCnt}");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}