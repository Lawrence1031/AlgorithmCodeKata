using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[] {};
        
        List<string> strList = new List<string> ();
        
        for (int i = 0; i < strArr.Length; i++)
        {
            if (!strArr[i].Contains("ad"))
                strList.Add(strArr[i]);
        }
        
        answer = strList.ToArray();
        
        return answer;
    }
}