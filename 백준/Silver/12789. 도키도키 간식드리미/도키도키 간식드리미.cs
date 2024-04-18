namespace _12789
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int nowNum = 1;
            Stack<int> stack = new Stack<int>();

            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                if (int.Parse(inputs[i]) == nowNum)
                {
                    nowNum++;
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() == nowNum)
                    {
                        stack.Pop();
                        nowNum++;
                    }
                    stack.Push(int.Parse(inputs[i]));
                }
            }

            while (stack.Count > 0 && stack.Peek() == nowNum)
            {
                stack.Pop();
                nowNum++;
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Nice");
            }
            else
            {
                Console.WriteLine("Sad");
            }

        }
    }
}