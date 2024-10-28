namespace _5063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int r = int.Parse(inputs[0]);
                int e = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);

                if (r > e - c)
                {
                    Console.WriteLine("do not advertise");
                }
                else if (r == e - c)
                {
                    Console.WriteLine("does not matter");
                }
                else
                {
                    Console.WriteLine("advertise");
                }
            }
        }
    }
}