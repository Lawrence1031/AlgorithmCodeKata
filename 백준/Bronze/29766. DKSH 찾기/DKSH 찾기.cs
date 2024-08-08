namespace _29766
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 0;
            for (int i = 0; i < input.Length - 3; i++)
            {
                if (input[i] == 'D' && input[i + 1] == 'K' &&
                    input[i + 2] == 'S' && input[i + 3] == 'H')
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}