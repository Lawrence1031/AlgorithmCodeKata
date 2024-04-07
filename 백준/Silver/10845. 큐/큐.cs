using System.Text;

namespace _10845
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;
            List<string> queueList = new List<string>();
            StringBuilder sb = new StringBuilder();

            while (cnt < N)
            {
                string s = Console.ReadLine();
                int length = queueList.Count - 1;

                if (s == "pop")
                {
                    if (queueList.Count == 0)
                    {
                        sb.AppendLine("-1");
                    }
                    else
                    {
                        sb.AppendLine(queueList[0]);
                        queueList.RemoveAt(0);
                    }
                }
                else if (s == "size")
                {
                    sb.AppendLine(queueList.Count.ToString());
                }
                else if (s == "empty")
                {
                    if (queueList.Count == 0)
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
                    if (queueList.Count > 0)
                    {
                        sb.AppendLine(queueList[0]);
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else if (s == "back")
                {
                    if (queueList.Count > 0)
                    {
                        sb.AppendLine(queueList[length]);
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else
                {
                    string[] ss = s.Split(' ');
                    queueList.Add(ss[1]);
                }
                cnt++;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}