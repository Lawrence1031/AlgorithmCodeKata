using System.Text;

namespace _1927
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);
            PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                input = Console.ReadLine();
                int x = int.Parse(input);

                if (x == 0)
                {
                    if (heap.Count > 0)
                    {
                        sb.AppendLine(heap.Dequeue().ToString());
                    }
                    else
                    {
                        sb.AppendLine("0");
                    }
                }
                else
                {
                    heap.Enqueue(x, x);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}