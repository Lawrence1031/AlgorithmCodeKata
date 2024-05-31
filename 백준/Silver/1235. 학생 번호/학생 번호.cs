namespace _1235
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] students = new string[N];

            for (int i = 0; i < N; i++)
            {
                students[i] = Console.ReadLine();
            }

            int len = students[0].Length;
            int k = 1;

            while (true)
            {
                HashSet<string> uniqueNumbers = new HashSet<string>();

                for (int i = 0; i < N; i++)
                {
                    string number = students[i].Substring(len - k);
                    uniqueNumbers.Add(number);
                }

                if (uniqueNumbers.Count == N)
                {
                    break;
                }

                k++;
            }

            Console.WriteLine(k);
        }
    }
}