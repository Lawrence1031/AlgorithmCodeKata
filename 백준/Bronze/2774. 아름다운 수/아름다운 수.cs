namespace _2774
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                HashSet<char> numbers = new HashSet<char>();

                foreach (char c in input)
                {
                    numbers.Add(c);
                }

                Console.WriteLine(numbers.Count);
            }
        }
    }
}