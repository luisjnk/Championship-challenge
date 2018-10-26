using Championship.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Championship.Domain.Models
{
   public class MatchModel
    {
        private static readonly Random getrandom = new Random();

        public Team ManageMatch(Team firstTeam, Team secondTeam)
        {
            Team winner = StartMatch(firstTeam,secondTeam);
            return winner;
        } 

       public Team StartMatch(Team firstTeam, Team secondTeam)
        {
            Team[] match = new Team[2];
            match[0] = firstTeam;
            match[1] = secondTeam;

            int[] firstArray = new int[] { 1, 0 };
            int[] secondArray = new int[] { 0, 1 };

            for (int i = 0; i <= 1; i++)
            {
                secondArray[i] = i;
                firstArray[i] = i;
            }

            Array.Sort(firstArray, secondArray);
            Team winner = match[0];
            // Knuth shuffle algorithm :: courtesy of Wikipedia :)
            for (int t = 0; t < firstArray.Length; t++)
            {
                if (firstArray[t] == secondArray[t])
                {
                        winner = match[t];
                 }
                
            }

            return winner;
        }

        public Tournament CreateGenerateMatches(Tournament tournament)
        {
            int tournamentLength = tournament.Teams.Count;
             
            List<int> indexWhoAreBusy = new List<int>();
            List<Match> matches = new List<Match>();
            List<Team> teams = new List<Team>();

            for (int i = 0; i <= tournamentLength - 1; i++)
            {
                var thisIndexIsInAMatch = indexWhoAreBusy.Any( indexWB => indexWB == i);
                if(thisIndexIsInAMatch)
                {
                    continue;
                }

                Match match = new Match();
                match.firstTeam = tournament.Teams[i];
                match.secondtTeam = tournament.Teams[i + 1];
                indexWhoAreBusy.Add(i);
                indexWhoAreBusy.Add(i + 1);
                matches.Add(match);
            }
            tournament.Matches = matches;

            return tournament;
        }

        private int GenerateRandomIndex(int min, int max)
        {
            lock (getrandom) 
            {
                return getrandom.Next(min, max);
            }
        }

    }
}
