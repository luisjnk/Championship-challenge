using Championship.Domain.Entities;
using System.Threading.Tasks;

namespace Championship.Application.Interfaces
{
    public interface ITournamentAppService : IAppServiceBase<Tournament>
    {
        void CreateTournament(Tournament obj);

        Task<Tournament> GetTournament(string tournamentName);
    }
}
