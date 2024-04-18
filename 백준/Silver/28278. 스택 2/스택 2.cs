using System.Text;

namespace _28278
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> stack = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                int x = int.Parse(input.Split(' ')[0]);
                int len = stack.Count - 1;

                if (x == 1)
                {
                    stack.Add(int.Parse(input.Split(' ')[1]));
                }
                else if (x == 2)
                {
                    if (stack.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(stack[len].ToString());
                        stack.RemoveAt(len);
                    }
                }
                else if (x == 3)
                {
                    sb.AppendLine(stack.Count.ToString());
                }
                else if (x == 4)
                {
                    if (stack.Count > 0)
                    {
                        sb.AppendLine("0");
                    }
                    else
                    {
                        sb.AppendLine("1");
                    }
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(stack[len].ToString());
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}