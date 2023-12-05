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
        
        List<int> result = reserveList.Except(lostList).ToList(); // reserveList에서 lostList를 뺀 것
        List<int> realLost = lostList.Except(reserveList).ToList(); // lostList에서 result를 뺀 것
        
        // 그림으로 나타내면, lost에만 있는 숫자 -> 체육복이 없는 학생의 번호
        // lost와 reserve에 있는 숫자 -> 체육복이 없어졌지만, 자신의 여벌을 입는 학생의 번호
        // reserve에만 있는 숫자 -> 체육복이 남아서 다른 학생에게 줄 수 있는 학생의 번호
        // -> 교집합은 그대로 뺀 뒤에, lost에만 있는 숫자를 0으로하고, reserve에서 주는 것으로 변경
        
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
