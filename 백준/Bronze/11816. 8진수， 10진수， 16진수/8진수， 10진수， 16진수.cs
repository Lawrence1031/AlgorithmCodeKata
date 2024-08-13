namespace _11816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int answer = 0;

            if (input[0] == '0')
            {
                if (input[1] == 'x')
                {
                    answer = HexToDec(input);
                }
                else
                {
                    answer = EightToDec(input);
                }
            }
            else
            {
                answer = int.Parse(input);
            }

            Console.WriteLine(answer);
        }

        static int EightToDec(string input)
        {
            int answer = 0;
            int baseValue = 1;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = input[i] - '0';
                answer += currentDigit * baseValue;

                baseValue *= 8;
            }

            return answer;
        }

        static int HexToDec(string input)
        {
            int answer = 0;
            int baseValue = 1;

            input = input.Substring(2);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char currentChar = input[i];

                if (currentChar >= '0' && currentChar <= '9')
                {
                    answer += (currentChar - '0') * baseValue;
                }
                else
                {
                    answer += (currentChar - 'a' + 10) * baseValue;
                }

                baseValue *= 16;
            }

            return answer;
        }
    }
}