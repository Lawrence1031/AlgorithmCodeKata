namespace _3034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int W = int.Parse(inputs[1]);
            int H = int.Parse(inputs[2]);

            for (int i = 0; i < N; i++)
            {
                int len = int.Parse(Console.ReadLine());

                if (len * len <= W * W + H * H)
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NE");
                }
            }
        }
    }
}