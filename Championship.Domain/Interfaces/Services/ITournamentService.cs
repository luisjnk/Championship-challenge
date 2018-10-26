using Championship.Domain.Entities;
using System.Threading.Tasks;

namespace Championship.Domain.Interfaces.Services
{
    public interface ITournamenteService :IServiceBase<Tournament>
    {
        void CreateTournament(Tournament obj, string uri);

        Task<Tournament> GetTournament(string uri);
    }
}
