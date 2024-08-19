namespace _16504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long answer = 0;

            for (int i = 0; i < N; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                answer += numbers.Sum();
            }

            Console.WriteLine(answer);
        }
    }
}