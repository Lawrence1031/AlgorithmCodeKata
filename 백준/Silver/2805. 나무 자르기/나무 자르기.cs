namespace _2805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] trees = new int[N];

            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                trees[i] = int.Parse(inputs[i]);
            }

            long start = 0;
            long end = int.MaxValue;
            long result = 0;

            while (start <= end)
            {
                long mid = (start + end) / 2;

                long totalCut = 0;

                foreach (int tree in trees)
                {
                    if (tree > mid)
                    {
                        totalCut += tree - mid;
                    }
                }

                if (totalCut >= M)
                {
                    result = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }


            Console.WriteLine(result);
        }
    }
}