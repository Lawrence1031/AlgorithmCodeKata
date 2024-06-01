namespace _1448
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] sides = new int[N];
            for (int i = 0; i < N; i++)
            {
                sides[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sides);
            Array.Reverse(sides);

            for (int i = 0; i < sides.Length - 2; i++)
            {
                int a = sides[i];
                int b = sides[i + 1];
                int c = sides[i + 2];

                if (a < b + c)
                {
                    Console.WriteLine(a + b + c);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}