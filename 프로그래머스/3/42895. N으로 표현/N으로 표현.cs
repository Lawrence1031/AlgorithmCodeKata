using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int N, int number) {
        
        if (N == number)
        {
            return 1;
        }

        List<HashSet<int>> dp = new List<HashSet<int>>();
        for (int i = 0; i <= 8; i ++)
        {
            dp.Add(new HashSet<int>());
        }

        int baseNum = 0;
        for (int i = 1; i <= 8; i++)
        {
            baseNum = 10 * baseNum + N;
            dp[i].Add(baseNum);
        }

        for (int i = 2; i <= 8; i++)
        {
            for (int j = 1; j < i; j++)
            {
                foreach (int a in dp[j])
                {
                    foreach (int b in dp[i - j])
                    {
                        dp[i].Add(a + b);
                        dp[i].Add(a - b);
                        dp[i].Add(a * b);
                        if (b != 0)
                        {
                            dp[i].Add(a / b);
                        }
                    }
                }
            }

            if (dp[i].Contains(number))
            {
                return i;
            }
        }

        return -1;
    }
}