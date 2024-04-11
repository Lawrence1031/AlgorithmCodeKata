using System.Text;

namespace _1874
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] sequence = new int[N];
            for (int i = 0; i < N; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            int curNumber = 1;
            bool isPossible = true;

            foreach (int value in sequence)
            {
                if (curNumber <= value)
                {
                    while (curNumber <= value)
                    {
                        stack.Push(curNumber++);
                        sb.AppendLine("+");
                    }
                }

                if (stack.Peek() == value)
                {
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    isPossible = false;
                    break;
                }
            }

            if (isPossible)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}