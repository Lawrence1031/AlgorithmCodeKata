using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;

        Dictionary<string, int> clothesDict = new Dictionary<string, int>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            if (clothesDict.ContainsKey(type))
            {
                clothesDict[type]++;
            }
            else
            {
                clothesDict.Add(type, 1);
            }
        }

        foreach (var item in clothesDict)
        {
            answer *= (item.Value + 1);
        }

        answer--;
        return answer;
    }
}