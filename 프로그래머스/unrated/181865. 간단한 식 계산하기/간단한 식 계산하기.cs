using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        
        answer = Calculate(binomial);
        
        return answer;
    }

    static int Calculate(string str)
    {
        int answer = 0;

        int a = 0;
        int b = 0;

        string[] strArray = str.Split(" ");
        a = int.Parse(strArray[0]);
        b = int.Parse(strArray[2]);

        if (strArray[1] == "+")
        {
            answer = a + b;
        }
        else if (strArray[1] == "-")
        {
            answer = a - b;
        }
        else if (strArray[1] == "*")
        {
            answer = a * b;
        }

        return answer;
    }
}