namespace _9063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] arr = new int[2, N];
            int minX = 10001;
            int minY = 10001;
            int maxX = -10001;
            int maxY = -10001;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]);
                int y = int.Parse(inputs[1]);

                arr[0, i] = x;
                arr[1, i] = y;

                minX = Math.Min(minX, x);
                minY = Math.Min(minY, y);
                maxX = Math.Max(maxX, x);
                maxY = Math.Max(maxY, y);
            }

            int area = (maxX - minX) * (maxY - minY);
            Console.WriteLine(area);
        }
    }
}