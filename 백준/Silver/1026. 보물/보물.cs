namespace _1026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];

            string[] inputsA = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(inputsA[i]);
            }

            string[] inputsB = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(inputsB[i]);
            }

            Array.Sort(A);
            Array.Reverse(A);
            Array.Sort(B);
            int answer = 0;

            for (int i = 0; i < N; i++)
            {
                answer += A[i] * B[i];
            }

            Console.WriteLine(answer);
        }
    }
}