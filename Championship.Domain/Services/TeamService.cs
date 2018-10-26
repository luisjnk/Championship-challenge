/*using System.Collections.Generic;
using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using Championship.Domain.Interfaces.Services;

namespace Championship.Domain.Services
{
    public class TeamService : ServiceBase<Team>, ITeamService
    {
        public readonly ITeamRepository _teamRepository;
        
        public TeamService(ITeamRepository teamRepository)
            : base(teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public void CreateTeam(List<Team> obj, string uri)
        {
            throw new System.NotImplementedException();
        }

       /* public Tournament GetTournamentTeamsCount()
        {

        }      }
}*/

