namespace _9086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 0; i < Convert.ToInt32(s); i++)
            {
                string ss = Console.ReadLine();
                Console.Write(ss[0]);
                Console.WriteLine(ss[ss.Length - 1]);
            }
        }
    }
}