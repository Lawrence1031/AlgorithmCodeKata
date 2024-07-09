namespace _27922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);
            int[][] lectures = new int[N][];

            for (int i = 0; i < N; i++)
            {
                lectures[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            long[] sumAB = new long[N];
            long[] sumBC = new long[N];
            long[] sumCA = new long[N];

            for (int i = 0; i < N; i++)
            {
                sumAB[i] = lectures[i][0] + lectures[i][1];
                sumBC[i] = lectures[i][1] + lectures[i][2];
                sumCA[i] = lectures[i][2] + lectures[i][0];
            }

            Array.Sort(sumAB, (x, y) => y.CompareTo(x));
            Array.Sort(sumBC, (x, y) => y.CompareTo(x));
            Array.Sort(sumCA, (x, y) => y.CompareTo(x));

            long maxAB = sumAB.Take(K).Sum();
            long maxBC = sumBC.Take(K).Sum();
            long maxCA = sumCA.Take(K).Sum();

            Console.WriteLine(Math.Max(maxAB, Math.Max(maxBC, maxCA)));
        }
    }
}