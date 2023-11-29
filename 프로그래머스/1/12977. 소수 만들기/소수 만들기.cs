using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = -1;
        int cnt = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int tmp = nums[i] + nums[j] + nums[k];

                    if (IsPrime(tmp))
                    {
                        cnt++;
                    }
                }                    
            }
        }
        
        answer = cnt;

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        System.Console.WriteLine("Hello C#");

        return answer;
    }
    
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}