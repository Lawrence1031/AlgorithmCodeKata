namespace _5013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] == 'C' && input[j + 1] == 'D')
                    {
                        cnt++;
                        break;
                    }
                }
            }

            Console.WriteLine(n - cnt);
        }
    }
}