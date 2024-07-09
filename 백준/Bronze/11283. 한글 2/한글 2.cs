namespace _11283
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int baseCode = 0xAC00;

            Console.WriteLine((char)input[0] - baseCode + 1);
        }
    }
}