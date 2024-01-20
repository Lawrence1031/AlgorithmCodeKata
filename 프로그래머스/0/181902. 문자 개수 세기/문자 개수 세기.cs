using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = CountAlp(my_string);
        return answer;
    }
    
    public static int[] CountAlp(string input)
    {
        int[] counts = new int[52];
        
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                int index = c - 'A';
                counts[index]++;
            }
            else
            {
                int index = 26 + c - 'a';
                counts[index]++;
            }
        }
        
        return counts;
    }
}