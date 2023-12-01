using System;
using System.Linq;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int[] divisor = new int[number]; 

        for (int i = 0; i < number; i++)
        {
            divisor[i] = FindDivisor(i + 1);
        }

        for (int i = 0; i < divisor.Length; i++)
        {
            if (divisor[i] > limit)
                divisor[i] = power;
        }
        answer = divisor.Sum();
        
        return answer;
    }
    
    static int FindDivisor(int n)
    {
        int cnt = 0;

        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                cnt++;

                if (n / i != i)
                {
                    cnt++;
                }
            }
        }

        return cnt;
    }
}