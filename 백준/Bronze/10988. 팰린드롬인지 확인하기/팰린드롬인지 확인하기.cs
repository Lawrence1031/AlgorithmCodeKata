namespace _10988
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int len = input.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine(1);
        }
    }
}