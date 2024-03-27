using System;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        
        int cnt = 0;

        while (cnt < 3)
        {
            for (int j = 1; j <= rank.Length; j++)
            {
                for (int i = 0; i < rank.Length; i++)
                {
                    if (rank[i] == j && attendance[i])
                    {
                        if (cnt == 0)
                        {
                            answer += 10000 * i;
                        }
                        else if (cnt == 1)
                        {
                            answer += 100 * i;
                        }
                        else if (cnt == 2)
                        {
                            answer += i;
                        }
                        cnt++;
                    }
                }
            }
        }
        return answer;
    }
}