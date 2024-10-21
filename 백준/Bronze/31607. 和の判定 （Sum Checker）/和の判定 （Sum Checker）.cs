namespace _31607
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            for (int i = 0; i < 3; i++)
            {
                if (sum / 2.0 == numbers[i])
                {
                    Console.WriteLine(1);
                    return;
                }
            }

            Console.WriteLine(0);
        }
    }
}