using System.Text;

namespace _24511
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // queuestack

            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());

            int[] arrA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arrB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int M = int.Parse(Console.ReadLine());
            int[] arrM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (arrA[i] == 0)
                {
                    list.Add(arrB[i]);
                }
            }

            list.Reverse();

            for (int i = 0; i < M; i++)
            {
                list.Add(arrM[i]);
            }

            list = list.GetRange(0, M);

            Console.WriteLine(string.Join(" ", list));
        }
    }
}