using INewRepoDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoDAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly IRepository<T> repository;
        public Repository(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UserLog(string name, string pwd)
        {
           var user=repository.UserLog(name, pwd);
            return user;
        }
    }
}
