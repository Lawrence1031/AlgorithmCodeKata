namespace _5607
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] scoreA = new int[N];
            int[] scoreB = new int[N];
            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                scoreA[i] = int.Parse(inputs[0]);
                scoreB[i] = int.Parse(inputs[1]);

                if (scoreA[i] > scoreB[i])
                {
                    sumA += scoreA[i] + scoreB[i];
                }
                else if (scoreA[i] == scoreB[i])
                {
                    sumA += scoreA[i];
                    sumB += scoreB[i];
                }
                else
                {
                    sumB += scoreA[i] + scoreB[i];
                }
            }

            Console.WriteLine($"{sumA} {sumB}");
        }
    }
}