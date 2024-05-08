namespace _1681
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            char L = inputs[1][0];

            int cnt = 0;
            int num = 1;

            while (cnt < N)
            {
                if (!num.ToString().Contains(L))
                {
                    cnt++;
                    if (cnt == N)
                    {
                        Console.WriteLine(num);
                        return;
                    }
                }
                num++;
            }
        }
    }
}