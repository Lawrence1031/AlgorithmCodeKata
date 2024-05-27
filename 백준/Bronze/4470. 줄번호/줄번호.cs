namespace _4470
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine($"{i + 1}. {input}");
            }
        }
    }
}