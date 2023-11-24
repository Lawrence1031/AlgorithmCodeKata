using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        
        List<string> str1 = new List<string>(cards1);
        List<string> str2 = new List<string>(cards2);
        List<string> goalList = new List<string>(goal);
        
        while (goalList.Count > 0)
        {
            if (str1.Count == 0 && str2.Count == 0)
            {
                answer = "No";
                break;
            }
            if (goalList.Count > 0)
            {
                if (str1.Count > 0 && goalList[0] == str1[0])
                {
                    goalList.RemoveAt(0);
                    str1.RemoveAt(0);
                }
                else if (str2.Count > 0 && goalList[0] == str2[0])
                {
                    goalList.RemoveAt(0);
                    str2.RemoveAt(0);
                }
                else
                {
                    answer = "No";
                    break;
                }
            }
        }
        
        return answer;
    }
}