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
                if (CanBabble(babble.Substring(s.Length), str))
                    return true;
            }
        }

        return false;
}
}