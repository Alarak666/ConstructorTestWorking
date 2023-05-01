using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Net.Sockets;
class Program
{
    static async void Main()
    {
       

        IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
        using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(ipPoint);
        socket.Listen();
        Console.WriteLine("Сервер запущен. Ожидание подключений...");
        // получаем входящее подключение
        using Socket client = await socket.AcceptAsync();
        // получаем адрес клиента
        Console.WriteLine($"Адрес подключенного клиента: {client.RemoteEndPoint}");
    }

}