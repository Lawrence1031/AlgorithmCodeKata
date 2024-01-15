using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        
        string[] mos = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        foreach (string str in letter.Split(" "))
        {
            answer += Convert.ToChar(Array.IndexOf(mos, str) + 97);
        }
        
        return answer;
    }
}