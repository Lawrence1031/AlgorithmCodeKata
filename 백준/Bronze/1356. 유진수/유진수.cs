namespace _1356
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 1; i < input.Length; i++)
            {
                string left = input.Substring(0, i);
                string right = input.Substring(i, input.Length - i);

                int leftNum = 1;
                int rightNum = 1;

                for (int j = 0; j < left.Length; j++)
                {
                    leftNum *= left[j] - '0';
                }

                for (int j = 0; j < right.Length; j++)
                {
                    rightNum *= right[j] - '0';
                }

                if (leftNum == rightNum)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}