namespace _2399
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int[] xPoints = new int[n];

            for (int i = 0; i < n; i++)
            {
                xPoints[i] = int.Parse(inputs[i]);
            }

            Array.Sort(xPoints);
            long sum = 0;

            for (int i = 0; i < xPoints.Length; i++)
            {
                for (int j = i + 1; j < xPoints.Length; j++)
                {
                    sum += 2 * (xPoints[j] - xPoints[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}