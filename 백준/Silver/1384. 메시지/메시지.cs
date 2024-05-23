namespace _1384
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCnt = 1;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    return;
                }

                string[] students = new string[n];
                string[][] messages = new string[n][];

                for (int i = 0; i < n; i++)
                {
                    string[] inputs = Console.ReadLine().Split(' ');
                    students[i] = inputs[0];
                    messages[i] = new string[inputs.Length - 1];
                    Array.Copy(inputs, 1, messages[i], 0, inputs.Length - 1);
                }

                List<string> nastyMessages = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < messages[i].Length; j++)
                    {
                        if (messages[i][j] == "N")
                        {
                            int targetIdx = (i - j - 1 + n) % n;
                            nastyMessages.Add($"{students[targetIdx]} was nasty about {students[i]}");
                        }
                    }
                }

                Console.WriteLine($"Group {groupCnt}");
                if (nastyMessages.Count > 0)
                {
                    foreach (string message in nastyMessages)
                    {
                        Console.WriteLine(message);
                    }
                }
                else
                {
                    Console.WriteLine("Nobody was nasty");
                }

                Console.WriteLine();
                groupCnt++;
            }
        }
    }
}