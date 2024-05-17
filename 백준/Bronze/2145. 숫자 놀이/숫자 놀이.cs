namespace _2145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "0")
                {
                    return;
                }

                int answer = ToOneDigit(input);
                Console.WriteLine(answer);
            }
        }

        static int ToOneDigit(string number)
        {
            while (number.Length > 1)
            {
                number = number.Sum(c => c - '0').ToString();
            }

            return int.Parse(number);
        }
    }
}