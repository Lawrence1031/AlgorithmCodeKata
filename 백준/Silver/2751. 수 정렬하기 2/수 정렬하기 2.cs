using System.Text;

namespace _2751
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            foreach (int i in arr)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}