using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(Console.OpenStandardInput());
        StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
        StringBuilder sb = new StringBuilder();
        int[] counts = new int[10001];
        int N = int.Parse(reader.ReadLine());

        for (int i = 0; i < N; i++)
        {
            counts[int.Parse(reader.ReadLine())]++;
        }

        for (int i = 1; i <= 10000; i++)
        {
            if (counts[i] > 0)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    sb.AppendLine(i.ToString());
                    if (sb.Length > 500)
                    {
                        writer.Write(sb.ToString());
                        sb.Clear();
                    }
                }
            }
        }
        writer.Write(sb.ToString());

        reader.Close();
        writer.Close();
    }
}
