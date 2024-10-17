namespace _13900
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long totalSum = numbers.Sum();
            long squareSum = 0;
            long answer = 0;

            for (int i = 0; i < N; i++)
            {
                squareSum += numbers[i] * numbers[i];
            }

            answer = (totalSum * totalSum - squareSum) / 2;

            Console.WriteLine(answer);
        }
    }
}