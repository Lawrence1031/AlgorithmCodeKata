using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        myString = myString.ToUpper();
        pat = pat.ToUpper();
        
        if (myString.Contains(pat))
            answer = 1;
        
        return answer;
    }
}