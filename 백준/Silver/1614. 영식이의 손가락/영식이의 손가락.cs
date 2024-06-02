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
                if (cnt == 0)
                {
                    result = 0;
                }
                else
                {
                    result = cnt * 8;
                }
            }
            else if (finger == 5)
            {
                result = cnt * 8 + 4;
            }
            else
            {
                if (cnt % 2 == 1)
                {
                    result = cnt * 4 + (5 - finger);
                }
                else
                {
                    result = cnt * 4 + (finger - 1);
                }
            }

            Console.WriteLine(result);
        }
    }
}