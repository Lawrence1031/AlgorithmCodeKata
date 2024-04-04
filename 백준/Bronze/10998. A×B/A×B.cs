namespace _10998
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(" ");
            int a = Convert.ToInt32(ss[0]);
            int b = Convert.ToInt32(ss[1]);
            Console.WriteLine(a * b);
        }
    }
}