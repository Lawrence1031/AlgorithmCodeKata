using System.Text;

namespace _10866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;
            List<string> deckList = new List<string>();
            StringBuilder sb = new StringBuilder();

            while (cnt < N)
            {
                string s = Console.ReadLine();
                int length = deckList.Count - 1;

                if (s == "pop_front")
                {
                    if (deckList.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(deckList[0]);
                        deckList.RemoveAt(0);
                    }
                }
                else if (s == "pop_back")
                {
                    if (deckList.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(deckList[length]);
                        deckList.RemoveAt(length);
                    }
                }
                else if (s == "size")
                {
                    sb.AppendLine(deckList.Count.ToString());
                }
                else if (s == "empty")
                {
                    if (deckList.Count == 0)
                    {
                        sb.AppendLine("1");
                    }
                    else
                    {
                        sb.AppendLine("0");
                    }
                }
                else if (s == "front")
                {
                    if (deckList.Count > 0)
                    {
                        sb.AppendLine(deckList[0]);
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else if (s == "back")
                {
                    if (deckList.Count > 0)
                    {
                        sb.AppendLine(deckList[length]);
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else
                {
                    string[] ss = s.Split(' ');
                    if (ss[0] == "push_back")
                    {
                        deckList.Add(ss[1]);
                    }
                    else
                    {
                        deckList.Insert(0, ss[1]);
                    }
                }
                cnt++;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}