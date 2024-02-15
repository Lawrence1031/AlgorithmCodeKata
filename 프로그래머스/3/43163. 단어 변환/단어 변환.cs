using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string begin, string target, string[] words) {
        int answer = 0;
        
        Queue<(string word, int step)> queue = new Queue<(string, int)>();
        HashSet<string> visited = new HashSet<string>();
        queue.Enqueue((begin, 0));
        visited.Add(begin);

        while (queue.Count > 0)
        {
            (string curWord, int step) = queue.Dequeue();
            if (curWord == target)
            {
                answer = step;
            }

            foreach (string word in words)
            {
                if (!visited.Contains(word) && CheckWord(curWord, word))
                {
                    queue.Enqueue((word, step + 1));
                    visited.Add(word);
                }
            }
        }
        
        
        return answer;
    }
    private static bool CheckWord(string from, string to)
    {
        int diffCnt = 0;
        for (int i = 0; i < from.Length; i++)
        {
            if (from[i] != to[i])
            {
                diffCnt++;
            }
            if (diffCnt > 1)
            {
                return false;
            }
        }
        return diffCnt == 1;
    }
}