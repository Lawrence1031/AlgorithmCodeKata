namespace _26645
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N < 206) Console.WriteLine(1);
            else if (N < 218) Console.WriteLine(2);
            else if (N < 229) Console.WriteLine(3);
            else Console.WriteLine(4);
        }
    }
}