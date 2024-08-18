namespace _1639
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int n = S.Length;
            int maxLen = 0;

            for (int length = 2; length <= n; length += 2)
            {
                for (int i = 0; i <= n - length; i++)
                {
                    int half = length / 2;
                    int leftSum = 0;
                    int rightSum = 0;

                    for (int j = 0; j < half; j++)
                    {
                        leftSum += S[i + j] - '0';
                        rightSum += S[i + j + half] - '0';
                    }

                    if (leftSum == rightSum)
                    {
                        maxLen = Math.Max(maxLen, length);
                    }
                }
            }

            Console.WriteLine(maxLen);
        }
    }
}