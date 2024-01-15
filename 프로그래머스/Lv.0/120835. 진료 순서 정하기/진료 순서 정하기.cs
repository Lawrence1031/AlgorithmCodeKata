using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        
        int[] sortedArr = new int[emergency.Length];
        emergency.CopyTo(sortedArr, 0);
        
        var sortedIndex = sortedArr.Select((value, index) => new {value, index})
            .OrderByDescending(x => x.value).ToArray();
        
        for (int i = 0; i < sortedIndex.Length; i++)
        {
            answer[sortedIndex[i].index] = i + 1;
        }
        
        return answer;
    }
}