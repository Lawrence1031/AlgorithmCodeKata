namespace _2028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                int n = int.Parse(input);
                int cube = n * n;

                if (cube % Math.Pow(10, input.Length) == n)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}