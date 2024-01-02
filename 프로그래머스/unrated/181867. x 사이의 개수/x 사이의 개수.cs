using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        int[] answer = new int[] {};
        
        char[] myStringChar = myString.ToCharArray();
        List<int> resultList = new List<int> ();
        int tmp = 0;
        
        for (int i = 0; i < myStringChar.Length; i++)
        {
            if (myStringChar[i] == 'x')
            {
                resultList.Add(tmp);
                tmp = 0;
            }
            else
            {
                tmp++;
            }
            
            if (i == myStringChar.Length - 1)
                resultList.Add(tmp);
            
        }
        
        answer = resultList.ToArray();
        
        return answer;
    }
}