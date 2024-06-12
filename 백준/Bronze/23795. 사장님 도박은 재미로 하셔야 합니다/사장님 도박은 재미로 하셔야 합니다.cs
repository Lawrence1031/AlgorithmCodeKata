namespace _23795
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    break;
                }

                money += int.Parse(input);
            }

            Console.WriteLine(money);
        }
    }
}