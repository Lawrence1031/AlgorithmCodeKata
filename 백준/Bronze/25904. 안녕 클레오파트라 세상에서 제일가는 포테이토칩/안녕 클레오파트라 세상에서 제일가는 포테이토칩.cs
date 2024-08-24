namespace _25904
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);
            int[] players = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int now = 0;

            while (true)
            {
                if (players[now] < M)
                {
                    Console.WriteLine(now + 1);
                    return;
                }

                now = (now + 1) % N;
                M++;                
            }
        }
    }
}