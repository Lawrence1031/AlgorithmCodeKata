namespace _23303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Contains("d2") || input.Contains("D2"))
            {
                Console.WriteLine("D2");
            }
            else
            {
                Console.WriteLine("unrated");
            }
        }
    }
}