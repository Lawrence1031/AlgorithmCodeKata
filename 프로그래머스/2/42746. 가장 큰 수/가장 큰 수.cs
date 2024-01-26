using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] numbers) {
        string answer = "";
        
        string[] numStrings = Array.ConvertAll(numbers, x => x.ToString());

        Array.Sort(numStrings, (x, y) => (y + x).CompareTo(x + y));

        answer = string.Join("", numStrings);
        
        if (answer[0] == '0')
            answer = "0";
        
        return answer;
    }
}