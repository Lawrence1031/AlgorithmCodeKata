namespace _1718
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = Console.ReadLine();

            char[] result = new char[input.Length];
            int keyIdx = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char curChar = input[i];

                if (curChar == ' ')
                {
                    result[i] = ' ';
                    keyIdx = (keyIdx + 1) % key.Length;
                }
                else
                {
                    int keyShift = key[keyIdx] - 'a';
                    int newChar = curChar - keyShift - 1;

                    if (newChar < 'a')
                    {
                        newChar += 26;
                    }

                    result[i] = (char)newChar;

                    keyIdx = (keyIdx + 1) % key.Length;
                }
            }

            Console.WriteLine(new String(result));
        }
    }
}