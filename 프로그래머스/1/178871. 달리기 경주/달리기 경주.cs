using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[] {};
        
        Dictionary<string, int> index = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
        {
            index.Add(players[i], i);
        }

        for (int i = 0; i < callings.Length; i++)
        {
            Overtake(players, index, callings[i]);
        }

        answer = players;
        
        return answer;
    }

    static void Overtake(string[] players, Dictionary<string, int> dictionary, string value)
    {
        int idx1 = dictionary[value];
        int idx2 = idx1 - 1;

        string tmp = players[idx1];
        players[idx1] = players[idx2];
        players[idx2] = tmp;

        dictionary[players[idx1]] = idx1;
        dictionary[players[idx2]] = idx2;
    }
}