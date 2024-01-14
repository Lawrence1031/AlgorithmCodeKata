using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // 에라토스테네스의 체를 이용하여 n에서 소수의 개수를 빼기
        
        answer = n - CountPN(n);
        
        return answer;
    }
    
    static public int CountPN(int n)
    {
        int tmp = 1;
        
        bool[] prime = new bool[n + 1];
        for (int i = 0; i < prime.Length; i++)
        {
            prime[i] = true;
        }
        
        for (int p = 2; p * p <= n; p++)
        {
            if (prime[p] == true)
            {
                for (int i = p * p; i <= n; i += p)
                {
                    prime[i] = false;
                }
            }
        }
        
        for (int i = 2; i <= n; i++)
        {
            if (prime[i] == true)
            {
                tmp++;
            }
        }
        
        return tmp;
    }
}