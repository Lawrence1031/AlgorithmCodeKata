using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int answerLength = num2 - num1 + 1;        
        int[] answer = new int[answerLength];
        
        Array.Copy(numbers, num1, answer, 0, answerLength);
        
        return answer;
    }
}