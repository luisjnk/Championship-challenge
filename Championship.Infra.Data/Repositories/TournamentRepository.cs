using Championship.Domain.Entities;
using Championship.Domain.Interfaces;
using System.Collections.Generic;

namespace Championship.Infra.Data.Repositories
{
    public class TournamentRepository : RepositoryBase<Tournament>, ITournamentRepository
    {

        public TournamentRepository()
        {
            this.Connect();
        }

        public IEnumerable<Tournament> SearchByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
