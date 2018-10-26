using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Championship.Domain.Entities;
using Championship.Domain.Models;
using System.Collections.Generic;

namespace Championship.Tests
{
    [TestClass]
    public class MatchTests
    {
        
        private Tournament CreateTournament()
        {
            Tournament tournament = new Tournament();
            tournament.Teams = new List<Team>();

            Team firstTeam = new Team();
            firstTeam.Name = "Botafogo";
            tournament.Teams.Add(firstTeam);

            Team secondTeam = new Team();
            secondTeam.Name = "Flamengo";
            tournament.Teams.Add(secondTeam);

            Team tirdThTeam = new Team();
            tirdThTeam.Name = "Time 3";
            tournament.Teams.Add(tirdThTeam);

            Team fourthTeam = new Team();
            fourthTeam.Name = "Time 4";
            tournament.Teams.Add(fourthTeam);

            Team fifthTeam = new Team();
            fifthTeam.Name = "Time 5";
            tournament.Teams.Add(fifthTeam);
            
            Team sixthTeam = new Team();
            sixthTeam.Name = "Time 6";
            tournament.Teams.Add(sixthTeam);

            Team seventhTeam = new Team();
            seventhTeam.Name = "Vasco";
            tournament.Teams.Add(seventhTeam);

            Team eightTeam = new Team();
            eightTeam.Name = "Fluminense";
            tournament.Teams.Add(eightTeam);

            return tournament;
        }

        private List<Match> ListOfMatchs()
        {
            List<Match> matches = new List<Match>();
            Match match = new Match();
            Team team = new Team();
            team.Name = "Botafogo";
            match.firstTeam = team;
            matches.Add(match);
            team = new Team();
            team.Name = "Flamengo";
            match.secondtTeam = team;
            matches.Add(match);

            return matches;
        }

        [TestMethod]
        public void GenerateMatch()
        {
            Tournament tournament =  CreateTournament();
            MatchModel match = new MatchModel();
            List<Match> matches = ListOfMatchs();

            tournament = match.CreateGenerateMatches(tournament);
            //Assert
            Assert.AreEqual(tournament.Matches[0].firstTeam.Name, matches[0].firstTeam.Name);
            Assert.AreEqual(tournament.Matches[0].secondtTeam.Name, matches[0].secondtTeam.Name);
        }

        [TestMethod]
        public void NextMatch()
        {
            Tournament tournament = CreateTournament();
            MatchModel match = new MatchModel();
            List<Match> matches = ListOfMatchs();

            tournament = match.CreateGenerateMatches(tournament);
            //Assert
            Assert.AreEqual(tournament.Matches[0].firstTeam.Name, matches[0].firstTeam.Name);
            Assert.AreEqual(tournament.Matches[0].secondtTeam.Name, matches[0].secondtTeam.Name);
        }

    }
}
