namespace _2506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int score = 0;
            int result = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (i > 0)
                {
                    if (inputs[i] == "1" && inputs[i - 1] == "1")
                    {
                        score++;
                        result += score;
                    }
                    else if (inputs[i] == "1" && inputs[i - 1] == "0")
                    {
                        score = 1;
                        result += score;
                    }
                    else
                    {
                        score = 0;
                    }
                }
                else
                {
                    if (inputs[i] == "1")
                    {
                        score++;
                        result += score;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}