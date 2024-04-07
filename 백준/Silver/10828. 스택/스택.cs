using System.Text;

namespace _10828
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;
            List<string> stackList = new List<string>();
            StringBuilder sb = new StringBuilder();

            while (cnt < N)
            {
                string s = Console.ReadLine();
                int length = stackList.Count - 1;

                if (s == "pop")
                {
                    if (stackList.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(stackList[length]);
                        stackList.RemoveAt(length);
                    }
                }
                else if (s == "size")
                {
                    sb.AppendLine(stackList.Count.ToString());
                }
                else if (s == "empty")
                {
                    if (stackList.Count == 0)
                    {
                        sb.AppendLine("1");
                    }
                    else
                    {
                        sb.AppendLine("0");
                    }
                }
                else if (s == "top")
                {
                    if (stackList.Count > 0)
                    {
                        sb.AppendLine(stackList[length]);
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else
                {
                    string[] ss = s.Split(' ');
                    stackList.Add(ss[1]);
                }
                cnt++;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}