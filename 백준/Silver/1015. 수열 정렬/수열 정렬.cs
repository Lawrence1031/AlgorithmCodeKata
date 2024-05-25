namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];

            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(inputs[i]);
            }

            var indexedA = A.Select((value, index) => new {Value = value, Index = index})
                            .OrderBy(pair => pair.Value)
                            .ToList();

            int[] P = new int[N];
            for (int i = 0; i < N; i++)
            {
                P[indexedA[i].Index] = i;
            }

            Console.WriteLine(string.Join(" ", P));
        }
    }
}