using Bogus;
using Data;
using Data.CoreDefaults;
using Data.Data.Identity;
using Data.Data.InformationData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Seed
{
    public class SeedData
    {
        public Faker faker = new Faker();
        ApplicationDbContext context;
        public SeedData(ApplicationDbContext context)
        {

            this.context = context;
            EnsureSeedData(this.context).ConfigureAwait(false);
        }


        public async Task EnsureSeedData(ApplicationDbContext context)
        {
            if (context.Database.GetPendingMigrations().Any()) context.Database.Migrate();

            var stopWatch = new Stopwatch();
            stopWatch.Start();



            Console.WriteLine($"ClearAllData elapsed milliseconds {stopWatch.ElapsedMilliseconds}");

            stopWatch.Reset();
            stopWatch.Start();

            await SeedDataActive(context);

            Console.WriteLine($"SeedData elapsed milliseconds {stopWatch.ElapsedMilliseconds}");

        }
        public async Task SeedDataActive(ApplicationDbContext context)
        {
            try
            {

            await SeedRole(context);
            await SeedUser(context);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }

        }
        public async Task SeedRole(ApplicationDbContext context)
        {
            context.ApplicationRoles.Add(
                   new ApplicationRole()
                   {
                       Id = CoreDefaultValues.ApplicationRolesId,
                       Name = "Admin",
                       ConcurrencyStamp = CoreDefaultValues.ApplicationRolesId.ToString(),
                       NormalizedName = "Administrator"
                   });
        }
        public async Task SeedUser(ApplicationDbContext context)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            context.ApplicationUsers.Add(
               new ApplicationUser()
               {
                   Id = CoreDefaultValues.ApplicationUserId,
                   Email = faker.Person.Email,
                   PhoneNumber = faker.Person.Phone,
                   EmailConfirmed = true,
                   LockoutEnabled = false,
                   AccessFailedCount = 0,
                   NormalizedEmail = faker.Person.Email,
                   NormalizedUserName = "Admin",
                   UserName = "Admin",
                   TwoFactorEnabled = false,
                   ApplicationRoleName = "Admin",
                   ConcurrencyStamp = CoreDefaultValues.ApplicationUserId.ToString(),
                   SecurityStamp = CoreDefaultValues.ApplicationUserId.ToString(),
                   PasswordHash = hasher.HashPassword(new ApplicationUser(), "0"),
                   ApplicationRoleId = CoreDefaultValues.ApplicationRolesId
               });

        }
    }


}

