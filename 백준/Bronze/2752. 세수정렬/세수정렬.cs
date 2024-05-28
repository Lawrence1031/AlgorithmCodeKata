namespace _2752
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(inputs[i]);
            }
            Array.Sort(numbers);

            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
        }
    }
}