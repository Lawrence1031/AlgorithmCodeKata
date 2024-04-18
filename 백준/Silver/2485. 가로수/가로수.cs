namespace _2485
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] distance = new int[N - 1];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = arr[i + 1] - arr[i];
            }

            int gcd = distance[0];
            for (int i = 0; i < distance.Length; i++)
            {
                gcd = GCD(gcd, distance[i]);
            }

            int x = (arr[N - 1] - arr[0]) / gcd;
            Console.WriteLine(x - N + 1);

        }
        static int LCM(int A, int B)
        {
            return A * B / GCD(A, B);
        }

        static int GCD(int A, int B)
        {
            return (A % B == 0 ? B : GCD(B, A % B));
        }
    }
}