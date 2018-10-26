using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using Championship.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship.Domain.Models;

namespace Championship.Domain.Services
{
    public class TournamentService : ServiceBase<Tournament>, ITournamenteService
    {
        private readonly ITournamentRepository _tournamentRepository;
        private readonly MatchModel _matchModel;
        
        public  TournamentService(ITournamentRepository tournamentRepository)
            :base(tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        public void CreateTournament(Tournament tournament, string uri)
        {
            int countOfTournamentKeys = ValidateTournament(tournament);
            if (countOfTournamentKeys > 0)
            {
                tournament = _matchModel.CreateGenerateMatches(tournament);
                _tournamentRepository.Add(tournament, uri);
            } else
            {

            }
        }

        public Task<Tournament> GetTournament(string uri)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The Tournament need to be in championship rules
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns>tou</returns>
        private int ValidateTournament(Tournament tournament)
        { 
            int rest = tournament.Teams.Count & 2;
            if(rest == 0)
            {
                return tournament.Teams.Count / 4;
            } else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// Creating keys for the tournament
        /// </summary>
        /// <param name="tournament"></param>
        /// <returns></returns>
        private Tournament CreateKeys(Tournament tournament)
        {
            int index = 0;
            Key key;
            List<Team> teams = new List<Team>();
            foreach (Team team in tournament.Teams)
            {
                teams.Add(team);;
                bool keyIsFull = (index % 4) == 0;
                if (keyIsFull)
                {   key = new Key();
                    key.Teams = teams;
                    tournament.Keys.Add(key);
                    teams = new List<Team>();
                }
                index++;

            }
            return tournament;
        }       

        private Tournament CreateGenerateMatches(Tournament tournament)
        {
            int index = 0;
            List<Match> matches = new List<Match>();
            List<Team> teams = new List<Team>();

            int tournamentLength = tournament.Teams.Count;

            for(int i = 0; i <= tournamentLength; i++)
            {
                Match match = new Match();
                match.firstTeam = tournament.Teams[i];
                match.secondtTeam = tournament.Teams[i + 1];
            }
            tournament.Matches = matches;
       
            return tournament;
        }
    }
}
