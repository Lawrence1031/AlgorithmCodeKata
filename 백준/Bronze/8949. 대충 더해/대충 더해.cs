namespace _8949
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string A = inputs[0];
            string B = inputs[1];
            int lenA = A.Length;
            int lenB = B.Length;

            if (lenA > lenB)
            {
                B = B.PadLeft(lenA, '0');
            }
            else
            {
                A = A.PadLeft(lenB, '0');
            }

            string answer = "";
            for (int i = 0; i < Math.Max(lenA, lenB); i++)
            {
                answer += A[i] - '0' + B[i] -'0';
            }

            Console.WriteLine(answer);
        }
    }
}