namespace _28074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Contains("M") && input.Contains("O") &&
                input.Contains("B") && input.Contains("I") &&
                input.Contains("S"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}