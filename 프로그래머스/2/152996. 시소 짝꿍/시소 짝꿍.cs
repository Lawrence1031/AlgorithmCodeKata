using System;

public class Solution {
    public long solution(int[] weights) {
        long answer = 0;
        int cnt = 0;
        int tmpNum = 0;

        Array.Sort(weights);
        
        int[] torque = new int[weights[weights.Length - 1] * 4 + 1];

        foreach (int weight in weights)
        {
            torque[weight * 2]++;
            torque[weight * 3]++;
            torque[weight * 4]++;

            if (tmpNum == weight)
            {
                cnt++;
                answer -= cnt * 2;
            }
            else
            {
                tmpNum = weight;
                cnt = 0;
            }
        }

        foreach (int num in torque)
        {
            if (num > 1)
            {
                answer += (long)num * (num - 1) / 2;
            }
        }
        
        return answer;
    }
}
