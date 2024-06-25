namespace _4436
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != null)
            {
                long n = long.Parse(input);
                HashSet<long> set = new HashSet<long>();

                long cnt = 0;
                while (set.Count < 10)
                {
                    cnt++;
                    long number = n * cnt;

                    while (number > 0)
                    {
                        set.Add(number % 10);
                        number /= 10;
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}