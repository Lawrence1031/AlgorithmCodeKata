using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] sChar = s.ToCharArray();
        List<char> sList = sChar.ToList();
        
        for (int i = 0; i < sChar.Length; i++)
        {
            for (int j = i + 1; j < sChar.Length; j++)
            {
                if (sChar[i] == sChar[j])
                {
                    sList.Remove(sChar[i]);
                    sList.Remove(sChar[j]);
                }
            }
        }
        
        sList.Sort();
        
        answer = String.Join("", sList.ToArray());
        
        return answer;
    }
}