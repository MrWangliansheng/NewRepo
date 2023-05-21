using INewRepoDAL;
using Microsoft.EntityFrameworkCore;
using NewRepoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoDAL
{

    public class UserRepository : IRepository<User>
    {
        public readonly NewRepoDbContext db;
        public UserRepository(NewRepoDbContext db)
        {
            this.db=db;
        }

        public Task Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UserLog(string name, string pwd)
        {
            var user = db.Set<User>().Where(m => m.User_Name.Equals(name) & m.User_Password.Equals(pwd)).FirstOrDefaultAsync();
            return await user;
        }
    }
}
