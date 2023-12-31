using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        
        List<int> numList = num_list.ToList();
        numList.Sort();
        numList.RemoveRange(0, 5);
        answer = numList.ToArray();
        
        return answer;
    }
}