using System.Text;

namespace _3048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string arr1 = Console.ReadLine();
            string arr2 = Console.ReadLine();
            int t = int.Parse(Console.ReadLine());

            List<(char, int)> ants = new List<(char, int)>();
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                ants.Add((arr1[i], 1));
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                ants.Add((arr2[i], -1));
            }

            for (int time = 0; time < t; time++)
            {
                for (int i = 0; i < ants.Count - 1; i++)
                {
                    if (ants[i].Item2 == 1 && ants[i + 1].Item2 == -1)
                    {
                        var temp = ants[i];
                        ants[i] = ants[i + 1];
                        ants[i + 1] = temp;

                        i++;
                    }
                }
            }
            
            StringBuilder sb = new StringBuilder();
            foreach (var ant in ants)
            {
                sb.Append(ant.Item1);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}