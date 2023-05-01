using Data.Data.Identity;
using Data.Data.InformationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class AsignTestUserTest
    {
        [Fact]
        public void AsignTestUser_User_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var user = new ApplicationUser();

            // Act
            asignTestUser.User = user;
            var result = asignTestUser.User;

            // Assert
            Assert.Equal(user, result);
        }

        [Fact]
        public void AsignTestUser_UserId_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var userId = Guid.NewGuid();

            // Act
            asignTestUser.UserId = userId;
            var result = asignTestUser.UserId;

            // Assert
            Assert.Equal(userId, result);
        }

        [Fact]
        public void AsignTestUser_TestOnServer_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var testOnServer = new TestOnServer();

            // Act
            asignTestUser.TestOnServer = testOnServer;
            var result = asignTestUser.TestOnServer;

            // Assert
            Assert.Equal(testOnServer, result);
        }

        [Fact]
        public void AsignTestUser_TestOnServerId_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var testOnServerId = Guid.NewGuid();

            // Act
            asignTestUser.TestOnServerId = testOnServerId;
            var result = asignTestUser.TestOnServerId;

            // Assert
            Assert.Equal(testOnServerId, result);
        }

        [Fact]
        public void AsignTestUser_UserUserName_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var userName = "testuser";

            // Act
            asignTestUser.UserUserName = userName;
            var result = asignTestUser.UserUserName;

            // Assert
            Assert.Equal(userName, result);
        }

        [Fact]
        public void AsignTestUser_UserNormalizedUserName_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var normalizedUserName = "TESTUSER";

            // Act
            asignTestUser.UserNormalizedUserName = normalizedUserName;
            var result = asignTestUser.UserNormalizedUserName;

            // Assert
            Assert.Equal(normalizedUserName, result);
        }

        [Fact]
        public void AsignTestUser_TestScore_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var testScore = 75.5m;

            // Act
            asignTestUser.TestScore = testScore;
            var result = asignTestUser.TestScore;

            // Assert
            Assert.Equal(testScore, result);
        }

        [Fact]
        public void AsignTestUser_TestAsignDateTime_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var testAsignDateTime = new TimeSpan(1, 1, 1);

            // Act
            asignTestUser.TimeForTheTest = testAsignDateTime;
            var result = asignTestUser.TimeForTheTest;

            // Assert
            Assert.Equal(testAsignDateTime, result);
        }
        [Fact]
        public void AsignTestUser_CompleteTestDateTime_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var completeTestDateTime = DateTime.UtcNow;
            asignTestUser.CompleteTestDateTime = completeTestDateTime;
            var result = asignTestUser.CompleteTestDateTime;

            // Assert
            Assert.Equal(completeTestDateTime, result);
        }

        [Fact]
        public void AsignTestUser_TestDateTime_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var testDateTime = TimeSpan.FromMinutes(30);
            // Act
            asignTestUser.TestDateTime = testDateTime;
            var result = asignTestUser.TestDateTime;

            // Assert
            Assert.Equal(testDateTime, result);
        }

        [Fact]
        public void AsignTestUser_AnswerRoot_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var answerRoot = "A,B,C,D";

            // Act
            asignTestUser.AnswerRoot = answerRoot;
            var result = asignTestUser.AnswerRoot;

            // Assert
            Assert.Equal(answerRoot, result);
        }

        [Fact]
        public void AsignTestUser_CountContinue_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var asignTestUser = new AsignTestUser();
            var countContinue = 2;

            // Act
            asignTestUser.CountContinue = countContinue;
            var result = asignTestUser.CountContinue;

            // Assert
            Assert.Equal(countContinue, result);
        }
    }
}
