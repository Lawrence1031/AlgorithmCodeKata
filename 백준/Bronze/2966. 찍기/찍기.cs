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

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 3 == 0 && input[i] == 'A') 
                    cnt++;
                else if (i % 3 == 1 && input[i] == 'B')
                    cnt++;
                else if (i % 3 == 2 && input[i] == 'C')
                    cnt++;
            }

            return cnt;
        }

        static int BrunoAnswer(string input)
        {
            int cnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 4 == 0 && input[i] == 'B')
                    cnt++;
                else if (i % 4 == 1 && input[i] == 'A')
                    cnt++;
                else if (i % 4 == 2 && input[i] == 'B')
                    cnt++;
                else if (i % 4 == 3 && input[i] == 'C')
                    cnt++;
            }

            return cnt;
        }

        static int GoranAnswer(string input)
        {
            int cnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((i % 6 == 0 || i % 6 == 1) && input[i] == 'C')
                    cnt++;
                else if ((i % 6 == 2 || i % 6 == 3) && input[i] == 'A')
                    cnt++;
                else if ((i % 6 == 4 || i % 6 == 5) && input[i] == 'B')
                    cnt++;
            }

            return cnt;
        }
    }
}