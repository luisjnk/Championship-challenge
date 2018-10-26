using System;
using System.Collections.Generic;
using System.Linq;
using Championship.Domain.Models;

namespace Championship.Domain.Entities
{
    public class Key
    {
        public Guid KeyId { get; set; }

        public string Name { get; set; }

        public List<Team> Teams {get; set;}

        private int _pointsOfWinner = 3;

        private int round = 1;

        public void IncreaseWinnerScore(Team team)
        {
            Team TeamOnKey = Teams.FirstOrDefault(t => t.Name == team.Name);
            TeamOnKey.Score = TeamOnKey.Score + _pointsOfWinner;
            OrderByTable();
        }

        private void OrderByTable()
        {
            Teams = Teams.OrderByDescending(t => t.Score).ToList();
        }

        public void SortMatch()
        {
            MatchModel match = new MatchModel();

           Team firstMatchWinner = match.ManageMatch(Teams[0], Teams[1]);
           IncreaseWinnerScore(firstMatchWinner);
           Team secondMatchWinner = match.ManageMatch(Teams[2], Teams[3]);
           IncreaseWinnerScore(secondMatchWinner);

           round++;
        }

        public List<List<Team>> Undraw()
        {
            return  Teams.GroupBy(t => t.Score)
                        .Select(grp => grp.ToList()).ToList();
            
        }
    }
}