namespace _11382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(" ");
            long a = Convert.ToInt64(ss[0]);
            long b = Convert.ToInt64(ss[1]);
            long c = Convert.ToInt64(ss[2]);
            Console.WriteLine(a + b + c);
        }
    }
}