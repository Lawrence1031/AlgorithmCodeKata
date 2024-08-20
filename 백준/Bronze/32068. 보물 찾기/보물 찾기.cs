namespace _32068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int L = int.Parse(inputs[0]);
                int R = int.Parse(inputs[1]);
                int S = int.Parse(inputs[2]);

                int cnt = 0;
                int find = 0;
                int now = S;

                while (find < 2)
                {
                    if (now == L || now == R)
                    {
                        find++;
                    }
                    else
                    {
                        if (cnt % 2 == 0)
                        {
                            now += (cnt + 1);
                        }
                        else
                        {
                            now -= (cnt + 1);
                        }
                    }
                    cnt++;
                }

                Console.WriteLine(cnt - 1);
            }
        }
    }
}