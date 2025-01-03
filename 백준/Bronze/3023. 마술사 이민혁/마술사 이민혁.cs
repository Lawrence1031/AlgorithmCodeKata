namespace _3023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int R = int.Parse(inputs[0]);
            int C = int.Parse(inputs[1]);

            string[] patterns = new string[R];

            for (int i = 0; i < R; i++)
            {
                patterns[i] = Console.ReadLine();
            }

            inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]) - 1;
            int B = int.Parse(inputs[1]) - 1;

            string[] card = new string[2 * R];

            for (int i = 0; i < card.Length; i++)
            {
                if (i < R)
                {
                    string reversed = new string(patterns[i].Reverse().ToArray());
                    card[i] = patterns[i] + reversed;
                }
                else
                {
                    string reversed = new string(patterns[2 * R - i - 1].Reverse().ToArray());
                    card[i] = patterns[2 * R - i - 1] + reversed;
                }
            }

            char[] row = card[A].ToCharArray();
            if (row[B] == '.')
            {
                row[B] = '#';
            }
            else
            {
                row[B] = '.';
            }

            card[A] = new string(row);

            foreach (var line in card)
            {
                Console.WriteLine(line);
            }
        }
    }
}