using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        
        char[] myChar = myString.ToCharArray();

        for (int i = 0; i < myChar.Length; i++)
        {
            myChar[i] = (myChar[i] <= 'l') ? 'l' : myChar[i];
        }

        answer = string.Concat(myChar);
        return answer;
    }
}