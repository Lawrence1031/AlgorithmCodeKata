using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        
        char[] myStringChar = myString.ToCharArray();
        
        for (int i = 0; i < myStringChar.Length; i++)
        {
            if (myStringChar[i] == 'a' || myStringChar[i] == 'A')
                myStringChar[i] = char.ToUpper(myStringChar[i]);
            else
                myStringChar[i] = char.ToLower(myStringChar[i]);
        }
        
        answer = new string(myStringChar);
        
        return answer;
    }
}