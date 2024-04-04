namespace _15964
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A@B = (A+B)X(A-B) == A * A - B * B

            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            long a = long.Parse(ss[0]);
            long b = long.Parse(ss[1]);
            Console.WriteLine(a * a - b * b);
        }
    }
}