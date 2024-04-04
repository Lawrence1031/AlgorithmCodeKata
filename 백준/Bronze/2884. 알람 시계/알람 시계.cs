namespace _2884
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);

            if (b >= 45)
            {
                b = b - 45;
                Console.WriteLine(a + " " + b);
            }
            else if (a > 0)
            {
                a = a - 1;
                b = 60 - 45 + b;
                Console.WriteLine(a + " " + b);
            }
            else
            {
                a = 23;
                b = 60 - 45 + b;
                Console.WriteLine(a + " " + b);
            }
        }
    }
}