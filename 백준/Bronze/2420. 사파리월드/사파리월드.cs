namespace _2420
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            long a = Convert.ToInt64(ss[0]);
            long b = Convert.ToInt64(ss[1]);
            long c = Math.Abs(a - b);
            Console.WriteLine(c);
        }
    }
}