namespace _30045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    if ((input[j] == '0' && input[j + 1] == '1') ||
                        (input[j] == 'O' && input[j + 1] == 'I'))
                    {
                        cnt++;
                        break;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}