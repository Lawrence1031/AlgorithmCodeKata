using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        
        int oneCnt = 0;
        int twoCnt = 0;
        int threeCnt = 0;
        List<int> result = new List<int>(); 
        
        int[] oneCotae = new int[answers.Length];
        int[] twoCotae = new int[answers.Length];
        int[] threeCotae = new int[answers.Length];

        for (int i = 0; i < answers.Length; i++)
        {
            if (i % 5 == 0)
                oneCotae[i] = 1;
            else if (i % 5 != 0)
                oneCotae[i] = (i % 5) + 1;
        }

        for (int i = 0; i < answers.Length; i++)
        {

            if (i % 2 == 0)
                twoCotae[i] = 2;
            else if (i % 8 == 1)
                twoCotae[i] = 1;
            else if (i % 8 == 3)
                twoCotae[i] = 3;
            else if (i % 8 == 5)
                twoCotae[i] = 4;
            else if (i % 8 == 7)
                twoCotae[i] = 5;
        }

        for (int i = 0; i < answers.Length;i++)
        {
            if (i % 10 == 0 || i % 10 == 1)
                threeCotae[i] = 3;
            else if (i % 10 == 2 || i % 10 == 3)
                threeCotae[i] = 1;
            else if (i % 10 == 4 || i % 10 == 5)
                threeCotae[i] = 2;
            else if (i % 10 == 6 || i % 10 == 7)
                threeCotae[i] = 4;
            else if (i % 10 == 8 || i % 10 == 9)
                threeCotae[i] = 5;
        }


        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == oneCotae[i])
                oneCnt++;
            if (answers[i] == twoCotae[i])
                twoCnt++;
            if (answers[i] == threeCotae[i])
                threeCnt++;
        }

        int Maxnum = Math.Max(Math.Max(oneCnt, twoCnt), threeCnt);

        if (Maxnum == oneCnt)
        {
            if (oneCnt == twoCnt && oneCnt == threeCnt)
                result.AddRange(new int[] { 1, 2, 3 });
            else if (oneCnt == twoCnt)
                result.AddRange(new int[] { 1, 2 });
            else if (oneCnt == threeCnt)
                result.AddRange(new int[] { 1, 3 });
            else
                result.Add(1);
        }
        else if (Maxnum == twoCnt)
        {
            if (twoCnt == threeCnt)
                result.AddRange(new int[] { 2, 3 });
            else
                result.Add(2);
        }
        else
            result.Add(3);

        answer = result.ToArray();
        
        return answer;
    }
}