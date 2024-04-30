namespace _1267
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int Y = 0;
            int M = 0;

            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
                Y += arr[i] / 30 + (arr[i] % 30 >= 0 ? 1 : 0);
                M += arr[i] / 60 + (arr[i] % 60 >= 0 ? 1 : 0);
            }

            Y = Y * 10;
            M = M * 15;

            if (Y > M)
            {
                Console.WriteLine("M" + " " + M);
            }
            else if (Y < M)
            {
                Console.WriteLine("Y" + " " + Y);
            }
            else
            {
                Console.WriteLine("Y M" + " " + Y);
            }
        }
    }
}