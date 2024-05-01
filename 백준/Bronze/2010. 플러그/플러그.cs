namespace _2010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int input = int.Parse(Console.ReadLine());
                cnt += input - 1;
            }

            Console.WriteLine(cnt + 1);
        }
    }
}