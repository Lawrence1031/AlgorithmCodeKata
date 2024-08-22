namespace _5567
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            List<int>[] connections = new List<int>[n + 1];
            for (int i = 0; i <= n; i++)
            {
                connections[i] = new List<int>();
            }

            for (int i = 0; i < m; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                connections[a].Add(b);
                connections[b].Add(a);
            }

            bool[] invited = new bool[n + 1];
            int cnt = 0;

            foreach (int friend in connections[1])
            {
                if (!invited[friend])
                {
                    invited[friend] = true;
                    cnt++;
                }

                foreach (int friendFriend in connections[friend])
                {
                    if (!invited[friendFriend] && friendFriend != 1)
                    {
                        invited[friendFriend] = true;
                        cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}