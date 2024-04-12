namespace _10773
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < K; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input != 0)
                {
                    stack.Push(input);
                }
                else
                {
                    stack.Pop();
                }
            }

            Console.WriteLine(stack.Sum());
            
        }
    }
}