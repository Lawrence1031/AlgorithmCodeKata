namespace _4493
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int cnt = 0;

                for (int j = 0; j < n; j++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    string a = inputs[0];
                    string b = inputs[1];

                    cnt += Battle(a, b);
                }

                if (cnt == 0)
                {
                    Console.WriteLine("TIE");
                }
                else if (cnt > 0)
                {
                    Console.WriteLine("Player 1");
                }
                else
                {
                    Console.WriteLine("Player 2");
                }
            }
        }

        static int Battle(string a, string b)
        {
            int cnt = 0;

            if (a == "R" && b == "P")
            {
                cnt--;
            }
            else if (a == "R" && b == "S")
            {
                cnt++;
            }
            else if (a == "P" && b == "R")
            {
                cnt++;
            }
            else if (a == "P" && b == "S")
            {
                cnt--;
            }
            else if (a == "S" && b == "R")
            {
                cnt--;
            }
            else if (a== "S" && b == "P")
            {
                cnt++;
            }

            return cnt;
        }
    }
}