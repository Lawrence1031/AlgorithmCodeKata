using System;
using System.Linq;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        
        char[] inputChar = rsp.ToCharArray();
        char[] outputChar = new char[inputChar.Length];
        
        for (int i = 0; i < inputChar.Length; i++)
        {
            if (inputChar[i] == '0')
                outputChar[i] = '5';
            else if (inputChar[i] == '2')
                outputChar[i] = '0';
            else if (inputChar[i] == '5')
                outputChar[i] = '2';
        }
        
        answer = new string(outputChar);
        
        return answer;
    }
}