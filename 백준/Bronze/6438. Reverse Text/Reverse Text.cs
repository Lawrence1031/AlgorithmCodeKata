namespace _6438
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                string answer = new string(input.Reverse().ToArray());

                Console.WriteLine(answer);
            }
        }
    }
}