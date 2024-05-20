namespace _1524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = Console.ReadLine().Split(' ');
                int N = int.Parse(inputs[0]);
                int M = int.Parse(inputs[1]);
                List<int> sejoon = new List<int>();
                List<int> sebi = new List<int>();

                string[] sejoons = Console.ReadLine().Split(' ');
                for (int j = 0; j < sejoons.Length; j++)
                {
                    sejoon.Add(int.Parse(sejoons[j]));
                }

                string[] sebis = Console.ReadLine().Split(' ');
                for (int j = 0; j < sebis.Length; j++)
                {
                    sebi.Add(int.Parse(sebis[j]));
                }

                int sejoonMax = sejoon.Max();
                int sebiMax = sebi.Max();
                string answer = sejoonMax >= sebiMax ? "S" : "B";
                Console.WriteLine(answer);
            }
        }
    }
}