namespace _6840
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a <= c || a >= c && a <= b)
            {
                Console.WriteLine(a);
            }
            else if (b >= c && b <= a || b >= a && b <= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }    
        }
    }
}