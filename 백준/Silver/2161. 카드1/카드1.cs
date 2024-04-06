using System.Text;

namespace _2161
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                queue.Enqueue(i);
            } 
            
            while (queue.Count > 1)
            {
                sb.Append(queue.Dequeue() + " ");
                queue.Enqueue(queue.Dequeue());
            }

            sb.Append(queue.Peek());

            Console.WriteLine(sb.ToString());
        }
    }
}