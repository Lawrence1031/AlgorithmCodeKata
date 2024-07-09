namespace _15182
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] data = new int[N][];

            for (int i = 0; i < N; i++)
            {
                data[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            int[] parityByte = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string prityType = DetermineParityType(data[0]);
            Console.WriteLine(prityType);

            int brokenByteIndex = FindBrokenByte(data, prityType);
            Console.WriteLine($"Byte {brokenByteIndex + 1} is broken");

            int brokenBitIndex = FindBrokenBit(data, parityByte, prityType);
            Console.WriteLine($"Bit {brokenBitIndex + 1} is broken");
        }

        static string DetermineParityType(int[] data)
        {
            int cnt = data.Count(bit => bit == 1);
            return (cnt % 2 == 0) ? "Even" : "Odd";
        }

        static int FindBrokenByte(int[][] data, string parityType)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int cnt = data[i].Count(bit => bit == 1);
                if ((parityType == "Even" && cnt % 2 != 0) ||
                    (parityType == "Odd" && cnt % 2 == 0))
                {
                    return i;
                }
            }
            return -1;
        }

        static int FindBrokenBit(int[][] data, int[] parityByte, string parityType)
        {
            for (int i = 0; i < 8; i++)
            {
                int cnt = parityByte[i];
                for (int j = 0; j < data.Length; j++)
                {
                    cnt += data[j][i];
                }

                if ((parityType == "Even" && cnt % 2 != 0) ||
                    (parityType == "Odd" && cnt % 2 == 0))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}