using System.Text;

namespace _14569
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            List<HashSet<int>> courses = new List<HashSet<int>>();

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int k = int.Parse(inputs[0]);
                HashSet<int> courseTime = new HashSet<int>();

                for (int j = 1; j <= k; j++)
                {
                    courseTime.Add(int.Parse(inputs[j]));
                }
                courses.Add(courseTime);
            }

            int M = int.Parse(Console.ReadLine());
            List<int> results = new List<int>();

            for (int i = 0; i < M; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int p = int.Parse(inputs[0]);
                HashSet<int> freeTime = new HashSet<int>();
                
                for (int j = 1; j <= p; j++)
                {
                    freeTime.Add(int.Parse(inputs[j]));
                }

                int cnt = 0;
                foreach (var course in courses)
                {
                    if (course.IsSubsetOf(freeTime))
                    {
                        cnt++;
                    }
                }
                results.Add(cnt);
            }

            foreach (var result in results)
            {
                sb.AppendLine(result.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}