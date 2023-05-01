using Data.ResponseDto;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class Client
    {
        TcpClient client = new TcpClient();

        public async void Connect()
        {
            try
            {
                await client.ConnectAsync("127.0.0.1", 12345); // Подключение к серверу по IP-адресу и порту

                NetworkStream stream = client.GetStream();

                // Создание объекта RequestAuthentication
                RequestAuthentication request = new RequestAuthentication
                {
                    Name = "Admin",
                    PasswordHasher = "0"
                };

                // Сериализация объекта RequestAuthentication в JSON
                string requestMessage = JsonConvert.SerializeObject(request);

                // Конвертация сообщения в байты
                byte[] requestBytes = Encoding.UTF8.GetBytes(requestMessage);

                // Отправка сообщения на сервер
                await stream.WriteAsync(requestBytes, 0, requestBytes.Length);

                // Чтение ответа от сервера
                byte[] responseBytes = new byte[client.ReceiveBufferSize];
                int bytesRead = await stream.ReadAsync(responseBytes, 0, client.ReceiveBufferSize);
                string responseMessage = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                // Десериализация ответа от сервера
                ResponseAuthentication response = JsonConvert.DeserializeObject<ResponseAuthentication>(responseMessage);

                Console.WriteLine(response.Name);
                Console.WriteLine(response.UserId);
                Console.WriteLine(response.Success);
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке
                Console.WriteLine("Error connecting to the server: " + ex.Message);

                // Повторная попытка подключения через 5 секунд
                await Task.Delay(5000);
                Connect();
            }
        }
    }
}
