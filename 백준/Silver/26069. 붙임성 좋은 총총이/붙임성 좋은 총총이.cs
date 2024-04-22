namespace _26069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> dancers = new HashSet<string> { "ChongChong" };

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string a = input[0];
                string b = input[1];

                if (dancers.Contains(a) || dancers.Contains(b))
                {
                    dancers.Add(a);
                    dancers.Add(b);
                }
            }

            Console.WriteLine(dancers.Count);
        }
    }
}