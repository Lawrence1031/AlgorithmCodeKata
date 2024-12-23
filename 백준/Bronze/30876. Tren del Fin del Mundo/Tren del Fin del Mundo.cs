namespace _30876
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int southestX = 1001;
            int southestY = 1001;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                if (y < southestY)
                {
                    southestX = x;
                    southestY = y;
                }
            }

            Console.WriteLine($"{southestX} {southestY}");
        }
    }
}