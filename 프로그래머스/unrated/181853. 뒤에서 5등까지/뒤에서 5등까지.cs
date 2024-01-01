using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[5];

        List<int> numList = num_list.ToList();

        numList.Sort();

        for (int i = 0; i < 5; i++)
        {
            answer[i] = numList[i];
        }
        
        return answer;
    }
}