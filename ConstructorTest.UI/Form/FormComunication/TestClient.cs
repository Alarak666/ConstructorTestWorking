using ConstructorTest.UI.Form.SupportForm;
using Data;
using System.Data;
using System.Windows.Forms;

namespace ConstructorTest.UI.Form.FormComunication
{
    public partial class TestClient : System.Windows.Forms.Form
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public static Guid UserId
        { get; set; } 

        public int gridIndex;

        public TestClient()
        {
            // Assuming you have a DataGridView control named "GridUser" on your form
            InitializeComponent();

            InitializeUser();
            InitializeREsult();
        }
        public void InitializeUser()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            GridUser.DataSource = null;
            GridUser.DataSource = context.AsignTestUsers.Where(x => x.UserId == UserId).Select(x => new
            {
                Id = x.Id,
                TestOnServerName = x.TestOnServer.FileName,
                UserUserName = x.UserUserName,
                CompleteTestDateTime = x.CompleteTestDateTime,
                TimeForTheTest = x.TimeForTheTest,
                TestDateTime = x.TestDateTime,
                AnswerRoot = x.AnswerRoot
            }).ToList();
        }
        public void InitializeREsult()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            GridResult.DataSource = null;

            GridResult.DataSource = context.AsignTestUsers.Where(x => x.UserId == UserId).Select(x => new
            {
                Id = x.Id,
                UserUserName = x.UserUserName,
                CompleteTestDateTime = x.CompleteTestDateTime,
                TimeForTheTest = x.TimeForTheTest,
                TestDateTime = x.TestDateTime,
                AnswerRoot = x.AnswerRoot,
                Score = x.TestScore
            }).ToList();
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            InitializeUser();
            InitializeREsult();
        }

        private void BGetTested_Click(object sender, EventArgs e)
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            var testId = new Guid(GridUser.Rows[gridIndex].Cells["Id"].Value.ToString());
            var testComplete = applicationDbContext.AsignTestUsers.FirstOrDefault(x => x.Id == testId);

            if (testComplete?.CountContinue > 0)
            {
                Testing.AsignTestId = testId;

                using (Testing testing = new Testing())
                {
                    testing.ShowDialog();

                    if (testing.DialogResult == DialogResult.OK)
                    {
                        InitializeUser();
                        InitializeREsult();
                    }
                }
            }
            else
            {
                MessageBox.Show($"Test complete, your score {testComplete.TestScore}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowAuthentication windowAuthentication = new WindowAuthentication();
            windowAuthentication.Show();
            this.Hide();
        }

        private void GridResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the AnswerRoot field in the clicked row
                Guid asignTestId = new Guid(GridResult.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                AnswerUserTest.AsignTestId = asignTestId;
                using (AnswerUserTest testing = new AnswerUserTest())
                {
                    testing.ShowDialog();
                }
            }
        }

        private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridIndex = e.RowIndex;
        }

        private void GridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}