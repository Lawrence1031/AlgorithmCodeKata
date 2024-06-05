namespace _16944
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] cnts = new int[4];
            int answer = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ('0' <= input[i] && input[i] <= '9')
                {
                    cnts[0]++;
                }
                else if ('a' <= input[i] && input[i] <= 'z')
                {
                    cnts[1]++;
                }
                else if ('A' <= input[i] && input[i] <= 'Z')
                {
                    cnts[2]++;
                }
                else
                {
                    cnts[3]++;
                }
            }

            for (int i = 0; i < cnts.Length; i++)
            {
                if (cnts[i] == 0)
                {
                    answer++;
                    N++;
                }
            }

            while (N < 6)
            {
                answer++;
                N++;
            }

            Console.WriteLine(answer);            
        }
    }
}