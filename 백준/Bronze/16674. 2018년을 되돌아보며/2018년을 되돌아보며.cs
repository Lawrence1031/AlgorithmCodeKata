namespace _16674
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = new int[input.Length];
            int zeroCnt = 0;
            int oneCnt = 0;
            int twoCnt = 0;
            int eightCnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i].ToString());
                if (nums[i] != 2 && nums[i] != 0 && nums[i] != 1 && nums[i] != 8)
                {
                    Console.WriteLine(0);
                    return;
                }

                if (nums[i] == 0) zeroCnt++;
                else if (nums[i] == 1) oneCnt++;
                else if (nums[i] == 2) twoCnt++;
                else if (nums[i] == 8) eightCnt++;
            }

            if (zeroCnt == oneCnt && oneCnt == twoCnt && twoCnt == eightCnt)
            {
                Console.WriteLine(8);
            }
            else if (zeroCnt == 0 || oneCnt == 0 || twoCnt == 0 || eightCnt == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }
}