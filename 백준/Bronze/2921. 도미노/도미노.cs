namespace _2921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 0;

            for (int i = 0; i <= N; i++)
            {
                for (int j = i; j <= N; j++)
                {
                    answer += i + j;
                }
            }

            Console.WriteLine(answer);
        }
    }
}