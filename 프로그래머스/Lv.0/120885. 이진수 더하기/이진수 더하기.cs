using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        
        int b1 = Convert.ToInt32(bin1, 2);
        int b2 = Convert.ToInt32(bin2, 2);
        
        answer = Convert.ToString(b1 + b2, 2);
        
        return answer;
    }
}