namespace _25206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double cnt = 0;

            for (int i = 0; i < 20; i++)
            {
                string input = Console.ReadLine();
                string[] ss = input.Split(' ');
                double score = double.Parse(ss[1]);
                string grade = ss[2];
                double num = 0;

                switch (grade)
                {
                    case "A+": num = 4.5; break;
                    case "A0": num = 4.0; break;
                    case "B+": num = 3.5; break;
                    case "B0": num = 3.0; break;
                    case "C+": num = 2.5; break;
                    case "C0": num = 2.0; break;
                    case "D+": num = 1.5; break;
                    case "D0": num = 1.0; break;
                    case "F": num = 0.0; break;
                    case "P": continue;
                }

                result += score * num;
                cnt += score;
            }

            Console.WriteLine((result / cnt).ToString("F6"));
        }
    }
}