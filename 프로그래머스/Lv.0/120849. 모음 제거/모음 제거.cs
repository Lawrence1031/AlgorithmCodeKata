using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        List<char> chList = new List<char>();
        
        chList = my_string.ToList();
        chList.RemoveAll(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        
        answer = string.Join("", chList);
        
        return answer;
    }
}