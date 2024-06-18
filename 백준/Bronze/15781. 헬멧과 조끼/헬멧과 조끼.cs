namespace _15781
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] helmets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] vests = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long bestDef = helmets.Max() + vests.Max();
            Console.WriteLine(bestDef);
        }
    }
}