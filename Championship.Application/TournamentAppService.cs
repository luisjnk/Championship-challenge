using System.Threading.Tasks;
using Championship.Application.Interfaces;
using Championship.Domain.Entities;
using Championship.Domain.Interfaces.Services;

namespace Championship.Application
{
    public class TournamentAppService : AppServiceBase<Tournament>, ITournamentAppService
    {
        public readonly ITournamenteService _tournamentSerivce;
        private string _uriPath = "Tournament/";

        public TournamentAppService(ITournamenteService tournamentSerivce)
            : base(tournamentSerivce)
        {
            this._tournamentSerivce = tournamentSerivce;
        }

        public void CreateTournament(Tournament tournament)
        {
            string URI = CreateURI(tournament.Name);
            _tournamentSerivce.CreateTournament(tournament, URI);
        }
        
        public string CreateURI(string tournamentName)
        {
            return this._uriPath + tournamentName;
        }

        public Task<Tournament> GetTournament(string tournamentName)
        {
            string URI = CreateURI(tournamentName);
            return _tournamentSerivce.GetTournament(tournamentName);
        }
    }
}
