using System.Text;

namespace _2161
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                list.Add(i);
            }

            while (list.Count > 1)
            {
                sb.Append(list[0] + " ");

                list.RemoveAt(0);
                list.Add(list[0]);
                list.RemoveAt(0);
            }

            sb.Append(list[0]);

            Console.WriteLine(sb.ToString());
        }
    }
}