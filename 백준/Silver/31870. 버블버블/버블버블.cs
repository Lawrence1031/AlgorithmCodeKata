namespace _31870
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sortCnt = SortCnt(arr);
            int reverseCnt = ReverseSortCnt(arr);

            Console.WriteLine(Math.Min(sortCnt, reverseCnt));

        }

        static int SortCnt(int[] arr)
        {
            int[] tmpArr = (int[])arr.Clone();
            int cnt = 0;
            int n = tmpArr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tmpArr[j] > tmpArr[j + 1])
                    {
                        int tmp = tmpArr[j];
                        tmpArr[j] = tmpArr[j + 1];
                        tmpArr[j + 1] = tmp;

                        cnt++;
                    }
                }
            }


            return cnt;
        }

        static int ReverseSortCnt(int[] arr)
        {
            int[] tmpArr = (int[])arr.Clone();
            int cnt = 0;
            int n = tmpArr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tmpArr[j] < tmpArr[j + 1])
                    {
                        int tmp = tmpArr[j];
                        tmpArr[j] = tmpArr[j + 1];
                        tmpArr[j + 1] = tmp;

                        cnt++;
                    }
                }
            }

            return cnt + 1;
        }
    }
}