namespace _2810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int cnt = 0;
            int answer = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'L')
                {
                    if (cnt == 0)
                    {
                        cnt++;
                    }
                    else
                    {
                        answer++;
                        cnt = 0;
                    }
                }
                else
                {
                    answer++;
                }
            }

            Console.WriteLine(Math.Min(n, answer));
        }
    }
}