namespace _2164
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int answer = FindCard(N);
            Console.WriteLine(answer);
        }

        static int FindCard(int n)
        {
            int k = 1;
            while (k * 2 <= n)
            {
                k *= 2;
            }
            return n == k ? n : 2 * (n - k);
        }
    }
}