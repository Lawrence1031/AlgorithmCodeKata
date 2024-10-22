namespace _15953
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int test = 0; test < T; test++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                int prize = 0;

                if (a <= 21 && a != 0)
                {
                    if (a == 1) prize += 500;
                    else if (a == 2 || a == 3) prize += 300;
                    else if (a == 4 || a == 5 || a == 6) prize += 200;
                    else if (a >= 7 && a <= 10) prize += 50;
                    else if (a >= 11 && a <= 15) prize += 30;
                    else prize += 10;
                }

                if (b <= 31 && b != 0)
                {
                    int mark = (int)Math.Pow(2, Math.Ceiling(Math.Log(b / 2 + 1) / Math.Log(2)));
                    prize += 512 / mark;
                }

                Console.WriteLine(prize * 10000);
            }
        }
    }
}