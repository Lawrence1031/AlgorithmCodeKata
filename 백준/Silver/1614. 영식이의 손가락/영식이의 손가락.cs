namespace _1614
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finger = int.Parse(Console.ReadLine());
            long cnt = long.Parse(Console.ReadLine());
            long result = 0;

            if (finger == 1)
            {
                result = cnt == 0 ? 0 : cnt * 8;
            }
            else if (finger == 5)
            {
                result = cnt * 8 + 4;
            }
            else
            {
                result = cnt * 4 + (cnt % 2 == 1 ? 5 - finger : finger - 1);
            }

            Console.WriteLine(result);
        }
    }
}