using RepositoryPatternExample.Interfaces;
using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository=repository;
        }
        public void Add(User entity)
        {
            _repository.Add(entity);
        }

        public void Delete(User entity)
        {
            _repository.Delete(entity);
        }

        public List<User> GetAll()
        {
           return _repository.GetAll();
        }

        public User GetById(int id)
        {
            return (User)_repository.GetById(id);
        }

        public void Update(User entity)
        {
            _repository.Update(entity);
        }
    }
}
