using System.Text;

namespace _1920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 수 찾기
            // N개의 정수 A[1], A[2], ..., A[N]이 주어질 때,
            // 이 안에 X라는 정수가 존재하는지 알아내는 문제

            int N = Convert.ToInt32(Console.ReadLine());
            string[] ss = Console.ReadLine().Split(' ');
            int[] aArr = new int[N];
            
            for (int i = 0; i < aArr.Length; i++)
            {
                aArr[i] = int.Parse(ss[i]);
            }
            Array.Sort(aArr);

            int M = Convert.ToInt32(Console.ReadLine());
            ss = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < M; i++)
            {
                int num = int.Parse(ss[i]);
                sb.AppendLine(BinarySearch(aArr, num) ? "1" : "0");
            }

            Console.WriteLine(sb.ToString());
        }

        static bool BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return true;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}