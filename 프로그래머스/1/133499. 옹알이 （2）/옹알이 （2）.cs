using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        
        string[] str = { "aya", "ye", "woo", "ma" };
        foreach (string babble in babbling)
        {
            if (CanBabble(babble, str))
            {
                answer++;
            }
        }
        
        return answer;
    }
    
    static bool CanBabble(string babble, string[] str)
    {
        if (babble.Length == 0)
        {
            return true;
        }

        foreach (var s in str)
        {
            if (babble.StartsWith(s))
            {
                if (CanBabbleNotSame(babble.Substring(s.Length), str, s))
                {
                    return true;
                }
            }
        }

        return false;
    }

    static bool CanBabbleNotSame(string babble, string[] str, string s)
    {
        if (babble.Length == 0)
        {
            return true;
        }

        foreach (var b in str)
        {
            if (babble.StartsWith(b) && b != s)
            {
                if (CanBabbleNotSame(babble.Substring(b.Length), str, b))
                {
                    return true;
                }
            }
        }

        return false;
    }
}