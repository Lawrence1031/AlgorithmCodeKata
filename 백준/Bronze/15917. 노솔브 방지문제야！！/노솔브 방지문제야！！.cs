using System.Text;

namespace _15917
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string[] arr = new string[32];
            MakeArr(arr);

            for (int i = 0; i < Q; i++)
            {
                string a = Console.ReadLine();

                if (arr.Contains(a))
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }

            Console.WriteLine(sb.ToString());
        }

        static string[] MakeArr(string[] arr)
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                arr[i] = Math.Pow(2, i).ToString();
            }

            return arr;
        }
    }
}