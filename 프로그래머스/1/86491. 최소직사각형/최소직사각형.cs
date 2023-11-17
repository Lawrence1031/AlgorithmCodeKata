using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        
        // 모든 명함을 담을 수 있는 크기의 지갑
        // 가로가 세로가 주어진 입력값에 대해서
        // 둘 중에 긴 쪽을 가로로 만들어서 w를 h로, h를 w로 만들어서
        // 이 중에 가장 큰 w와 h를 구한 뒤에 곱해서 answer로
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] < sizes[i, 1])
            {
                int temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }            
        }
        
        List<int> row = new List<int>();
        List<int> col = new List<int>();
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            row.Add(sizes[i, 0]);
            col.Add(sizes[i, 1]);
        }
        
        int maxW = row.Max();
        int maxH = col.Max();
        
        answer = maxW * maxH;              
        
        return answer;
    }
}