using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string word) {
        int answer = 0;
        int[] weights = new int[] { 781, 156, 31, 6, 1 };
        Dictionary<char, int> charValue = new Dictionary<char, int> 
        {
            {'A', 0}, {'E', 1}, {'I', 2}, {'O', 3}, {'U', 4}
        };
        
        for (int i = 0; i < word.Length; i++)
        {
            int value = charValue[word[i]];
            answer += value * weights[i] + 1;
        }
        
        return answer;
    }
}