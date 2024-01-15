using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] myChar = my_string.ToCharArray();
        
        for (int i = 0; i < myChar.Length; i++)
        {
            if (Char.IsUpper(myChar[i]))
            {
                myChar[i] = Char.ToLower(myChar[i]);
            }
        }
        
        Array.Sort(myChar);
        answer = new string(myChar);
        return answer;
    }
}