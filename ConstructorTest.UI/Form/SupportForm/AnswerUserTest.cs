using Data;
using Data.Data.InformationData;
using Data.Data.TestCreate;
using System.Xml.Serialization;

namespace ConstructorTest.UI.Form.SupportForm
{
    public partial class AnswerUserTest : System.Windows.Forms.Form
    {
        List<UserAnswer> UserAnswers = new List<UserAnswer>();
        public static Guid AsignTestId { get; set; }

        public AnswerUserTest()
        {
            InitializeComponent();
            InitializeAsignData();
            foreach (var question in UserAnswers)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = question.Question;
                groupBox.Dock = DockStyle.Top;
                groupBox.AutoSize = true;

                for (int i = 0; i < question.Answer.Count; i++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = question.Answer[i];
                    checkBox.Dock = DockStyle.Top;
                    checkBox.Enabled = false;
                    checkBox.Checked = question.IsSelected[i];
                    groupBox.Controls.Add(checkBox);
                }

                PanelAnswer.Controls.Add(groupBox);
            }
        }

        private void InitializeAsignData()
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            var asignTestUsers = applicationDbContext.AsignTestUsers.FirstOrDefault(x => x.Id == AsignTestId);
            string root = asignTestUsers.AnswerRoot;

            if (File.Exists(root))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<UserAnswer>));

                using (StreamReader streamReader = new StreamReader(root))
                {
                    UserAnswers = (List<UserAnswer>)serializer.Deserialize(streamReader);
                }
            }
            else
            {
                MessageBox.Show("File not find, deleted or out of dated");
            }
        }
    }
}
