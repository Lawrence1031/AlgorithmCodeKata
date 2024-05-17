using System.Text;

namespace _1790
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            long N = long.Parse(inputs[0]);
            long k = long.Parse(inputs[1]);

            long length = 1;
            long cnt = 9;
            long start = 1;

            while (k > length * cnt)
            {
                k -= length * cnt;
                length++;
                cnt *= 10;
                start *= 10;

                if (start > N)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            start += (k - 1) / length;

            if (start > N)
            {
                Console.WriteLine(-1);
                return;
            }

            string result = start.ToString();
            Console.WriteLine(result[(int)((k - 1) % length)]);
        }
    }
}