using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        int[] number = { 10000, 100, 1 };

        var List = rank.Select((r, index) => new { Rank = r, Attendance = attendance[index], Index = index })
                       .Where(x => x.Attendance)
                       .OrderBy(x => x.Rank)
                       .ToList();

        for (int i = 0; i < 3; i++)
        {
            answer += number[i] * List[i].Index;
        }
        
        return answer;
    }
}
