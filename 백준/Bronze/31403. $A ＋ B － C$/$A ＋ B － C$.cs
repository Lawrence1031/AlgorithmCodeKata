namespace _31403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();
            string answer = A + B;

            Console.WriteLine(int.Parse(A) + int.Parse(B) - int.Parse(C));
            Console.WriteLine(int.Parse(answer) - int.Parse(C));
        }
    }
}