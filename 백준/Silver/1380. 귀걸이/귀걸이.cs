namespace _1380
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scenario = 1;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    return;
                }

                List<string> students = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    students.Add(Console.ReadLine());
                }

                Dictionary<int, int> earrings = new Dictionary<int, int>();
                for (int i = 0; i < 2 * n - 1; i++)
                {
                    int studentIdx = int.Parse(Console.ReadLine().Split(' ')[0]);

                    if (earrings.ContainsKey(studentIdx))
                    {
                        earrings[studentIdx]++;
                    }
                    else
                    {
                        earrings[studentIdx] = 1;
                    }
                }

                foreach (var item in earrings)
                {
                    if (item.Value == 1)
                    {
                        Console.WriteLine($"{scenario} {students[item.Key - 1]}");
                        break;
                    }
                }

                scenario++;
            }
        }
    }
}