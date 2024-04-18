namespace _1427
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            char[] chr = N.ToCharArray();

            Array.Sort(chr);
            Array.Reverse(chr);

            Console.WriteLine(chr);
        }
    }
}