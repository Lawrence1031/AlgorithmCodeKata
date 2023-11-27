using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int cnt = score.Length / m;

        Array.Sort(score);
        Array.Reverse(score);

        for (int i = 0; i < cnt; i++)
        {
            answer += score[(m * (i + 1)) - 1] * m;
        }         

        return answer;
    }
}