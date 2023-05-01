using ConstructorTest.UI.Form.SupportForm;
using Data;
using Data.Data.Identity;
using Data.Data.InformationData;
using Data.Data.TestCreate;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Xml.Serialization;

namespace ConstructorTest.UI.Form.FormComunication
{
    public partial class TestServer : System.Windows.Forms.Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        int gridRoleIndex = -1;
        int gridUserIndex = -1;
        int gridUserGroupIndex = -1;
        int gridTestOnServerIndex = -1;
        int gridAsignTestToUserIndex = -1;
        int gridResultIndex = -1;
        Test testComponent = new Test();
        int IndexLoadTest;
        string RootfilePath = "";
        string SourceFilePath = "";
        public TestServer()
        {
            InitializeComponent();



            GridTestOnServer.Columns.Add("Id", "Id");
            GridTestOnServer.Columns.Add("AuthorUserName", "AuthorUserName");
            GridTestOnServer.Columns.Add("Title", "Title");
            GridTestOnServer.Columns.Add("Description", "Description");
            GridTestOnServer.Columns.Add("Info", "Info");
            GridTestOnServer.Columns.Add("Percent", "Percent");
            GridTestOnServer.Columns.Add("Root", "Root");
            InitializeGridRole();
            //
            InitializeGridUser();
            //
            InitializeGridTestOnServer();
            //
            InitializeGridAsignTestToUser();
            //
            InitializeGridResult();
            //

        }
        #region TabRole
        private async void CreateRole_Click(object sender, EventArgs e)
        {
            using (RoleAddForm createTest = new RoleAddForm())
            {
                createTest.ShowDialog();

                if (createTest.DialogResult == DialogResult.OK)
                {
                    await InitializeGridRole();

                }
            }
        }

        private void EditRole_Click(object sender, EventArgs e)
        {
            if (gridRoleIndex != -1 && GridRole.Rows.Count > gridRoleIndex)
            {
                using (RoleAddForm createTest = new RoleAddForm())
                {
                    createTest.Id = new Guid(GridRole.Rows[gridRoleIndex].Cells[0].Value.ToString());
                    createTest.Name = GridRole.Rows[gridRoleIndex].Cells[1].Value.ToString();
                    createTest.FullName = GridRole.Rows[gridRoleIndex].Cells[2].Value.ToString();

                    createTest.ShowDialog();

                    if (createTest.DialogResult == DialogResult.OK)
                    {

                    }
                }
            }
            InitializeGridRole();
        }

