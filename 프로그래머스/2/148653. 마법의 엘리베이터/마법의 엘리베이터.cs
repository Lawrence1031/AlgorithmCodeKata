using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int storey) {
        int answer = 0;
        List<int> intList = storey.ToString()
                                .Select(i => int.Parse(i.ToString()))
                                .ToList();

        intList.Reverse();

        for (int i = 0; i < intList.Count; i++)
        {
            if (intList[i] >= 1 && intList[i] <= 4)
            {
                answer += intList[i];
            }
            else if (intList[i] >= 6)
            {
                answer += (10 - intList[i]);

                if (i + 1 < intList.Count)
                {
                    intList[i + 1]++;
                }
                else
                {
                    answer++;
                }
            }
            else if (intList[i] == 5)
            {
                answer += intList[i];

                if (i + 1 < intList.Count && intList[i + 1] >= 5)
                {
                    intList[i + 1]++;
                }
            }
        }
        
        return answer;
    }
}