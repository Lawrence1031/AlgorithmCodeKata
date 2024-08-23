namespace _7602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int machineCnt = 1;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    return;
                }

                int[] levels = new int[n];
                for (int i = 0; i < n; i++)
                {
                    levels[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Machine {machineCnt}");
                List<string> members = new List<string>();
                int memberCnt = 0;

                while (true)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    if (inputs[0] == "#" && inputs[1] == "0")
                    {
                        break;
                    }

                    string name = inputs[0];
                    members.Add(name);
                    int times = int.Parse(inputs[1]);
                    int usedEnergy = 0;

                    for (int i = 0; i < times; i++)
                    {
                        string[] data = Console.ReadLine().Split(' ');
                        int level = int.Parse(data[0]);
                        int cnt = int.Parse(data[1]);

                        usedEnergy += levels[level - 1] * cnt;
                    }

                    Console.WriteLine($"{members[memberCnt]} {usedEnergy}");
                    memberCnt++;
                }

                machineCnt++;
            }
        }
    }
}