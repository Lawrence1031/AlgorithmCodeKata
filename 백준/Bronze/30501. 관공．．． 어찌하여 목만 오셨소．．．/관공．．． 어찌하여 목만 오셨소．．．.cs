namespace _30501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (input.Contains('S'))
                {
                    Console.WriteLine(input);
                    return;
                }
            }
        }
    }
}