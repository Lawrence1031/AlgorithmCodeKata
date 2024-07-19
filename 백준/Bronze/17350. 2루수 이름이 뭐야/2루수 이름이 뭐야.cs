namespace _17350
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (input == "anj")
                {
                    Console.WriteLine("뭐야;");
                    return;
                }
            }

            Console.WriteLine("뭐야?");
        }
    }
}