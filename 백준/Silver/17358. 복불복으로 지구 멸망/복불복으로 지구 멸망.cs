namespace _17358
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int mod = 1000000007;

            long answer = 1;
            for (int i = N; i > 1; i -= 2)
            {
                answer = (answer * (i - 1)) % mod;
            }

            Console.WriteLine(answer);
        }
    }
}