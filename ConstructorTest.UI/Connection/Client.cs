using ConstructorTest.UI.Connection.Helper;
using Data.ResponseDto;

namespace Server
{
    //Test
    public class Client
    {
        public Client()
        {
        }
        public async Task Request()
        {

            RequestAuthentication request = new RequestAuthentication()
            {
                Name = "Admin",
                PasswordHasher = "0",
                TypeRequest = Data.CoreDefaults.Enum.TypeRequest.Auth
            };
            // ResponseAuthentication response = await TCP.SendRequest<ResponseAuthentication>(request);
        }
    }
}
