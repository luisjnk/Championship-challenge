using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Championship.Application.Interfaces
{
   public interface IAppServiceBase<TEntity> where  TEntity : class
    {
        Task<TEntity> Add(TEntity obj, string uri);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
