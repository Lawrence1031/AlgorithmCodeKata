using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        
        StringBuilder SB = new StringBuilder();
        Dictionary<char, int> countY = new Dictionary<char, int>();

        foreach (char y in Y)
        {
            if (countY.ContainsKey(y))
                countY[y]++;
            else
                countY[y] = 1;
        }

        foreach (char x in X)
        {
            if (countY.ContainsKey(x) && countY[x] > 0)
            {
                SB.Append(x - '0');
                countY[x]--;
            }
        }

        List<char> Result = SB.ToString().ToCharArray().ToList();
        
        Result.Sort();
        Result.Reverse();
        answer = string.Join("", Result);
        
        if (answer == "")
            answer = "-1";
        else if (answer[0] == '0')
            answer = "0";

        return answer;
        
    }
}