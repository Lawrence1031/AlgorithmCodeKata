namespace _25642
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int cnt = 0;

            while (A < 5 && B < 5)
            {
                if (cnt % 2 == 0)
                {
                    B += A;

                    if (B >= 5)
                    {
                        Console.WriteLine("yt");
                        return;
                    }
                }
                else
                {
                    A += B;

                    if (A >= 5)
                    {
                        Console.WriteLine("yj");
                        return;
                    }
                }
                cnt++;
            }
        }
    }
}