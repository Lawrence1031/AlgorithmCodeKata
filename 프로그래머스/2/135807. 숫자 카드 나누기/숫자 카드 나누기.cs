using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] arrayA, int[] arrayB) {
        int answer = 0;
        
        int GCDA = arrayA[0];
        for (int i = 1; i < arrayA.Length; i++)
        {
            GCDA = FindGCD(GCDA, arrayA[i]);
        }

        int GCDB = arrayB[0];
        for (int i = 1; i < arrayB.Length; i++)
        {
            GCDB = FindGCD(GCDB, arrayB[i]);
        }

        int maxA = 0;
        int maxB = 0;

        for (int i = GCDA; i >= 1; i--)
        {
            if (GCDA % i == 0 && !IsDivisible(i, arrayB))
            {
                maxA = i;
                break;
            }
        }
        for (int i = GCDB; i >= 1; i--)
        {
            if (GCDB % i == 0 && !IsDivisible(i, arrayA))
            {
                maxB = i;
                break;
            }
        }

        answer = (maxA > maxB) ? maxA : maxB;

        return answer;
    }

    public static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static List<int> FindDivisors(int number)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
                if (i != number / i)
                {
                    divisors.Add(number / i);
                }
            }
        }
        divisors.Sort();
        return divisors;
    }

    public static bool IsDivisible(int num, int[] array)
    {
        foreach (int i in array)
        {
            if (i % num == 0)
                return true;
        }
        return false;
    }
}