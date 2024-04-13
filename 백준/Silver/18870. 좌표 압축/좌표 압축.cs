using System.Text;

namespace _18870
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            StringBuilder sb = new StringBuilder();

            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            int[] sortedArr = Enumerable.Range(0, N)
                                        .OrderBy(i => arr[i])
                                        .ThenBy(i => i)
                                        .ToArray();

            int[] result = new int[N];
            int rank = 0;
            int preValue = arr[sortedArr[0]];
            for (int i = 0; i < N; i++)
            {
                int curValue = arr[sortedArr[i]];
                if (curValue != preValue)
                {
                    rank++;
                    preValue = curValue;
                }
                result[sortedArr[i]] = rank;
            }

            foreach (int i in result)
            {
                sb.Append(i + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}