        private void UpdateRole_Click(object sender, EventArgs e)
        {
            if (gridRoleIndex != -1 && GridRole.Rows.Count > gridRoleIndex)
            {
                var roleId = new Guid(GridRole.Rows[gridRoleIndex].Cells[0].Value.ToString());
                ApplicationRole roleToDelete = context.ApplicationRoles.Find(roleId);

                // Delete obj with context
                if (roleToDelete != null)
                {
                    context.ApplicationRoles.Remove(roleToDelete);
                    context.SaveChanges();
                }
                InitializeGridRole();
            }
        }
        #endregion
        #region TabUser
        private void AddNewUser_Click(object sender, EventArgs e)
        {
            using (FormAddUser formAddUser = new FormAddUser())
            {
                formAddUser.ShowDialog();

                if (formAddUser.DialogResult == DialogResult.OK)
                {
                    InitializeGridUser();

                }
            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (gridUserIndex != -1 && GridUser.Rows.Count > gridUserIndex)
            {
                var id = new Guid(GridUser.Rows[gridUserIndex].Cells[0].Value.ToString());
                var ApplicationRoleId = new Guid(GridUser.Rows[gridUserIndex].Cells[1].Value.ToString());

                ApplicationUser applicationUser = new ApplicationUser()
                {
                    Id = id,
                    UserName = GridUser.Rows[gridUserIndex].Cells["UserName"].Value.ToString(),
                    ApplicationRoleId = ApplicationRoleId,
                    NormalizedUserName = GridUser.Rows[gridUserIndex].Cells["NormalizedUserName"].Value.ToString(),
                    Email = GridUser.Rows[gridUserIndex].Cells["Email"].Value.ToString(),
                    NormalizedEmail = GridUser.Rows[gridUserIndex].Cells["NormalizedEmail"].Value.ToString(),
                    PasswordHash = GridUser.Rows[gridUserIndex].Cells["PasswordHash"].Value.ToString(),
                    PhoneNumber = GridUser.Rows[gridUserIndex].Cells["PhoneNumber"].Value.ToString()
                };
                FormAddUser.ApplicationUser = applicationUser;
                using (FormAddUser formAddUser = new FormAddUser())
                {
                    formAddUser.ShowDialog();

                    if (formAddUser.DialogResult == DialogResult.OK)
                    {

                    }
                }
            }
            InitializeGridUser();
        }

        private void UpdateUserGroup_Click(object sender, EventArgs e)
        {
            if (gridUserIndex != -1 && GridUser.Rows.Count > gridUserIndex)
            {
                var roleId = new Guid(GridUser.Rows[gridUserIndex].Cells[0].Value.ToString());
                ApplicationUser applicationUserDelete = context.ApplicationUsers.Find(roleId);

                // Удаление объекта из контекста
                if (applicationUserDelete != null)
                {
                    context.ApplicationUsers.Remove(applicationUserDelete);
                    context.SaveChanges();
                }
                InitializeGridUser();
            }
        }
        #endregion
        #region TabTest

        private void LoadTest_Click(object sender, EventArgs e)
        {
            GridTestOnServer.DataSource = null;
            GridTestOnServer.Columns.Add("Id", "Id");
            GridTestOnServer.Columns.Add("AuthorUserName", "AuthorUserName");
            GridTestOnServer.Columns.Add("Title", "Title");
            GridTestOnServer.Columns.Add("Description", "Description");
            GridTestOnServer.Columns.Add("Info", "Info");
            GridTestOnServer.Columns.Add("Percent", "Percent");
            GridTestOnServer.Columns.Add("Root", "Root");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Test File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Download file
                string filePath = openFileDialog.FileName;
                SourceFilePath = filePath;
                // Deserialize file
                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                Test test;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        test = (Test)serializer.Deserialize(reader);
                        if (test.id == null)
                        {
                            MessageBox.Show("EmptyId");
                        }
                        testComponent = test;
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("File format is not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                textBox1.Text = testComponent.Author;
                textBox2.Text = testComponent.Title;
                textBox3.Text = testComponent.Description;
                textBox4.Text = testComponent.InfoTestTaker;
                textBox5.Text = testComponent.CountQuestion.ToString();
                textBox6.Text = testComponent.MaxPoint.ToString();
                numericUpDown1.Value = testComponent.Percent;


                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(GridTestOnServer);

                // pull value
                row.Cells[0].Value = testComponent.id.ToString();
                row.Cells[1].Value = testComponent.Author;
                row.Cells[2].Value = testComponent.Title;
                row.Cells[3].Value = testComponent.Description;
                row.Cells[4].Value = testComponent.InfoTestTaker;
                row.Cells[5].Value = testComponent.Percent;

                string fileName = filePath;

                string name = Path.GetFileNameWithoutExtension(fileName);
                string extension = Path.GetExtension(fileName);
                string destinationFolder = @"..\..\..\Source\TestFileXML\";
                string destinationFile = Path.Combine(destinationFolder, GetUniqueFileName(Path.Combine(destinationFolder, name) + '.' + extension));

                row.Cells[6].Value = destinationFile;

                RootfilePath = destinationFile;
                // add row in DataGridView

                GridTestOnServer.Rows.Add(row);
                IndexLoadTest = GridTestOnServer.Rows.Count - 1;
            }
        }
        private void SaveTest_Click(object sender, EventArgs e)
        {
            File.Copy(SourceFilePath, RootfilePath);

            ApplicationDbContext applicationDbContext = new ApplicationDbContext();

            var authorI = applicationDbContext.ApplicationUsers.FirstOrDefault(x => x.UserName == testComponent.Author);
            var FileName = Path.GetFileName(RootfilePath);
            applicationDbContext.TestOnServers.Add(new Data.Data.InformationData.TestOnServer()
            {
                Id = Guid.NewGuid(),
                AuthorId = authorI.Id,
                AuthorUserName = authorI.UserName,
                FileName = FileName,
                Title = testComponent.Title,
                Description = testComponent.Description,
                Info = testComponent.InfoTestTaker,
                Percent = testComponent.Percent,
                CountQuestion = testComponent.CountQuestion,
                MaximumPoint = testComponent.MaxPoint,
                Root = RootfilePath
            });
            applicationDbContext.SaveChanges();
            InitializeGridTestOnServer();

        }
        private string GetUniqueFileName(string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string fileExt = Path.GetExtension(filePath);
            string dirPath = Path.GetDirectoryName(filePath);
            string newFileName = fileName + fileExt;
            int i = 1;
            while (File.Exists(Path.Combine(dirPath, newFileName)))
            {
                newFileName = fileName + "_" + i + fileExt;
                i++;
            }
            return newFileName;
        }
        private void AsignNewTest_Click(object sender, EventArgs e)
        {
            using (AsignNewTest createTest = new AsignNewTest())
            {
                createTest.ShowDialog();

                if (createTest.DialogResult == DialogResult.OK)
                {

                }
            }

            InitializeGridAsignTestToUser();
        }
        private void CreateTest_Click(object sender, EventArgs e)
        {
            MainConstructor mainConstructor = new MainConstructor();
            mainConstructor.Show();
            this.Hide();
        }
        #endregion

        #region TabResults
        private void BReport_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Grid_CellClick
        private void GridRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridRoleIndex = e.RowIndex;
        }

