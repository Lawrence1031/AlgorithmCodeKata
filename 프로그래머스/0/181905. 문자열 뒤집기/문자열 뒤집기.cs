using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        
        // 인덱스 s부터 e까지를 뒤집기.        

        string reversedPart = new string(my_string.Substring(s, e - s + 1).Reverse().ToArray());
        
        answer = my_string.Substring(0, s) + reversedPart + my_string.Substring(e + 1);
        
        return answer;
    }
}