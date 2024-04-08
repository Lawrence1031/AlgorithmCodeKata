namespace _1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            Console.WriteLine(FindPosition(N, r, c));
        }

        static int FindPosition(int N, int r, int c)
        {
            if (N == 0)
            {
                return 0;
            }
            int half = 1 << (N - 1);
            if (r < half && c < half)
            {
                return FindPosition(N - 1, r, c);
            }
            else if (r < half && c >= half)
            {
                return half * half + FindPosition(N - 1, r, c - half);
            }
            else if (r >= half && c < half)
            {
                return 2 * half * half + FindPosition(N - 1, r - half, c);
            }
            else
            {
                return 3 * half * half + FindPosition(N - 1, r - half, c - half);
            }
        }
    }
}