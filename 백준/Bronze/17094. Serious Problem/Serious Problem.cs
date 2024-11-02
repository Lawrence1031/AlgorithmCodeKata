namespace _17094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenth = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int eCnt = input.Count(c => c == 'e');
            int twoCnt = input.Count(c => c == '2');

            Console.WriteLine(eCnt == twoCnt ? "yee" : eCnt > twoCnt ? "e" : "2");
        }
    }
}