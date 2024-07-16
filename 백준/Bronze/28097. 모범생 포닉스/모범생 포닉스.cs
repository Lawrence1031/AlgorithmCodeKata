namespace _28097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int time = arr.Sum() + 8 * (arr.Length - 1);
            Console.WriteLine($"{time / 24} {time % 24}");
        }
    }
}