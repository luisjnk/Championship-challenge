using Championship.Domain.Interfaces;
using System;
using System.Collections.Generic;
using Championship.Infra.Data.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading.Tasks;

namespace Championship.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private IFirebaseClient client;

        public void Connect()
        {
            FireBaseConnectConfig connect = new FireBaseConnectConfig();
            this.client = connect.Connect();
        }

        public async Task<TEntity> Add(TEntity obj, string uri)
        {   try
            {
               SetResponse response = await this.client.SetAsync(uri, obj);
               return obj;

            } catch(Exception ex)
            {
                throw new Exception();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetByName(string uri)
        {
            FirebaseResponse response = await this.client.GetAsync(uri);
            TEntity entity = response.ResultAs<TEntity>(); //The response will contain the data being retreived

            return entity;
            throw new NotImplementedException();
        }
    }
}
