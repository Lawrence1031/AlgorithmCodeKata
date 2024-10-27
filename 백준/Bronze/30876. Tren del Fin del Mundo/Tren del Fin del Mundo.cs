namespace _30876
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] stations = new int[N, 2];
            int southestX = 1001;
            int southestY = 1001;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);
                stations[i, 0] = x;
                stations[i, 1] = y;

                if (stations[i, 1] < southestY)
                {
                    southestX = stations[i, 0];
                    southestY = stations[i, 1];
                }
            }

            Console.WriteLine($"{southestX} {southestY}");
        }
    }
}