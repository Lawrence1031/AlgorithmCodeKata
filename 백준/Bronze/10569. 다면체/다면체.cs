namespace _10569
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int V = int.Parse(inputs[0]);
                int E = int.Parse(inputs[1]);

                Console.WriteLine(2 - V + E);
            }
        }
    }
}