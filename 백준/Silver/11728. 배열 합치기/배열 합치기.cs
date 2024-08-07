using System.Text;

namespace _11728
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            StringBuilder sb = new StringBuilder();

            int[] arrN = new int[N];
            int[] arrM = new int[M];
            arrN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            arrM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arrSum = new int[N + M];
            Array.Copy(arrN, arrSum, N);
            Array.Copy(arrM, 0, arrSum, N, M);

            Array.Sort(arrSum);

            foreach (int i in arrSum)
            {
                sb.Append(i + " ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}