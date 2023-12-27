using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int center = array.Length / 2;
        
        List<int> sortList = array.ToList();
        sortList.Sort();
        answer = sortList[center];
        return answer;
    }
}