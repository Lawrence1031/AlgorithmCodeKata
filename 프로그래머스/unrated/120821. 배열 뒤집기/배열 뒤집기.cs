using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        List<int> reverseList = num_list.ToList();
        reverseList.Reverse();
        answer = reverseList.ToArray();
        return answer;
    }
}