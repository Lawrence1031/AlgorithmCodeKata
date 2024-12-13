namespace _21966
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (N <= 25)
            {
                Console.WriteLine(input);
                return;
            }

            string inner = input.Substring(11, N - 22);
            bool IsOne = true;
            for (int i = 1; i < inner.Length -1; i++)
            {
                if (inner[i] == '.')
                {
                    IsOne = false;
                }
            }

            if (IsOne)
            {
                string startPart = input.Substring(0, 11);
                string endPart = input.Substring(N - 11, 11);
                Console.WriteLine($"{startPart}...{endPart}");
            }
            else
            {
                string startPart = input.Substring(0, 9);
                string endPart = input.Substring(N - 10, 10);
                Console.WriteLine($"{startPart}......{endPart}");
            }
        }
    }
}