namespace _4740
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "***")
                {
                    return;
                }

                char[] chars = input.ToCharArray();
                Array.Reverse(chars);

                foreach (char c in chars)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}