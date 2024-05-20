namespace _1526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = int.Parse(input);

            for (int i = N; i > 0; i--)
            {
                string number = i.ToString();
                bool[] IsGoldNumber = new bool[number.Length];

                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] == '4' || number[j] == '7')
                    {
                        IsGoldNumber[j] = true;
                    }
                }

                if (IsAnswer(IsGoldNumber))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        static bool IsAnswer(bool[] IsGoldNumber)
        {
            bool IsAnswer = true;

            foreach (bool b in IsGoldNumber)
            {
                if (!b)
                {
                    IsAnswer = false;
                }
            }

            return IsAnswer;
        }
    }
}