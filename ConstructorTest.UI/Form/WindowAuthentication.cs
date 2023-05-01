using ConstructorTest.UI.Connection.Helper;
using ConstructorTest.UI.Form.FormComunication;
using Data;
using Data.ResponseDto;
using Newtonsoft.Json;

namespace ConstructorTest.UI.Form
{
    public partial class WindowAuthentication : System.Windows.Forms.Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        TCP TCP = new TCP();
        public string ParentProperty { get; set; }
        // Create a new Label instance
        Label dynamicLabel = new Label();
        public WindowAuthentication()
        {
            InitializeComponent();
        }

        private async void BLogin_Click(object sender, EventArgs e)
        {
            // Setting properties for dynamic Label
            dynamicLabel.Text = "";
            dynamicLabel.Location = new Point(170, 20);
            dynamicLabel.AutoSize = true;

            // Adding a dynamic Label to the form
            this.Controls.Add(dynamicLabel);

            RequestAuthentication requestAuthentication = new RequestAuthentication()
            {
                Name = textBox1.Text,
                PasswordHasher = textBox2.Text
            };

            var resultString = await TCP.SendRequest<RequestAuthentication>(requestAuthentication);
            if (resultString != null)
            {
                var result = JsonConvert.DeserializeObject<ResponseAuthentication>(resultString);
                if (result == null || !result.Success)
                {
                    dynamicLabel.Text = "Password or UserName error";
                    dynamicLabel.BackColor = Color.Red;
                }
                else
                {
                    dynamicLabel.Text = "hello";
                    dynamicLabel.BackColor = Color.Green;
                    if (result.Name == "Admin")
                    {
                        TestServer server = new TestServer();
                        this.Hide();
                        server.Show();
                    }
                    else
                    {
                        TestClient.UserId = (Guid)result.UserId;

                        using (TestClient testclient = new TestClient())
                        {
                            testclient.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                dynamicLabel.Text = "Connection Loss";
                dynamicLabel.BackColor = Color.Red;

            }
        }

    }
}
