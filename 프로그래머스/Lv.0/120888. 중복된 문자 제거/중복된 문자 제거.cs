using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        HashSet<char> charSet = new HashSet<char>(my_string);
        
        answer = string.Join("", charSet);
        
        return answer;
    }
}