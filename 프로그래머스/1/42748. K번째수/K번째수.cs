using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        
        int rows = commands.GetLength(0);
        int[] answer = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int startIdx = commands[i, 0] - 1;  // 시작하는 위치의 인덱스
            int endIdx = commands[i, 1] - 1;  // 마지막 위치의 인덱스
            int length = endIdx - startIdx + 1;  // 잘라낼 길이

            int[] newArray = new int[length];
            Array.Copy(array, startIdx, newArray, 0, length);  // Array.Copy 함수 사용
            Array.Sort(newArray);  // Array.Sort를 이용하여 정렬

            int resultIdx = commands[i, 2] - 1;  // 출력할 위치의 인덱스
            answer[i] = newArray[resultIdx];
        }
                
        
        return answer;
    }
}