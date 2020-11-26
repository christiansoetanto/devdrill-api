using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevDrillAPI.Services
{
    public class UserService
    {
        private readonly DevDrillDbContext dbContext;

        public UserService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<UserDto> Login(string email, string password)
        {
            return await dbContext.Users
                .Where(e => e.Email == email)
                .Where(e => e.Password == password)
                .Select(e => new UserDto()
                {
                    Email = e.Email,
                    Name = e.Name,
                    UserId = e.UserId,
                    PhotoUrl = e.PhotoUrl,
                    PhoneNumber = e.PhoneNumber
                })
                .FirstOrDefaultAsync();
        }

        public async Task Register(string name, string email, string phoneNumber, string password)
        {
            await dbContext.Users.AddAsync(new User()
            {
                Email = email,
                Name = name,
                Password = password,
                PhoneNumber = phoneNumber,
                IsInstructor = false
            });
            await dbContext.SaveChangesAsync();
        }
    }
}