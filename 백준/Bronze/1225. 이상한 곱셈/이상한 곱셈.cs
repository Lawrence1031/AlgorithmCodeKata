namespace _1225
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string A = inputs[0];
            string B = inputs[1];

            if (A == "0" ||  B == "0")
            {
                Console.WriteLine(0);
                return;
            }

            long result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    result += (A[i] - '0') * (B[j] - '0');
                }
            }

            Console.WriteLine(result);
        }
    }
}