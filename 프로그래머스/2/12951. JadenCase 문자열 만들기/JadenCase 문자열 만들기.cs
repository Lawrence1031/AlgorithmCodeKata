using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] words = s.Split(' ');
        
        for (int i = 0; i < words.Length; i++) {
            if (words[i].Length > 0) {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }

        answer = string.Join(" ", words);
        
        return answer;

    }

    static bool IsLowerChar(char c)
    {
        return (c >= 'a' && c <= 'z');
    }

    static bool IsUpperChar(char c)
    {
        return(c >= 'A' && c <= 'Z');
    }
}