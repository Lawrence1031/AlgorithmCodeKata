namespace _24083
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int now = (A + B) % 12;
            
            Console.WriteLine(now == 0 ? 12 : now);
        }
    }
}