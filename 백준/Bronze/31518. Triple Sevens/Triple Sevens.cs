namespace _31518
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                int[] digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                if (!digits.Contains(7))
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine("777");
        }
    }
}