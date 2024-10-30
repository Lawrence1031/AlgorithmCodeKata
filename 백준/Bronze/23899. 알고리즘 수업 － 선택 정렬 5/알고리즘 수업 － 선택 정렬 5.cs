namespace _23899
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (IsEqual(A, B))
            {
                Console.WriteLine(1);
                return;
            }
            else
            {
                SelSort(A, B);
            }
        }

        static void SelSort(int[] A, int[] B)
        {
            for (int last = A.Length - 1; last > 0; last--)
            {
                int maxIdx = last;
                for (int j = 0; j < last; j++)
                {
                    if (A[j] > A[maxIdx])
                    {
                        maxIdx = j;
                    }
                }

                if (last != maxIdx)
                {
                    int tmp = A[maxIdx];
                    A[maxIdx] = A[last];
                    A[last] = tmp;
                }

                if (IsEqual(A, B))
                {
                    Console.WriteLine(1);
                    return;
                }
            }

            Console.WriteLine(0);
        }

        static bool IsEqual(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i]) return false;
            }

            return true;
        }
    }
}