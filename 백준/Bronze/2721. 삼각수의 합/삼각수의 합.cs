namespace _2721
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // T(n) = n * (n + 1) / 2
            // T(4) = 1 + 2 + 3 + 4
            // W(n) = Sum[k = 1..n; k * T(k+1)]

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine(sumTri(N));
            }
        }

        static int triangleNumber(int n)
        {
            return n * (n + 1) / 2;
        }
        static int sumTri(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result += i * triangleNumber(i + 1);
            }
            return result;
        }
    }
}