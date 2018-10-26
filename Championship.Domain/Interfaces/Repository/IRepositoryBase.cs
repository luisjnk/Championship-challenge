using Championship.Domain.Entities;
using System.Collections.Generic;

namespace Championship.Domain.Interfaces
{
    public interface ITournamentRepository : IRepositoryBase<Tournament>
    {
        IEnumerable<Tournament> SearchByName(string name);
    }
}
