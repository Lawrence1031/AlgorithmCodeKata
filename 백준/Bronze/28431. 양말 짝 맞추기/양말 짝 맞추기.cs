namespace _28431
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> socks = new Dictionary<int, int>();

            for (int i = 0; i < 5; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (socks.ContainsKey(input))
                {
                    socks[input]++;
                }
                else
                {
                    socks.Add(input, 1);
                }
            }

            foreach (var sock in socks)
            {
                if (sock.Value % 2 == 1)
                {
                    Console.WriteLine(sock.Key);
                }
            }
        }
    }
}