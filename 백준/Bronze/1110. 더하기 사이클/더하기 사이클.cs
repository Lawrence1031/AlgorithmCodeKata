namespace _1110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);

            int cnt = 1;

            int number;
            int newNumber;
            string answer = "";

            while (true)
            {
                number = N / 10 + N % 10;
                answer = (N % 10).ToString() + (number % 10).ToString();
                N = int.Parse(answer);

                if (int.Parse(answer) == int.Parse(input))
                {
                    Console.WriteLine(cnt);
                    return;
                }
                cnt++;
            }
        }
    }
}