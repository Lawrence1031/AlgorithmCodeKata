namespace _31962
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int X = int.Parse(inputs[1]);
            int maxLate = 0;
            int maxTime = 0;

            for (int i = 0; i < N; i++)
            {
                string[] bus = Console.ReadLine().Split(' ');
                int late = int.Parse(bus[0]);
                int arrive = int.Parse(bus[1]);

                if (maxTime < late + arrive && late + arrive <= X)
                {
                    maxTime = late + arrive;
                    maxLate = late;
                }
            }

            Console.WriteLine(maxLate == 0 ? -1 : maxLate);
        }
    }
}