namespace _5789
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input[input.Length / 2] == input[input.Length / 2 - 1])
                {
                    Console.WriteLine("Do-it");
                }
                else
                {
                    Console.WriteLine("Do-it-Not");
                }
            }
        }
    }
}