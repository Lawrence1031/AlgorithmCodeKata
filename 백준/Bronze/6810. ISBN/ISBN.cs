namespace _6810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tenOne = int.Parse(Console.ReadLine());
            int tenTwo = int.Parse(Console.ReadLine());
            int tenThree = int.Parse(Console.ReadLine());
            int sum = 91 + tenOne + tenTwo * 3 + tenThree;
            Console.WriteLine($"The 1-3-sum is {sum}");
        }
    }
}