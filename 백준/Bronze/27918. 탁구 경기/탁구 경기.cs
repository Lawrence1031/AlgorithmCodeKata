namespace _27918
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int D = 0;
            int P = 0;
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (input == "D")
                {
                    D++;
                }
                else if (input == "P")
                {
                    P++;
                }

                if (Math.Abs(D - P) >= 2)
                {
                    Console.WriteLine($"{D}:{P}");
                    return;
                }
            }

            Console.WriteLine($"{D}:{P}");
        }
    }
}