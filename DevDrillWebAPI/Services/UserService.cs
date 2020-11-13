using System.Linq;
using System.Threading.Tasks;
using DevDrillWebAPI.Entities.DevDrillDB;
using DevDrillWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DevDrillWebAPI.Services
{
    public class UserService
    {
        private readonly DevDrillDbContext dbContext;

        public UserService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<UserModel> Login(string username, string password)
        {
            UserModel user = await dbContext.User
                .Where(e => e.Username == username)
                .Where(e => e.Password == password)
                .Select(e => new UserModel()
                {
                    Username = e.Username,
                    Password = e.Password,
                    UserId = e.UserId
                })
                .FirstOrDefaultAsync();

            return user;

        }

        public async Task Register(string username, string password)
        {
            await dbContext.User.AddAsync(new User()
            {
                Username = username,
                Password = password
            });
        }
    }
}