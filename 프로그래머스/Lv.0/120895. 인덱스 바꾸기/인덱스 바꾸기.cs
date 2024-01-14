using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        
        char[] myChar = my_string.ToCharArray();
        char tmpChar = myChar[num1];
        myChar[num1] = myChar[num2];
        myChar[num2] = tmpChar;
        
        answer = new string(myChar);
        
        return answer;
    }
}