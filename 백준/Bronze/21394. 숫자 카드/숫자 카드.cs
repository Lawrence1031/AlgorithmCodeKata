using System.Text;

namespace _21394
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;

            while (cnt < N)
            {
                int[] cardCnt = new int[10];
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < 9; i++)
                {
                    cardCnt[i + 1] = int.Parse(input[i]);
                }

                cardCnt[9] += cardCnt[6];
                cardCnt[6] = 0;
                StringBuilder sbLeft = new StringBuilder();
                StringBuilder sbRight = new StringBuilder();

                for (int i = 9; i >= 1; i--)
                {
                    while (cardCnt[i]-- > 0)
                    {
                        if (sbLeft.Length <= sbRight.Length)
                        {
                            sbLeft.Append(i + " ");
                        }
                        else
                        {
                            sbRight.Insert(0, i + " ");
                        }
                    }
                }

                Console.WriteLine(sbLeft.ToString() + sbRight.ToString().TrimEnd());
                cnt++;
            }
        }
    }
}