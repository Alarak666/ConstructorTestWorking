using Data;
using Data.Data.Identity;
using Data.DataDto;
using Data.ResponseDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Server.Helpers
{
    public class Helper
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public Helper()
        {

        }
        public async Task<UserInServer> ServerConnectionUser(UserInServer requestAuthentication)
        {
            return new UserInServer()
            {
                UserInServers = Program.Onserver
            };
        }
        public async Task<ResponseAuthentication> Authentication(RequestAuthentication requestAuthentication)
        {
            var user = await context.ApplicationUsers.FirstOrDefaultAsync(x => x.UserName == requestAuthentication.Name);
            var hasher = new PasswordHasher<ApplicationUser>();
            if (user == null)
            {
                return new ResponseAuthentication()
                {
                    Success = false,
                    Name = user?.UserName ?? "",
                    UserId = null
                };
            }
            var result = hasher.VerifyHashedPassword(user, user.PasswordHash, requestAuthentication.PasswordHasher);

            if (user != null && result == PasswordVerificationResult.Success)
            {
                return new ResponseAuthentication()
                {
                    Success = true,
                    Name = user?.UserName ?? "",
                    UserId = user?.Id
                };
            }

            return new ResponseAuthentication()
            {
                Success = false,
                Name = user?.UserName ?? "",
                UserId = null
            };
        }
    }
}
