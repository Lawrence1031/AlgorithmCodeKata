namespace _31428
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] strs = Console.ReadLine().Split(' ').ToArray();
            string alice = Console.ReadLine();

            int cnt = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == alice) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}