using Data.Data.Identity;
using Data.ResponseDto;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Helpers;

public class Helper
{
   public string Service(RequestAuthentication request)
    {
        string ipAddress = "127.0.0.1";
        int port = 12345;
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);

        using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
        {
            client.Connect(endPoint);
            var hasher = new PasswordHasher<ApplicationUser>();

            string requestString = JsonConvert.SerializeObject(request);
            byte[] data = Encoding.UTF8.GetBytes(requestString);
            client.Send(data);
            Console.WriteLine("Request in server");

            data = new byte[1024];
            int bytesReceived = client.Receive(data);
            string responseString = Encoding.UTF8.GetString(data, 0, bytesReceived);
            return responseString;
        }
    }
}
