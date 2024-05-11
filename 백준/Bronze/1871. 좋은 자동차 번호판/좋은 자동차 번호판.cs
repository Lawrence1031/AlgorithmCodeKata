namespace _1871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split("-");
                string alp = inputs[0];
                int num = int.Parse(inputs[1]);

                int alpNum = (alp[0] - 'A') * 26 * 26 + (alp[1] - 'A') * 26 + alp[2] - 'A';
                int answer = Math.Abs(alpNum - num);

                if (answer <= 100)
                {
                    Console.WriteLine("nice");
                }
                else
                {
                    Console.WriteLine("not nice");
                }
            }
        }
    }
}