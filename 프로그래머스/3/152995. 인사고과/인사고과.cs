using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] scores) {
        int answer = 0;
        
        var scoresData = new List<Tuple<int, int, int>>();
        int wanhoScore1 = scores[0, 0];
        int wanhoScore2 = scores[0, 1];
        int wanhoTotal = wanhoScore1 + wanhoScore2;

        for (int i = 1; i < scores.GetLength(0); i++)
        {
            int score1 = scores[i, 0];
            int score2 = scores[i, 1];
            int total = score1 + score2;

            if (total > wanhoTotal)
            {
                scoresData.Add(new Tuple<int, int, int>(score1, score2, total));
            }
        }
        
        var filteredScoresData = new List<Tuple<int, int, int>>();
        foreach (var sd in scoresData)
        {
            bool isEligible = true;
            foreach (var other in scoresData)
            {
                if (other.Item1 > sd.Item1 && other.Item2 > sd.Item2)
                {
                    isEligible = false;
                    break;
                }
            }
            if (isEligible)
            {
                filteredScoresData.Add(sd);
            }
        }

        bool canReceiveIncentive = true;
        foreach (var sd in filteredScoresData)
        {
            if (wanhoScore1 < sd.Item1 && wanhoScore2 < sd.Item2)
            {
                canReceiveIncentive = false;
                break;
            }
        }
        answer = canReceiveIncentive ? filteredScoresData.Count + 1 : -1;
        
        return answer;        
    }
}