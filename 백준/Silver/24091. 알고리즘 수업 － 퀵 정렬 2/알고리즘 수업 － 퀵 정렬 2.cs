namespace _24091
{
    internal class Program
    {
        static int cnt = 0;
        static int K = 0;
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            K = int.Parse(inputs[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            QuickSortAlgorithm(arr, 0, N - 1);

            if (cnt < K)
            {
                Console.WriteLine(-1);
            }

        }

        static void QuickSortAlgorithm(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(arr, p, r);
                QuickSortAlgorithm(arr, p, q - 1);
                QuickSortAlgorithm(arr, q + 1, r);
            }
        }

        static int Partition(int[] arr, int p, int r)
        {
            int x = arr[r];
            int i = p - 1;

            for (int j = p; j < r; j++)
            {
                if (arr[j] <= x)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            if (i + 1 != r)
            {
                Swap(arr, i + 1, r);
            }

            return i + 1;
        }

        static void Swap(int[] arr, int i , int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;

            cnt++;
            if (cnt == K)
            {
                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}