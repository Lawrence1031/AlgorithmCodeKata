namespace _1673
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                string[] inputs = input.Split(' ');
                int n = int.Parse(inputs[0]);
                int k = int.Parse(inputs[1]);
                int answer = n;

                while (n / k > 0)
                {
                    answer += n / k;
                    n = n / k + n % k;
                }

                Console.WriteLine(answer);
            }
        }
    }
}