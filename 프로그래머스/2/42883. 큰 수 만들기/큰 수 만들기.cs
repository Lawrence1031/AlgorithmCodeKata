using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string number, int k) {
        var stack = new Stack<char>();

        foreach (char c in number)
        {
            while (stack.Count > 0 && k > 0 && stack.Peek() < c)
            {
                stack.Pop();
                k--;
            }

            stack.Push(c);
        }

        var result = new StringBuilder();
        foreach (char c in stack)
        {
            if (k > 0)
            {
                k--;
                continue;
            }
            result.Append(c);
        }

        var charArr = result.ToString().ToCharArray();
        Array.Reverse(charArr);
        string answer = new string(charArr);
        
        return answer;
    }
}