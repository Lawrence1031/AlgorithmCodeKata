namespace _1940
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[] materials = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int cnt = 0;
            for (int i = 0; i < materials.Length; i++)
            {
                int number = M - materials[i];
                if (materials.Contains(number))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt / 2);
        }
    }
}