using System;
using System.Collections.Generic;
using System.Linq;

public class Song
{
    public string Genre { get; set; }
    public int Plays { get; set; }
    public int Index { get; set; }

    public Song(string genre, int plays, int index)
    {
        Genre = genre;
        Plays = plays;
        Index = index;
    }
}

public class Solution {
    public int[] solution(string[] genres, int[] plays) {
        int[] answer = new int[] {};
        List<Song> songs = new List<Song>();
        for (int i = 0; i < genres.Length; i++)
        {
            songs.Add(new Song(genres[i], plays[i], i));
        }

        var genrePlayCounts = songs.GroupBy(song => song.Genre)
                                   .Select(group => new
                                   {
                                       Genre = group.Key,
                                       TotalPlay = group.Sum(song => song.Plays)
                                   })
                                   .OrderByDescending(genre => genre.TotalPlay);

        List<int> bestAlbum = new List<int>();
        foreach (var genre in genrePlayCounts)
        {
            var songsInGenre = songs.Where(song => song.Genre == genre.Genre)
                                    .OrderByDescending(song => song.Plays)
                                    .ThenBy(song => song.Index)
                                    .Take(2);
            bestAlbum.AddRange(songsInGenre.Select(song => song.Index));
        }

        answer = bestAlbum.ToArray();
        
        return answer;
    }
}