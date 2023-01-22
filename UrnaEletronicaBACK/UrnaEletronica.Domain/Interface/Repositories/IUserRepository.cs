using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Domain.Interface.Repositories
{
    public interface IUserRepository
    {
        Task<User?> FindByEmailAsync(string email);
        Task<User?> FindByUserNameAsync(string username);
        Task CreateUserAsync(User user);
        Task UpdateUserAsyn(User user);
    }
}
