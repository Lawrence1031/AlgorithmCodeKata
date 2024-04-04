namespace _5597
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= 30; i++)
            {
                list.Add(i.ToString());
            }

            int cnt = 0;
            while (cnt < 28)
            {
                string s = Console.ReadLine();
                list.Remove(s);
                cnt++;
            }
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
        }
    }
}