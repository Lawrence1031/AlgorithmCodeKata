using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        int n = numbers.Length;
        Array.Sort(numbers);
        
        answer = Math.Max(numbers[0] * numbers[1], numbers[n - 1] * numbers[n - 2]);
        
        return answer;
    }
}