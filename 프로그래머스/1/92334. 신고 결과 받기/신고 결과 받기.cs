using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        
        Dictionary<string, int> reportCnt = new Dictionary<string, int>();
        Dictionary<string, HashSet<string>> userReports = new Dictionary<string, HashSet<string>>();

        foreach (string id in id_list)
        {
            reportCnt[id] = 0;
            userReports[id] = new HashSet<string>();
        }

        foreach (string s in report)
        {
            string[] parts = s.Split(' ');
            string from = parts[0];
            string to = parts[1];

            if (!userReports[from].Contains(to))
            {
                userReports[from].Add(to);
                reportCnt[to]++;
            }
        }

        HashSet<string> bannedUsers = new HashSet<string>();
        foreach (var pair in reportCnt)
        {
            if (pair.Value >= k)
            {
                bannedUsers.Add(pair.Key);
            }
        }

        for (int i = 0; i < id_list.Length; i++)
        {
            foreach (string reported in userReports[id_list[i]])
            {
                if (bannedUsers.Contains(reported))
                {
                    answer[i]++;
                }
            }
        }
        
        return answer;
    }
}