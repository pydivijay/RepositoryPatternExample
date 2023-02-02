using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Interfaces;
using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly APIDbContext _dbContext;

        public Repository(APIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
