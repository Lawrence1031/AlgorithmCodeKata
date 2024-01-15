using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        var stack = new Stack<int>();
        
        string[] sStr = s.Split(' ');
        
        foreach (string str in sStr)
        {
            if (str == "Z" && stack.Count > 0)
            {
                answer -= stack.Pop();
            }
            else
            {
                int num;
                if (int.TryParse(str, out num))
                answer += num;
                stack.Push(num);
            }
        }
        
        return answer;
    }
}