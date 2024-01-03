using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        char[] myChar = myString.ToCharArray();
        string checkString = "";

        for (int i = 0; i < myChar.Length; i++)
        {
            checkString += (myChar[i] <= 'A') ? 'B' : 'A';
        }

        if (checkString.Contains(pat))
            answer = 1;
        
        return answer;
    }
}