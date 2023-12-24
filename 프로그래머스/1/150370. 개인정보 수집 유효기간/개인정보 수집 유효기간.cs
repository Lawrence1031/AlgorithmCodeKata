using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] result = new int[privacies.Length];
        int[] answer = new int[privacies.Length];
        List<int> tmpList = new List<int>();

        string todayStr = today.Replace(".", "");
        int todaydate = int.Parse(todayStr);

        // terms의 데이터를 dictionary를 이용하여 저장

        Dictionary<string, int> termsDict = SplitTerms(terms);

        for (int i = 0; i < privacies.Length; i++)
        {
            string[] privacyData = privacies[i].Split(' ');
            string privacyDateStr = privacyData[0].Replace(".", "");

            int privacyDate = int.Parse(privacyDateStr);
            string termKey = privacyData[1];

            if (termsDict.ContainsKey(termKey))
            {
                int termValue = termsDict[termKey];
                int checkDate = 0;

                int year = privacyDate / 10000;
                int month = privacyDate % 10000;
                month = month + termValue * 100;

                if (month > 1300)
                {
                    int tmp = month / 1210;
                    year += tmp;
                    month -= tmp * 1200;
                }

                checkDate = year * 10000 + month;
                result[i] = checkDate - todaydate;

                if (result[i] <= 0)
                {
                    tmpList.Add(i + 1);
                }
            }
        }
        
        answer = tmpList.ToArray();        
        return answer;
    }
    
    private static Dictionary<string, int> SplitTerms(string[] terms)
    {
        Dictionary<string, int> dataDict = new Dictionary<string, int>();

        foreach (string pair in terms)
        {
            string[] keyValue = pair.Trim().Split(' ');
            if (keyValue.Length == 2)
            {
                string key = keyValue[0];
                int value = int.Parse(keyValue[1]);
                dataDict[key] = value;
            }
        }

        return dataDict;
    }
}