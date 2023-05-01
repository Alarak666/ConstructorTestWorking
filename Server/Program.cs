using Data.CoreDefaults.Enum;
using Data.DataDto;
using Data.ResponseDto;
using Newtonsoft.Json;
using Server.Helpers;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        public static List<string> Onserver = new List<string>();

        static List<Socket> clients = new List<Socket>();
        static void Main(string[] args)
        {
            // Set the IP address and port for the server
            string ipAddress = "127.0.0.1";
            int port = 12345;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);

            // Create a socket
            using (Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                // Bind the socket with the IP address and port
                listener.Bind(endPoint);

                // We start listening
                listener.Listen(10);
                Console.WriteLine("The server is running and waiting for a connection...");
                while (true)
                {
                    // Waiting for the client to connect
                    Socket handler = listener.Accept();
                    clients.Add(handler);
                    Console.WriteLine("Connection established: {0}", handler.RemoteEndPoint.ToString());
                    // Create a flow for processing the request from the client
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.Start(handler);
                }
            }
        }

        static async void HandleClient(object obj)
        {
            Socket handler = (Socket)obj;
            Helper helper = new Helper();
            // We accept data from the client
            byte[] data = new byte[1024];
            int bytesReceived = handler.Receive(data);
            string requestString = Encoding.UTF8.GetString(data, 0, bytesReceived);
            Console.WriteLine("Message received from client {0}: {1}", handler.RemoteEndPoint.ToString(), requestString);
            RequestAuthentication request = new RequestAuthentication();
            try
            {
                request = JsonConvert.DeserializeObject<RequestAuthentication>(requestString);
                // do something with the deserialized object
            }
            catch (Exception ex)
            {

            }
            UserInServer UserInServerRequest = new UserInServer();
            try
            {
                UserInServerRequest = JsonConvert.DeserializeObject<UserInServer>(requestString);
                // do something with the deserialized object
            }
            catch (Exception ex)
            {

            }
            // Define the request type
            switch (request.TypeRequest)
            {
                case TypeRequest.Auth:
                    // Call the authentication method
                    ResponseAuthentication response = await helper.Authentication(request);
                    // Serialize the response and send it to the client
                    string responseString = JsonConvert.SerializeObject(response);
                    byte[] responseData = Encoding.UTF8.GetBytes(responseString);
                    handler.Send(responseData);
                    Console.WriteLine("Sent message to client {0}: {1}", handler.RemoteEndPoint.ToString(), responseString);
                    Onserver.Add(response.Name);
                    break;
            }
            switch (UserInServerRequest.typeRequest)
            {
                case TypeRequest.GetUserInServer:

                    UserInServer responses = await helper.ServerConnectionUser(UserInServerRequest);
                    string responseStrings = JsonConvert.SerializeObject(responses);
                    byte[] responseDatas = Encoding.UTF8.GetBytes(responseStrings);

                    handler.Send(responseDatas);
                    Console.WriteLine("Sent message to client {0}: {1}", handler.RemoteEndPoint.ToString(), responseStrings);
                    break;
            }

            // Close the connection with the client
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
            clients.Remove(handler);
        }

    }
}
