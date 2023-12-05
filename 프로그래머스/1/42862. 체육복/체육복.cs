using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();
        List<int> cnt = Enumerable.Repeat(1, n).ToList();
        
        lostList.Sort();
        reserveList.Sort();
        
        List<int> result = reserveList.Except(lostList).ToList();
        List<int> realLost = lostList.Except(reserveList).ToList();

        for (int i = 0; i < realLost.Count; i++)
        {
            cnt[realLost[i] - 1] = 0;
        }


        for (int i = 0; i < result.Count; i++)
        {
            int idx = result[i] - 1;

            if (idx - 1 >= 0 && cnt[idx - 1] == 0)
            {
                cnt[idx - 1] = 1;
            }
            else if (idx + 1 < n && cnt[idx + 1] == 0)
            {
                cnt[idx + 1] = 1;
            }
        }
        
        foreach (int i in cnt)
            {
                if (i == 1)
                    answer++;
            }
        
        return answer;
    }
}