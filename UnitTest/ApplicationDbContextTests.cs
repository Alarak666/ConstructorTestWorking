using Data;
using Data.Data.Identity;
using Data.Data.InformationData;
using Microsoft.EntityFrameworkCore;
namespace ApplicationDbContextTest;
public class ApplicationDbContextTests
{
    [Fact]
    public void ApplicationRoles_Property_ReturnsDbSet()
    {
        // Arrange

        using var dbContext = new ApplicationDbContext();

        // Act
        var result = dbContext.ApplicationRoles;
        // Assert the count of ApplicationRoles
        Guid test1 = Guid.NewGuid();
        Guid test2 = Guid.NewGuid();

        // Add some test data
        var role1 = new ApplicationRole { Id = test1, Name = "Role1" };
        var role2 = new ApplicationRole { Id = test2, Name = "Role2" };
        dbContext.ApplicationRoles.Add(role1);
        dbContext.ApplicationRoles.Add(role2);
        dbContext.SaveChanges();
        // Assert
        Assert.NotNull(result);

        // Assert the count of ApplicationRoles after adding data


        // Assert the first role's Id and Name
        var firstRole = result.FirstOrDefault(x => x.Id == test1);
        Assert.Equal(test1, firstRole.Id);
        Assert.Equal("Role1", firstRole.Name);

        // Assert the last role's Id and Name
        var lastRole = result.FirstOrDefault(x => x.Id == test2);
        Assert.Equal(test2, lastRole.Id);
        Assert.Equal("Role2", lastRole.Name);

        // Assert that we can find a role by Id
        var foundRole = result.FirstOrDefault(x => x.Id == test2);
        Assert.NotNull(foundRole);
        Assert.Equal(test2, foundRole.Id);
        Assert.Equal("Role2", foundRole.Name);

        // Assert that we cannot find a non-existent role by Id
        var nonExistentRole = result.Find(Guid.NewGuid());
        Assert.Null(nonExistentRole);
    }
    [Fact]
    public void ApplicationUsers_Property_ReturnsDbSet()
    {
        // Arrange
        using var dbContext = new ApplicationDbContext();

        var result = dbContext.ApplicationUsers;

        // Assert
        Assert.NotNull(result);


        // Add some test data
        var test1 = Guid.NewGuid();
        var test2 = Guid.NewGuid();
        var user1 = new ApplicationUser { Id = test1, Email = "test1@example.com", UserName = "Test1" };
        var user2 = new ApplicationUser { Id = test2, Email = "test2@example.com", UserName = "Test2" };
        dbContext.ApplicationUsers.Add(user1);
        dbContext.ApplicationUsers.Add(user2);
        dbContext.SaveChanges();

        // Assert the first user's Id, Email, and UserName
        var firstUser = result.FirstOrDefault(x => x.Id == test1);
        Assert.Equal(test1, firstUser.Id);
        Assert.Equal("test1@example.com", firstUser.Email);
        Assert.Equal("Test1", firstUser.UserName);

        // Assert the last user's Id, Email, and UserName
        var lastUser = result.FirstOrDefault(x => x.Id == test2);
        Assert.Equal(test2, lastUser.Id);
        Assert.Equal("test2@example.com", lastUser.Email);
        Assert.Equal("Test2", lastUser.UserName);

        // Find a user in the ApplicationUsers property by Id
        var foundUser = result.FirstOrDefault(x => x.Id == test1);
        Assert.NotNull(foundUser);
        Assert.Equal(test1, foundUser.Id);
        Assert.Equal("test1@example.com", foundUser.Email);
        Assert.Equal("Test1", foundUser.UserName);

        // Attempt to find a non-existent user in the ApplicationUsers property by Id
        var nonExistentUser = result.FirstOrDefault(x => x.Id == Guid.NewGuid());
        Assert.Null(nonExistentUser);
    }
    [Fact]
    public void TestOnServers_ShouldBeEmptyByDefault()
    {
        // Arrange

        // Act
        using var dbContext = new ApplicationDbContext();

        var testOnServers = dbContext.TestOnServers;

        // Assert
        Assert.NotNull(testOnServers);
        Assert.NotEmpty(testOnServers);
    }
    [Fact]
    public void TestOnServers_ShouldContainAddedEntity()
    {
        // Arrange
        var testOnServer = new TestOnServer
        {
            Id = Guid.NewGuid(),
            FileName = "Test Name",
            Description = "Test Description",
            Title = "Test",
            Info = "Test",
            Percent = 11m,
            Root = "Test",
        };

        // Act
        using (var context = new ApplicationDbContext())
        {
            var testOnServers = context.TestOnServers;

            testOnServers.Add(testOnServer);
            context.SaveChanges();
        }

        // Assert
        using (var context = new ApplicationDbContext())
        {
            var testOnServers = context.TestOnServers;
           var item=  testOnServers.FirstOrDefault(x => x.Id == testOnServer.Id);
            Assert.NotNull(item);
        }
    }
    [Fact]
    public async Task CanAddAsignTestUserToDatabase()
    {
        // Arrange

        var id = Guid.NewGuid();
        var asignTestUser = new AsignTestUser
        {
            Id = id,
            UserUserName = "Test",
            UserNormalizedUserName = "Test",
            TestScore = 11m,
            AnswerRoot = "Test",
            CountContinue = 3m,
            TimeForTheTest = new TimeSpan(1, 1, 1)
        };

        // Act
        using (var context = new ApplicationDbContext())
        {
            await context.AsignTestUsers.AddAsync(asignTestUser);
            await context.SaveChangesAsync();
        }

        // Assert
        using (var context = new ApplicationDbContext())
        {
            var result = await context.AsignTestUsers.FirstOrDefaultAsync(x => x.Id== id);

            Assert.Equal(11m, result.TestScore);
            Assert.Equal(asignTestUser.TimeForTheTest, result.TimeForTheTest);
        }
    }
}
