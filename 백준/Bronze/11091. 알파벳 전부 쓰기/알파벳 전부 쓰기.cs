namespace _11091
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                List<char> list = CheckAlp(input);
                
                if (list.Count == 0)
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    string rest = string.Join("", list);
                    Console.WriteLine($"missing {rest}");
                }
            }
        }

        static List<char> CheckAlp(string input)
        {
            List<char> result = new List<char>();
            input = input.ToLower();

            for (int i = 0; i < 26; i++)
            {
                result.Add((char)(i + 97));
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (result.Contains(input[i]))
                {
                    result.Remove(input[i]);
                }
            }

            return result;
        }
    }
}