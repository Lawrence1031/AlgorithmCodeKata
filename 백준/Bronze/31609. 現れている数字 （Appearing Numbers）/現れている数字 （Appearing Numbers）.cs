namespace _31609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> resulst = numbers.OrderBy(num => num).ToHashSet();

            foreach (int num in resulst)
            {
                Console.WriteLine(num);
            }
        }
    }
}