        private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridUserIndex = e.RowIndex;
        }

        private void GridUserGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridUserGroupIndex = e.RowIndex;
        }

        private void GridTestOnServer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridTestOnServerIndex = e.RowIndex;
            if (gridTestOnServerIndex != -1 && GridTestOnServer.Rows[gridTestOnServerIndex].Cells["Id"] != null && GridTestOnServer.Rows.Count < gridTestOnServerIndex)
            {
                var StringId = GridTestOnServer.Rows[gridTestOnServerIndex].Cells["Id"]?.Value.ToString()?? "";
                if(!string.IsNullOrEmpty(StringId))
                {
                    var Id = new Guid(StringId);
                    ApplicationDbContext applicationDbContext = new ApplicationDbContext();
                    var data = applicationDbContext.TestOnServers.FirstOrDefault(x => x.Id == Id);
                    textBox1.Text = data.AuthorUserName;
                    textBox2.Text = data.Title;
                    textBox3.Text = data.Description;
                    textBox4.Text = data.Info;
                    textBox5.Text = data.CountQuestion.ToString() ?? "";
                    textBox6.Text = data.MaximumPoint.ToString() ?? "";
                    numericUpDown1.Value = data.Percent;
                }
                InitializeGridAsignTestToUser();
            }
        }

        private void GridAsignTestToUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridAsignTestToUserIndex = e.RowIndex;
        }

        private void GridResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridResultIndex = e.RowIndex;
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
        #endregion
        #region initializeDataGrid

        public async Task InitializeGridRole()
        {
            ApplicationDbContext contextGrid = new ApplicationDbContext();
            GridRole.DataSource = await contextGrid.ApplicationRoles.ToListAsync();
        }
        public async Task InitializeGridUser()
        {
            ApplicationDbContext contextGrid = new ApplicationDbContext();
            GridUser.DataSource = await contextGrid.
                ApplicationUsers
                .Include(x => x.ApplicationRole)
                .Select(x => new
                {
                    x.Id,
                    x.ApplicationRoleId,
                    x.ApplicationRoleName,
                    x.UserName,
                    x.NormalizedUserName,
                    x.Email,
                    x.NormalizedEmail,
                    x.PasswordHash,
                    x.PhoneNumber,
                }).ToListAsync();

        }

        public async Task InitializeGridTestOnServer()
        {
            GridTestOnServer.Columns.Clear();
            ApplicationDbContext contextGrid = new ApplicationDbContext();
            var dataTestOnServers = contextGrid.TestOnServers.Select(x => new
            {
                Id = x.Id,
                AuthorUserName = x.Author.UserName,
                Title = x.Title,
                Description = x.Description,
                Info = x.Info,
                Percent = x.Percent,
                Root = x.Root
            }).ToList();
            GridTestOnServer.AllowUserToAddRows = true; // enable adding new rows
            GridTestOnServer.ReadOnly = true;
            if (dataTestOnServers.Any())
            {
                GridTestOnServer.DataSource = dataTestOnServers;
            }

        }
        public async Task InitializeGridAsignTestToUser()
        {
            if (gridTestOnServerIndex != -1)
            {
                ApplicationDbContext contextGrid = new ApplicationDbContext();

                var Id = new Guid(GridTestOnServer.Rows[gridTestOnServerIndex].Cells["Id"].Value.ToString());
                var TestOnServerId = contextGrid.TestOnServers.FirstOrDefault(x => x.Id == Id);


                var dataTestOnServers = contextGrid.AsignTestUsers.Where(x => x.TestDateTime == null && x.TestOnServerId == TestOnServerId.Id).Select(x => new
                {
                    Id = x.Id,
                    UserName = x.User.UserName,
                    TestScore = x.TestScore,
                    TimeForTheTest = x.TimeForTheTest,
                    CompleteTestDateTime = x.CompleteTestDateTime,
                    TestDateTime = x.TestDateTime,
                }).ToList();

                GridAsignTestToUser.DataSource = dataTestOnServers;
            }

        }

        public async Task InitializeGridResult()
        {
            ApplicationDbContext contextGrid = new ApplicationDbContext();
            var dataTestOnServers = contextGrid.AsignTestUsers.Where(x => x.TestDateTime != null).Select(x => new
            {
                Id = x.Id,
                UserName = x.User.UserName,
                GroupName = x.User.ApplicationRole,
                TestScore = x.TestScore,
                TestDateTime = x.TestDateTime,
                AnswerRoot = x.AnswerRoot,
            }).ToList();
            GridResult.DataSource = dataTestOnServers;
        }
        #endregion

        private void DeleteTestOnServer_Click(object sender, EventArgs e)
        {
            if (gridTestOnServerIndex != -1 && GridTestOnServer.Rows.Count > gridTestOnServerIndex)
            {
                var testOnServerId = new Guid(GridTestOnServer.Rows[gridTestOnServerIndex].Cells[0].Value.ToString());
                TestOnServer testOnServerDeleteToDelete = context.TestOnServers.Find(testOnServerId);
                string root = testOnServerDeleteToDelete.Root;
                File.Delete(root);
                // delete obj in context
                if (testOnServerDeleteToDelete != null)
                {
                    context.TestOnServers.Remove(testOnServerDeleteToDelete);
                    context.SaveChanges();
                }

                InitializeGridTestOnServer();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationDbContext contextGrid = new ApplicationDbContext();
            var query = contextGrid.AsignTestUsers.AsQueryable(); // start with all records in the table

            // apply filters based on the selected checkboxes
            if (!RBSelectAllUsers.Checked) // if "Show All" is not checked
            {
                if (RBSelectUsers.Checked && !string.IsNullOrEmpty(comboBox1.Text)) // if "Filter by User" is checked and a user is selected in cmbUsers
                {
                    string selectedUserName = comboBox1.Text;
                    query = query.Where(x => x.User.UserName == selectedUserName);
                }

                if (RBSelectGroup.Checked && !string.IsNullOrEmpty(comboBox2.Text)) // if "Filter by Role" is checked and a role is selected in cmbRoles
                {
                    string selectedRoleName = comboBox2.Text;
                    query = query.Where(x => x.User.ApplicationRole.Name.Contains(selectedRoleName));
                }
            }

            // select the columns you want to display
            var dataTestOnServers = query.Where(x => x.TestDateTime != null).Select(x => new
            {
                Id = x.Id,
                UserName = x.User.UserName,
                GroupName = x.User.ApplicationRole,
                TestScore = x.TestScore,
                TestDateTime = x.TestDateTime,
                AnswerRoot = x.AnswerRoot,
            }).ToList();

            GridResult.DataSource = dataTestOnServers; // bind the filtered data to the grid

        }

        private void TBResults_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = context.ApplicationUsers.ToList();
            comboBox2.DataSource = context.ApplicationRoles.ToList();
        }

        private void DeleteTest_Click(object sender, EventArgs e)
        {
            if (gridTestOnServerIndex != -1 && GridTestOnServer.Rows[gridTestOnServerIndex].Cells["Id"] != null && GridTestOnServer.Rows.Count < gridTestOnServerIndex)
            {
                var TestOnServerId = new Guid(GridTestOnServer.Rows[gridTestOnServerIndex].Cells["Id"].Value.ToString());

                ApplicationDbContext context = new ApplicationDbContext();
                var RemoveItem = context.AsignTestUsers.Where(x => x.TestOnServerId == TestOnServerId).ToList();
                context.AsignTestUsers.RemoveRange(RemoveItem);
                context.SaveChanges();

                var RemoveTest = context.TestOnServers.FirstOrDefault(x => x.Id == TestOnServerId);
                context.TestOnServers.Remove(RemoveTest);
                context.SaveChanges();
                InitializeGridTestOnServer();
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            // Show a tooltip when hovering over the text box
            toolTip1.SetToolTip(textBox1, textBox1.Text);
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, textBox2.Text);

        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox3, textBox3.Text);

        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox4, textBox4.Text);

        }
    }
}
