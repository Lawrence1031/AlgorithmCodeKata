namespace _29730
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> study = new List<string>();
            List<string> coding = new List<string>();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (input.Contains("boj.kr"))
                {
                    coding.Add(input);
                }
                else
                {
                    study.Add(input);
                }
            }

            var sortedStudy = study.OrderBy(x => x.Length)
                                   .ThenBy(x => x).ToList();
            var sortedCoding = coding.OrderBy(x => x.Length)
                                   .ThenBy(x => x).ToList();

            foreach (string str in sortedStudy)
            {
                Console.WriteLine(str);
            }

            foreach (string str in sortedCoding)
            {
                Console.WriteLine(str);
            }
        }
    }
}