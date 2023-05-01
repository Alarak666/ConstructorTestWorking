using Microsoft.EntityFrameworkCore;
using Data;
using Seed;

using var dbContext = new ApplicationDbContext();
try
{
    dbContext.Database.EnsureDeleted();
    dbContext.Database.Migrate();
    var seed = new SeedData(dbContext);
}
catch( Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.Read();    
}
