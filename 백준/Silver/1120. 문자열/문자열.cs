namespace _1120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string X = inputs[0];
            string Y = inputs[1];

            int minDiff = Y.Length;

            for (int i = 0; i <= Y.Length -X.Length; i++)
            {
                int diff = 0;

                for (int j = 0; j < X.Length; j++)
                {
                    if (X[j] != Y[i + j])
                    {
                        diff++;
                    }
                }

                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            Console.WriteLine(minDiff);
        }
    }
}