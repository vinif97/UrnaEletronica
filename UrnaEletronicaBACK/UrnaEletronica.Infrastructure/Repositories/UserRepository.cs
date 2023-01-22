using Microsoft.EntityFrameworkCore;
using UrnaEletronica.Domain.Interface.Repositories;
using UrnaEletronica.Domain.Model;
using UrnaEletronica.Infrastructure.Context;

namespace UrnaEletronica.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EletronicUrnContext _context;

        public UserRepository(EletronicUrnContext context)
        {
            _context = context;
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Email == email);
        }

        public async Task<User?> FindByUserNameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.UserName == username);
        }

        public async Task CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsyn(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync(); 
        }
    }
}
