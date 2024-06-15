namespace _15734
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int L = int.Parse(inputs[0]);
            int R = int.Parse(inputs[1]);
            int A = int.Parse(inputs[2]);

            int diff = Math.Abs(L - R);

            if (A >= diff)
            {
                A -= diff;
                if (L < R)
                {
                    L += diff;
                }
                else
                {
                    R += diff;
                }
            }
            else
            {
                if (L < R)
                {
                    L += A;
                }
                else
                {
                    R += A;
                }
                A = 0;
            }

            L += A / 2;
            R += A / 2;

            int maxPlayer = 2 * Math.Min(L, R);
            Console.WriteLine(maxPlayer);
        }
    }
}