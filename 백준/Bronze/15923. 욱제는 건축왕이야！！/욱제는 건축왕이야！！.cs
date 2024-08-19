namespace _15923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] points = new int[N, 2];
            int answer = 0;

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                points[i, 0] = int.Parse(inputs[0]);
                points[i, 1] = int.Parse(inputs[1]);

                if (i > 0)
                {
                    answer += Math.Abs(points[i - 1, 0] - points[i, 0]);
                    answer += Math.Abs(points[i - 1, 1] - points[i, 1]);
                }
            }

            answer += Math.Abs(points[N - 1, 0] - points[0, 0]);
            answer += Math.Abs(points[N - 1, 1] - points[0, 1]);

            Console.WriteLine(answer);
        }
    }
}