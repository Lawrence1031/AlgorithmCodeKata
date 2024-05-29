namespace _2386
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "#")
                {
                    return;
                }

                char target = input[0];
                string lines = input.Substring(2).ToLower();
                int cnt = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == target)
                    {
                        cnt++;
                    }
                }

                Console.WriteLine($"{target} {cnt}");
            }
        }
    }
}