namespace _25192
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                if (input == "ENTER")
                {
                    dict.Clear();
                }
                else
                {
                    if (dict.ContainsKey(input))
                    {
                        dict[input]++;
                    }
                    else
                    {
                        dict.Add(input, 1);
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}