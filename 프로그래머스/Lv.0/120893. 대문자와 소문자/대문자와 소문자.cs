using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char[] checkChar = my_string.ToCharArray();
        for (int i = 0; i < checkChar.Length; i++)
        {
            if (char.IsUpper(checkChar[i]))
                checkChar[i] = char.ToLower(checkChar[i]);
            else
                checkChar[i] = char.ToUpper(checkChar[i]);
        }
        
        answer = new string(checkChar);
        return answer;
    }
}