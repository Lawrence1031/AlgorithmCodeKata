namespace _8545
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = new string(input.Reverse().ToArray());

            Console.WriteLine(output);
        }
    }
}