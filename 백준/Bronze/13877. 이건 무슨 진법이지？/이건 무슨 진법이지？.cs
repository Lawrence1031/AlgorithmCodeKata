namespace _13877
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string[] answer = new string[3];
                int ten = int.Parse(inputs[1]);

                answer[0] = IsEight(inputs[1]) ? Convert.ToInt32(inputs[1], 8).ToString() : "0";
                answer[1] = ten.ToString();
                answer[2] = Convert.ToInt32(inputs[1], 16).ToString();

                Console.WriteLine($"{i + 1} {answer[0]} {answer[1]} {answer[2]}");
            }
        }

        static bool IsEight(string number)
        {
            foreach (char c in number)
            {
                if (c > '7')
                {
                    return false;
                }
            }

            return true;
        }
    }
}