namespace _6763
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int currentSpeed = int.Parse(Console.ReadLine());
            int diff = currentSpeed - limit;

            if (diff >= 1 && diff <= 20)
            {
                Console.WriteLine("You are speeding and your fine is $100.");
            }
            else if (diff >= 21 && diff <= 30)
            {
                Console.WriteLine("You are speeding and your fine is $270.");
            }
            else if (diff >= 31)
            {
                Console.WriteLine("You are speeding and your fine is $500.");
            }
            else
            {
                Console.WriteLine("Congratulations, you are within the speed limit!");
            }
        }
    }
}