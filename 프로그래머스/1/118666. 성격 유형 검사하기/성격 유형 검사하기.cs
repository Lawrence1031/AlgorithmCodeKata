using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        Dictionary<char, int> testChar = new Dictionary<char, int>
        {
            { 'R', 0 },
            { 'T', 0 },
            { 'C', 0 },
            { 'F', 0 },
            { 'J', 0 },
            { 'M', 0 },
            { 'A', 0 },
            { 'N', 0 }
        };

        for (int i = 0; i < survey.Length; i++)
        {
            CheckScore(survey[i], choices[i], testChar);
        }

        answer += (testChar['R'] >= testChar['T']) ? 'R' : 'T';
        answer += (testChar['C'] >= testChar['F']) ? 'C' : 'F';
        answer += (testChar['J'] >= testChar['M']) ? 'J' : 'M';
        answer += (testChar['A'] >= testChar['N']) ? 'A' : 'N';

        return answer;
    }

    static void CheckScore(string str, int score, Dictionary<char, int> testChar)
    {
        char[] text = str.ToCharArray();
        char key1 = text[0];
        char key2 = text[1];

        // score 1이면 왼쪽이 3점, 3이면 왼쪽이 1점, 4면 0점, 5면 오른쪽이 1점, 7이면 오른쪽이 3점

        if (score <= 4)
        {
            testChar[key1] += (4 - score);
        }
        else if (score > 4)
        {
            testChar[key2] += (score - 4);
        }
    }
}