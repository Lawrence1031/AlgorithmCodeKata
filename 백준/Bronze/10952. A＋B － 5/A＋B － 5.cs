namespace _10952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";

            while ((s = Console.ReadLine()) != "0 0")
            {
                string[] ss = s.Split(" ");
                int a = Convert.ToInt32(ss[0]);
                int b = Convert.ToInt32(ss[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}