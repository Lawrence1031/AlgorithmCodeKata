namespace _1075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            int m = n / 100 * 100;

            for (int i = 0; i < 100; i++)
            {
                if ((m + i) % f == 0)
                {
                    Console.WriteLine(i.ToString("D2"));
                    break;
                }
            }
        }
    }
}