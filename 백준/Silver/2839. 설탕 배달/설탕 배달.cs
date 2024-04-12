namespace _2839
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            while (N >= 0)
            {
                if (N % 5 == 0)
                {
                    cnt += N / 5;
                    Console.WriteLine(cnt);
                    return;
                }
                N -= 3;
                cnt++;
            }

            if (N < 0)
            {
                Console.WriteLine(-1);
            }
        }
    }
}