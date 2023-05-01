using Data.Data.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class ApplicationUserTest
    {
        [Fact]
        public void ApplicationUser_ApplicationRole_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var user = new ApplicationUser();
            var role = new ApplicationRole();

            // Act
            user.ApplicationRole = role;
            var result = user.ApplicationRole;

            // Assert
            Assert.Equal(role, result);
        }

        [Fact]
        public void ApplicationUser_ApplicationRoleId_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var user = new ApplicationUser();
            var roleId = Guid.NewGuid();

            // Act
            user.ApplicationRoleId = roleId;
            var result = user.ApplicationRoleId;

            // Assert
            Assert.Equal(roleId, result);
        }

        [Fact]
        public void ApplicationUser_ApplicationRoleName_Property_ReturnsAndSetsValue()
        {
            // Arrange
            var user = new ApplicationUser();
            var roleName = "Admin";

            // Act
            user.ApplicationRoleName = roleName;
            var result = user.ApplicationRoleName;

            // Assert
            Assert.Equal(roleName, result);
        }
        // Import necessary namespaces
    }
}
