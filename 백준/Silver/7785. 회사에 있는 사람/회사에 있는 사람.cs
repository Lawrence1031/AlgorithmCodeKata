using System.Text;

namespace _7785
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, bool> commute = new Dictionary<string, bool>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                bool condition = input[1] == "enter";

                if (condition)
                {
                    commute[name] = true;
                }
                else
                {
                    commute.Remove(name);
                }
            }

            List<string> inWork = new List<string>();
            foreach (var person in commute)
            {
                if (person.Value)
                {
                    inWork.Add(person.Key);
                }
            }

            inWork.Sort();
            inWork.Reverse();

            foreach (var item in inWork)
            {
                sb.AppendLine(item);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}