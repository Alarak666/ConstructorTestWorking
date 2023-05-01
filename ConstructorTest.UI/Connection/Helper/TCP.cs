using Data.Data.Identity;
using Data.ResponseDto;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace ConstructorTest.UI.Connection.Helper
{
    public class TCP
    {
        public string ipAddress = "127.0.0.1";
        public int port;
        Random Rd= new Random();
        public TCP()
        {
            this.port = 12345;
        }

        public async Task<string> SendRequest<T>(object request) where T : class
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);

                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {

                    // Connect to the server
                    await client.ConnectAsync(endPoint);

                    // Serialize the request to JSON
                    string requestString = JsonConvert.SerializeObject(request);

                    // Send the request to the server
                    byte[] data = Encoding.UTF8.GetBytes(requestString);
                    await client.SendAsync(data, SocketFlags.None);
                    Console.WriteLine("Request sent to the server");

                    // Receive the response from the server
                    data = new byte[1024];
                    int bytesReceived = await client.ReceiveAsync(data, SocketFlags.None);
                    var responseString = Encoding.UTF8.GetString(data, 0, bytesReceived);
                    return responseString;
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Не удалось установить соединение с сервером: {ex.Message}");
                return null; 
            }
        }
    }
}
