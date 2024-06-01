namespace _1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long X = long.Parse(inputs[0]);
            long Y = long.Parse(inputs[1]);

            long Z = 100 * Y / X;

            if (Z >= 99)
            {
                Console.WriteLine(-1);
                return;
            }

            long left = 1;
            long right = 1000000000;
            long result = -1;

            while (left <= right)
            {
                long mid = (right + left) / 2;
                long newCnt = X + mid;
                long newWin = Y + mid;
                long newRate = 100 * newWin / newCnt;

                if (newRate > Z)
                {
                    result = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}