namespace _28691
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "M": Console.WriteLine("MatKor"); break;
                case "W": Console.WriteLine("WiCys"); break;
                case "C": Console.WriteLine("CyKor"); break;
                case "A": Console.WriteLine("AlKor"); break;
                case "$": Console.WriteLine("$clear"); break;
                default: Console.WriteLine("input Error"); break;
            }
        }
    }
}