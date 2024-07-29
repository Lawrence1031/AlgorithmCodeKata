namespace _30979
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[] aji = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(T > aji.Sum() ? "Padaeng_i Cry" : "Padaeng_i Happy");
        }
    }
}