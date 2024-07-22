namespace _8741
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            string result = new string('1', k) + new string('0', k - 1);

            Console.WriteLine(result);
        }
    }
}