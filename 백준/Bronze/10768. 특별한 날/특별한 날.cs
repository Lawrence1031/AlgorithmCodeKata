namespace _10768
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            if (month < 2)
            {
                Console.WriteLine("Before");
            }
            else if (month == 2)
            {
                if (day < 18)
                {
                    Console.WriteLine("Before");
                }
                else if (day == 18)
                {
                    Console.WriteLine("Special");
                }
                else
                {
                    Console.WriteLine("After");
                }
            }
            else
            {
                Console.WriteLine("After");
            }
        }
    }
}