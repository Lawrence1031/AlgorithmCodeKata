namespace _1940
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[] materials = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> set = new HashSet<int>();
            int cnt = 0;

            foreach (int material in materials)
            {
                int number = M - material;
                if (set.Contains(number))
                {
                    cnt++;
                }
                set.Add(material);
            }

            Console.WriteLine(cnt);
        }
    }
}