using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        
        Dictionary<int ,int> tanDic = new Dictionary<int ,int>();

        foreach (int i in tangerine)
        {
            if (tanDic.ContainsKey(i))
                tanDic[i]++;
            else
                tanDic[i] = 1;
        }

        var sortedTanDic = tanDic.OrderByDescending(x => x.Value);

        int cnt = 0;

        foreach (var num in sortedTanDic)
        {
            if (cnt < k)
            {
                cnt += num.Value;
                answer++;
            }
            else
            {
                break;
            }
        }
        
        return answer;
    }
}