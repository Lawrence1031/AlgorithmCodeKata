using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        char targetChar = Convert.ToChar(letter);
        
        List<char> myList = my_string.ToList();
        
        myList.RemoveAll(c => c == targetChar);
        
        answer = string.Concat(myList);
        return answer;
    }
}