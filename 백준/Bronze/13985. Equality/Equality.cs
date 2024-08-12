namespace _13985
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[2]);
            int c = int.Parse(inputs[4]);

            Console.WriteLine(a + b == c ? "YES" : "NO");
        }
    }
}