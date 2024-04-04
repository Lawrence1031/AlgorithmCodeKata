namespace _2754
{
    internal class Program
    {
        enum CScore
        {
            A = 4, B = 3, C = 2, D = 1, F = 0
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double answer = 0;

            if (Enum.TryParse(s.Substring(0, 1), out CScore score))
            {
                answer = (double)score;
            }

            if (s.Length > 1)
            {
                if (s[1] == '+')
                {
                    answer += 0.3;
                }
                else if (s[1] == '-')
                {
                    answer -= 0.3;
                }
            }

            Console.WriteLine($"{answer:0.0}");
        }
    }
}