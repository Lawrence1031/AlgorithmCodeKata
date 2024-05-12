namespace _3059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine(noAlp(input));
            }
        }

        static int noAlp(string str)
        {
            int sum = 2015;
            HashSet<char> seen = new HashSet<char>();

            foreach (char c in str)
            {
                if (!seen.Contains(c))
                {
                    sum -= (int)c;
                    seen.Add(c);
                }
            }

            return sum;
        }
    }
}