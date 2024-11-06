namespace _30700
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int alpCount = 0;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (alpCount % 5 == 0)
                {
                    if (input[i] == 'K')
                    {
                        count++;
                        alpCount++;
                    }
                }
                else if (alpCount % 5 == 1)
                {
                    if (input[i] == 'O')
                    {
                        count++;
                        alpCount++;
                    }
                }
                else if (alpCount % 5 == 2)
                {
                    if (input[i] == 'R')
                    {
                        count++;
                        alpCount++;
                    }
                }
                else if (alpCount % 5 == 3)
                {
                    if (input[i] == 'E')
                    {
                        count++;
                        alpCount++;
                    }
                }
                else
                {
                    if (input[i] == 'A')
                    {
                        count++;
                        alpCount++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}