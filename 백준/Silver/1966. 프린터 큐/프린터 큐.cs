using System.Text;

namespace _1966
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < L; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                string[] priorities = Console.ReadLine().Split(' ');
                Queue<(int priority, int idx)> queue = new Queue<(int, int)>();

                for (int j = 0; j < N; j++)
                {
                    int priority = int.Parse(priorities[j]);
                    queue.Enqueue((priority, j));
                }

                int order = 0;
                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    bool hasHigherPriority = false;

                    foreach (var item in queue)
                    {
                        if (item.priority > current.priority)
                        {
                            hasHigherPriority = true;
                            break;
                        }
                    }

                    if (hasHigherPriority)
                    {
                        queue.Enqueue(current);
                    }
                    else
                    {
                        order++;
                        if (current.idx == M)
                        {
                            sb.AppendLine(order.ToString());
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}