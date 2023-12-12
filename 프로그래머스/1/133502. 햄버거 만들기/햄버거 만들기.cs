using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> ingreList = new List<int>();

        foreach (int ingre in ingredient)
        {
            ingreList.Add(ingre);

            if(ingreList.Count >= 4)
            {
                if (ingreList[ingreList.Count - 4] == 1 
                    && ingreList[ingreList.Count - 3] == 2 
                    && ingreList[ingreList.Count - 2] == 3 
                    && ingreList[ingreList.Count - 1] == 1)
                {
                    answer++;
                    ingreList.RemoveRange(ingreList.Count - 4, 4);
                }
            }
        }

        return answer;
    }
}