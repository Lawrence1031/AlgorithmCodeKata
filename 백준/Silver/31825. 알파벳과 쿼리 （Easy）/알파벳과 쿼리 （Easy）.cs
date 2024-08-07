namespace _31825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]);
            int Q = int.Parse(inputs[1]);
            string S = Console.ReadLine();

            Char[] charArray = S.ToCharArray();
            var queries = new List<string>();
            for (int i = 0; i < Q; i++)
            {
                queries.Add(Console.ReadLine());
            }

            foreach (var query in queries)
            {
                var parts = query.Split(' ');
                int type = int.Parse(parts[0]);
                int l = int.Parse(parts[1]) - 1;
                int r = int.Parse(parts[2]) - 1;

                if (type == 1)
                {
                    int cnt = CntAlpGroup(charArray, l, r);
                    Console.WriteLine(cnt);
                }
                else if (type == 2)
                {
                    ShiftAlp(charArray, l, r);
                }
            }
        }

        static int CntAlpGroup(char[] arr, int l, int r)
        {
            int cnt = 0;
            bool isGroup = false;
            char currentChar = '\0';

            for (int i = l; i <= r; i++)
            {
                if (!isGroup || arr[i] != currentChar)
                {
                    cnt++;
                    isGroup = true;
                    currentChar = arr[i];
                }
            }

            return cnt;
        }

        static void ShiftAlp(char[] arr, int l, int r)
        {
            for (int i = l; i <= r; i++)
            {
                arr[i] = (char)((arr[i] - 'A' + 1) % 26 + 'A');
            }
        }
    }
}