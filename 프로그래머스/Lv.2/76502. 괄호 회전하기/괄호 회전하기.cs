using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int solution(string s) {
        int answer = 0;
            var sb = new StringBuilder(s);
        
        if (s.Length % 2 == 1)
        {
            return answer;
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (RigthBracket(sb.ToString()))
                {
                    answer++;
                }

                sb.Append(sb[0]);
                sb.Remove(0, 1);
            }

            return answer;
        }
    }

    private static bool RigthBracket(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == ']' || ch == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char openBracket = stack.Pop();

                if ((ch == ')' && openBracket != '(') ||
                    (ch == ']' && openBracket != '[') ||
                    (ch == '}' && openBracket != '{'))
                {
                    return false;
                }
            }
        }

        return true;
    }
}