namespace _1547
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int now = 1;

            for (int i = 0; i < M; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);

                if (a == now)
                {
                    now = b;
                }
                else if (b == now)
                {
                    now = a;
                }
            }

            Console.WriteLine(now);
        }
    }
}