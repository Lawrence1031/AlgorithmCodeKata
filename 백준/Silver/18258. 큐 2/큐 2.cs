using System.Text;

namespace _18258
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            StringBuilder sb = new StringBuilder();
            int lastNum = -1;

            for (int i = 1; i <= N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string command = inputs[0];

                switch (command)
                {
                    case "push":
                        int num = int.Parse(inputs[1]);
                        queue.Enqueue(num);
                        lastNum = num;
                        break;
                    case "pop":
                        sb.AppendLine(queue.Count == 0 ? "-1" : queue.Dequeue().ToString());
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "empty":
                        sb.AppendLine(queue.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sb.AppendLine(queue.Count == 0 ? "-1" : queue.Peek().ToString());
                        break;
                    case "back":
                        sb.AppendLine(queue.Count == 0 ? "-1" : lastNum.ToString());
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}