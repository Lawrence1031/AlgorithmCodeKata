using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        List<int> countList = array.ToList();
        
        answer = countList.Where(num => num == n).Count();
        return answer;
    }
}