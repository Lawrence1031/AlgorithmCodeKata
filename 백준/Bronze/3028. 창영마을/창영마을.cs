namespace _3028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int answer = 1;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'A':
                    if (answer == 1) answer = 2;
                    else if (answer == 2) answer = 1;
                    break;
                    case 'B':
                    if (answer == 2) answer = 3;
                    else if (answer == 3) answer = 2;
                    break;
                    case 'C':
                    if (answer == 1) answer = 3;
                    else if (answer == 3) answer = 1;
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}