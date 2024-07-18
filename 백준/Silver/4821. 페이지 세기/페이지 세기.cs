namespace _4821
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int totalPages = int.Parse(Console.ReadLine());
                if (totalPages == 0)
                {
                    return;
                }

                bool[] printPages = new bool[totalPages + 1];
                string[] inputs = Console.ReadLine().Split(',');
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (inputs[i].Contains('-'))
                    {
                        string[] range = inputs[i].Split('-');
                        int startPage = int.Parse(range[0]);
                        int endPage = int.Parse(range[1]);

                        if (startPage > endPage)
                        {
                            continue;
                        }

                        for (int j = Math.Max(1, startPage); j <= Math.Min(totalPages, endPage); j++)
                        {
                            printPages[j] = true;
                        }
                    }
                    else
                    {
                        int page = int.Parse(inputs[i]);
                        if (page >= 1 && page <= totalPages)
                        {
                            printPages[page] = true;
                        }
                    }
                }

                int cnt = 0;
                for (int i = 0; i <= totalPages; i++)
                {
                    if (printPages[i]) cnt++;
                }
                Console.WriteLine(cnt);
            }
        }
    }
}