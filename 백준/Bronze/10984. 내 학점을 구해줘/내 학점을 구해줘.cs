namespace _10984
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int total = 0;
                double GPA = 0;

                for (int j = 0; j < N; j++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    total += int.Parse(inputs[0]);
                    GPA += double.Parse(inputs[1]) * int.Parse(inputs[0]);
                }

                Console.WriteLine($"{total} {GPA / total}");
            }
        }
    }
}