using System.Text;

namespace _4949
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == ".") break;

                Console.WriteLine(IsBalanced(input) ? "yes" : "no");
            }
        }

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char last = stack.Pop();
                    if (c == ')' && last != '(' || c == ']' && last != '[')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}