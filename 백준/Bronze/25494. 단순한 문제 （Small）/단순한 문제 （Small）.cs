namespace _25494
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);
                int cnt = 0;

                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= b; j++)
                    {
                        for (int k = 1; k <= c; k++)
                        {
                            if ((i % j == j % k) && (j % k == k % i))
                            {
                                cnt++;
                            }
                        }
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}