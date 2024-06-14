using System.Text;

namespace _9850
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 26; i++)
            {
                foreach (char c in input)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        char alp = (char)(c - i);
                        if (alp < 'A')
                        {
                            alp = (char)(alp + 26);
                        }
                        sb.Append(alp);
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }

                string answer = sb.ToString();
                if (answer.Contains("CHIPMUNKS") && answer.Contains("LIVE"))
                {
                    Console.WriteLine(answer);
                    return;
                }
                else
                {
                    sb.Clear();
                }
            }
        }
    }
}