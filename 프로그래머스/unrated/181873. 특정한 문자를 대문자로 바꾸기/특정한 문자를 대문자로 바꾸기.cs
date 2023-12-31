using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        char alpChar = Convert.ToChar(alp);

        foreach (char chr in my_string)
        {
            if (chr == alpChar)
                answer += char.ToUpper(chr);
            else
                answer += chr;
        }
        
        return answer;
    }
}