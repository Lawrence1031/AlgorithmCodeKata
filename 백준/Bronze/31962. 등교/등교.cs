namespace _31962
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int X = int.Parse(inputs[1]);
            int maxLate = -1;

            for (int i = 0; i < N; i++)
            {
                string[] bus = Console.ReadLine().Split(' ');
                int late = int.Parse(bus[0]);
                int arrive = int.Parse(bus[1]);

                if (late + arrive <= X && late > maxLate)
                {
                    maxLate = late;
                }
            }

            Console.WriteLine(maxLate);
        }
    }
}