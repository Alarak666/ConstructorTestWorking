using Data.ResponseDto;
using Newtonsoft.Json;
using UnitTest.Helpers;

namespace UnitTest
{
    public class ServerTest
    {
        [Fact]
        public void Constructor_ShouldInitializeLists()
        {
            Helper helper = new Helper();
            RequestAuthentication requestAuthentication = new RequestAuthentication
            {
                Name = "Admin",
                PasswordHasher = 1.ToString(),
                TypeRequest = Data.CoreDefaults.Enum.TypeRequest.Auth
            };

            var responseData = helper.Service(requestAuthentication);
            ResponseAuthentication response = JsonConvert.DeserializeObject<ResponseAuthentication>(responseData);
            Assert.NotNull(response);
            Assert.False(response.Success);

            requestAuthentication = new RequestAuthentication
            {
                Name = "Admin",
                PasswordHasher = 0.ToString(),
                TypeRequest = Data.CoreDefaults.Enum.TypeRequest.Auth
            };
            responseData = helper.Service(requestAuthentication);
            response = JsonConvert.DeserializeObject<ResponseAuthentication>(responseData);
            Assert.NotNull(response);
            Assert.True(response.Success);
        }
    }
}
