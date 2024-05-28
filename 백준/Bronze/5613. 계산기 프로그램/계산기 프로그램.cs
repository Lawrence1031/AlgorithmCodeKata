namespace _5613
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> operators = new List<string>();
            int result = int.Parse(Console.ReadLine());
            int cnt = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "=")
                {
                    break;
                }

                if (cnt % 2 == 1)
                {
                    numbers.Add(int.Parse(input));
                }
                else
                {
                    operators.Add(input);
                }

                cnt++;
            }

            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case "+":
                        result += numbers[i];
                        break;
                    case "-":
                        result -= numbers[i];
                        break;
                    case "*":
                        result *= numbers[i];
                        break;
                    case "/":
                        result /= numbers[i];
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}