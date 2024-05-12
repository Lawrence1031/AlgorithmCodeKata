namespace _4084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0] == "0")
                {
                    return;
                }

                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int c = int.Parse(inputs[2]);
                int d = int.Parse(inputs[3]);

                Console.WriteLine(SameCnt(a, b, c, d));
            }
        }

        static int SameCnt(int a, int b, int c , int d)
        {
            int cnt = 0;

            while (true)
            {
                if (a == b && b == c && c == d)
                {
                    return cnt;
                }

                int tmp = a;
                a = Math.Abs(a - b);
                b = Math.Abs(b - c);
                c = Math.Abs(c - d);
                d = Math.Abs(d - tmp);
                cnt++;
            }
        }
    }
}