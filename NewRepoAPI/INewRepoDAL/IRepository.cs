using NewRepoModel;

namespace INewRepoDAL
{
    public interface IRepository<T>where T : class
    {
         Task<T> UserLog(string name,string pwd);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}