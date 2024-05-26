namespace _1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] sixStrings = new int[M];
            int[] oneStrings = new int[M];
            
            for (int i = 0; i < M; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                sixStrings[i] = int.Parse(inputs[0]);
                oneStrings[i] = int.Parse(inputs[1]);
            }

            int minSixPrice = sixStrings.Min();
            int minOnePrice = oneStrings.Min();

            int totalSixPrice = ((N / 6) + 1) * minSixPrice;
            int mixedPrice = (N / 6) * sixStrings.Min() + (N % 6) * oneStrings.Min();
            int totalOnePrice = N * minOnePrice;

            int answer = Math.Min(totalSixPrice, Math.Min(mixedPrice, totalOnePrice));

            Console.WriteLine(answer);
        }
    }
}