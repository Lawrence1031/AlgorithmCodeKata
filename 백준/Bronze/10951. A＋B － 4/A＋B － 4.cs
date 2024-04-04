namespace _10951
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "1";
            while ((s = Console.ReadLine()) != null)
            {
                string[] ss = s.Split(' ');
                int a = int.Parse(ss[0]);
                int b = int.Parse(ss[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}