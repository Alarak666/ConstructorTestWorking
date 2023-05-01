using Azure.Core;
using Azure;
using ConstructorTest.UI.Form;
using ConstructorTest.UI.Form.FormComunication;
using Server;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ConstructorTest.UI.Form.SupportForm;

namespace ConstructorTest.UI
{

    public class Program
    {
        private static TcpClient client;
        private static NetworkStream stream;
        [STAThread]
        static void Main()
        {
            {
              

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                ApplicationConfiguration.Initialize();
                Application.Run(new TestServer());
            }
        }
   
    }
}