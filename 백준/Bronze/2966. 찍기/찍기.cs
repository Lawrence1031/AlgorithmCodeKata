namespace _2966
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int adrian = AdrianAnswer(input);
            int bruno = BrunoAnswer(input);
            int goran = GoranAnswer(input);

            int first = Math.Max(adrian, Math.Max(goran, bruno));
            Console.WriteLine(first);
            if (first == adrian) Console.WriteLine("Adrian");
            if (first == bruno) Console.WriteLine("Bruno");
            if (first == goran) Console.WriteLine("Goran");
        }

        static int AdrianAnswer(string input)
        {
            int cnt = 0;
            string pattern = "ABC";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == pattern[i % 3])
                    cnt++;
            }

            return cnt;
        }

        static int BrunoAnswer(string input)
        {
            int cnt = 0;
            string pattern = "BABC";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == pattern[i % 4])
                    cnt++;
            }

            return cnt;
        }

        static int GoranAnswer(string input)
        {
            int cnt = 0;
            string pattern = "CCAABB";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == pattern[i % 6])
                    cnt++;
            }

            return cnt;
        }
    }
}