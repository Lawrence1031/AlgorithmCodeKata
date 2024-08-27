namespace _7770
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int cnt = 0;
            long total = 0;

            for (int i = 1; ; i++)
            {
                long now = 2 * i * i - 2 * i + 1;

                if (total + now > N)
                {
                    break;
                }

                total += now;
                cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}