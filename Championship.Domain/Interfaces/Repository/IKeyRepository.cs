using Championship.Domain.Entities;
using System.Collections.Generic;

namespace Championship.Domain.Interfaces
{
    public interface IkeyRepository : IRepositoryBase<Tournament>
    {
        IEnumerable<Team> SearchByName(string name);

    }
}
