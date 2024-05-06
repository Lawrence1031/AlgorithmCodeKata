namespace _1350
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            string[] inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            double cluster = int.Parse(Console.ReadLine());
            double answer = 0;

            foreach (int i in arr)
            {
                answer += cluster * Math.Ceiling(i / cluster);
            }

            Console.WriteLine(answer);
        }
    }
}