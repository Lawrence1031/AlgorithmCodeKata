using System.Text;

namespace _1515
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int targetLength = input.Length;
            int curNumber = 1;
            int inputIdx = 0;

            while (inputIdx < targetLength)
            {
                string curString = curNumber.ToString();

                foreach (char c in curString)
                {
                    if (c == input[inputIdx])
                    {
                        inputIdx++;
                        if (inputIdx == targetLength)
                        {
                            break;
                        }
                    }
                }

                curNumber++;
            }

            Console.WriteLine(curNumber - 1);
        }
    }
}