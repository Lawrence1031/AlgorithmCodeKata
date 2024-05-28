namespace _5523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int aWin = 0;
            int bWin = 0;

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int aScore = int.Parse(inputs[0]);
                int bScore = int.Parse(inputs[1]);

                if (aScore > bScore)
                {
                    aWin++;
                }
                else if (aScore < bScore)
                {
                    bWin++;
                }
            }

            Console.WriteLine($"{aWin} {bWin}");
        }
    }
}