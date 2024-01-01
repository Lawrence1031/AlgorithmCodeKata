using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        
        for (int i = 0; i < my_strings.Length; i++)
        {
            int startInt = parts[i, 0];
            int endInt = parts[i, 1];
            
            answer += my_strings[i].Substring(startInt, endInt - startInt + 1);
        }
        
        return answer;
    }
}