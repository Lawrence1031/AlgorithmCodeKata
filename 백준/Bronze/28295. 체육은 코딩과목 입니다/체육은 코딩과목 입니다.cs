namespace _28295
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 0; i < 10; i++)
            {
                int t = int.Parse(Console.ReadLine());

                if (t == 1)
                {
                    cnt += 90;
                    cnt %= 360;
                }
                else if (t == 2)
                {
                    cnt += 180;
                    cnt %= 360;
                }
                else
                {
                    cnt += 270;
                    cnt %= 360;
                }
            }

            cnt /= 90;
            string[] direction = { "N", "E", "S", "W" };
            Console.WriteLine(direction[cnt]);
        }
    }
}