using System.Text;

namespace _11866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = int.Parse(s.Split(' ')[0]);
            int K = int.Parse(s.Split(' ')[1]);
            Queue<int> queue = new Queue<int>();
            for (int i = 1; i <= N; i++)
            {
                queue.Enqueue(i);
            }

            List<int> list = new List<int>();
            while (queue.Count > 0)
            {
                for (int i = 1; i < K; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                list.Add(queue.Dequeue());
            }

            Console.WriteLine("<" + string.Join(", ", list) + ">");

        }
    }
}