namespace _9295
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < T; i++)
            {
                int[] dice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine($"Case {i + 1}: {dice.Sum()}");
            }
        }
    }
}