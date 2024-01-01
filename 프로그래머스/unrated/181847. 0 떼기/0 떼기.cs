using System;
using System.Text;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        StringBuilder sb = new StringBuilder(n_str);
        
        while (sb.Length > 0 && sb[0] == '0')
        {
            sb.Remove(0, 1);
        }
        
        answer = sb.ToString();
        return answer;
    }
}