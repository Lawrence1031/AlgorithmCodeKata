namespace _10162
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            // A - 5분(300초), B - 1분(60초), C - 10초

            int cnt = 0;

            int ACnt = T / 300;
            int BCnt = (T % 300) / 60;
            int CCnt = ((T % 300) % 60) / 10;

            if (T % 10 != 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine($"{ACnt} {BCnt} {CCnt}");
            }
        }
    }
}