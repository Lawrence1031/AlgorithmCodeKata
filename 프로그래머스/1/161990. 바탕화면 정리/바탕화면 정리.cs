using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int lux = 51, luy = 51, rdx = 0, rdy = 0;

        for (int x = 0; x < wallpaper.Length; x++)
        {
            for (int y = 0; y < wallpaper[x].Length; y++)
            {
                if (wallpaper[x][y] == '#')
                {
                    lux = Math.Min(lux, x);
                    luy = Math.Min(luy, y);
                    rdx = Math.Max(rdx, x);
                    rdy = Math.Max(rdy, y);
                }
            }
        }

        // lux, luy는 좌표를 그대로 사용하지만
        // rdx, rdy는 좌표에 + 1한 값을 사용

        rdx++;
        rdy++;
        
        int[] answer = new int[4] { lux, luy, rdx, rdy };
        
        return answer;
    }
}