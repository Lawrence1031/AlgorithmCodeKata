namespace _12841
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] cross = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] left = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] right = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] leftSum = new long[n];
            long[] rightSum = new long[n];

            for (int i = 1; i < n; i++)
            {
                leftSum[i] = leftSum[i - 1] + left[i - 1];
            }

            rightSum[0] = right.Sum();
            for (int i = 1; i < n; i++)
            {
                rightSum[i] = rightSum[i - 1] - right[i - 1];
            }

            long minDistance = long.MaxValue;
            int crossIdx = -1;

            for (int i = 0; i < n; i++)
            {
                long totalDistance = leftSum[i] + cross[i] + rightSum[i];
                if (totalDistance < minDistance)
                {
                    minDistance = totalDistance;
                    crossIdx = i + 1;
                }
            }

            Console.WriteLine($"{crossIdx} {minDistance}");
        }
    }
}