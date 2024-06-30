namespace _9228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "#")
                {
                    return;
                }

                int sum = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    int digit = int.Parse(input[input.Length - 1 - i].ToString());
                    sum += digit * (i + 2);
                }

                int remainder = sum % 11;
                int checkDigit = 11 - remainder;

                if (checkDigit == 10)
                {
                    Console.WriteLine($"{input} -> Rejected");
                }
                else if (checkDigit == 11)
                {
                    Console.WriteLine($"{input} -> 0");
                }
                else
                {
                    Console.WriteLine($"{input} -> {checkDigit}");
                }
            }
        }
    }
}