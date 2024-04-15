using System.Text;

namespace _3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int[] arr = new int[6];
            int[] compare = new int[6] { 1, 1, 2, 2, 2, 8 };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                arr[i] = int.Parse(inputs[i]);
                int diff = compare[i] - arr[i];

                sb.Append(diff + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}