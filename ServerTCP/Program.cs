using Data.Data.Identity;
using Data.ResponseDto;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the IP address and port for the server

            // Set the IP address and port for the server
            string ipAddress = "127.0.0.1";
            int port = 12345;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);

            // Create a socket
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                
                client.Connect(endPoint);
                var hasher = new PasswordHasher<ApplicationUser>();

                // Create an authentication request
                RequestAuthentication request = new RequestAuthentication()
                {
                    Name = "Admin",
                    PasswordHasher = "0",
                    TypeRequest = Data.CoreDefaults.Enum.TypeRequest.Auth
                };

                string requestString = JsonConvert.SerializeObject(request);

                // Send a request to the server
                byte[] data = Encoding.UTF8.GetBytes(requestString);
                client.Send(data);
                Console.WriteLine("Authentication request sent");

                // We accept the response from the server
                data = new byte[1024];
                int bytesReceived = client.Receive(data);
                string responseString = Encoding.UTF8.GetString(data, 0, bytesReceived);
                ResponseAuthentication response = JsonConvert.DeserializeObject<ResponseAuthentication>(responseString);

                if (response.Success)
                {
                    Console.WriteLine("Authentication was successful. Username: {0}, ID user: {1}", response.Name, response.UserId);
                }
                else
                {
                    Console.WriteLine("Authentication failed. Username: {0}", response.Name);
                }
                Console.ReadKey();
            }
        }
    }
}