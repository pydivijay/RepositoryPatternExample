using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Interfaces
{
    public interface IUserService
    {
        void Add(User entity);
        void Update(User entity);
        void Delete(User entity);
        User GetById(int id);
        List<User> GetAll();
    }
}
