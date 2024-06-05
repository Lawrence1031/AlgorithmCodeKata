namespace _10610
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputs = Console.ReadLine().ToArray();
            string answer = Make30(inputs);
            Console.WriteLine(answer);
        }

        static string Make30(char[] inputs)
        {
            if (!inputs.Contains('0'))
            {
                return "-1";
            }

            int sumOfDigits = inputs.Sum(x => x - '0');
            if (sumOfDigits % 3 != 0)
            {
                return "-1";
            }

            Array.Sort(inputs);
            Array.Reverse(inputs);

            return new string(inputs);
        }
    }
}