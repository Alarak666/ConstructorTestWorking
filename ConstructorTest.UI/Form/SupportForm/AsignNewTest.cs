using Data;
using Data.Data.InformationData;
using System;
using System.Data;

namespace ConstructorTest.UI.Form.SupportForm
{
    public partial class AsignNewTest : System.Windows.Forms.Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        int dataGridIndex = -1;
        public AsignNewTest()
        {
            InitializeComponent();
            var DataTestOnServer = context.TestOnServers.Select(x => new TestOnServer { Id = x.Id, FileName = x.FileName }).ToList();
            comboBox1.DataSource = DataTestOnServer;
            comboBox1.DisplayMember = "FileName";
            comboBox1.ValueMember = "Id";
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select"; // set the column header text
            checkboxColumn.Name = "Select"; // set the column header text
            dataGridView1.Columns.Add(checkboxColumn);
            dataGridView1.DataSource = context
                .ApplicationUsers.Select(x => new
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    NormalizedUserName = x.NormalizedUserName,
                    ApplicationRoleName = x.ApplicationRoleName,
                    ApplicationRoleId = x.ApplicationRoleId
                }).ToList();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                var combobox = (TestOnServer)comboBox1.SelectedItem;
                var item = context.TestOnServers.FirstOrDefault(x => x.FileName == combobox.FileName);
                label1.Text = item.Id.ToString();
                label2.Text = item.AuthorId.ToString();
                label3.Text = item.Title.ToString();
                label4.Text = item.Description.ToString();
                label5.Text = item.Info.ToString();
                label6.Text = item.Percent.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridIndex = e.RowIndex;
        }

        private void BAssignANewTest_Click(object sender, EventArgs e)
        {
            int minutes = (int)numericUpDown2.Value;
            TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);
            if (dataGridIndex < dataGridView1.Rows.Count && dataGridIndex != -1 && numericUpDown1.Value > 0)
            {
                ApplicationDbContext application = new ApplicationDbContext();

                if (radioButton1.Checked)
                {
                    var itemUserId = application.ApplicationUsers.FirstOrDefault(x => x.Id == new Guid(dataGridView1.Rows[dataGridIndex].Cells["Id"].Value.ToString()));
                 
                    var item = new AsignTestUser()
                    {
                        Id = Guid.NewGuid(),
                        UserId = itemUserId.Id,
                        TimeForTheTest = timeSpan,
                        UserUserName = itemUserId.UserName,
                        UserNormalizedUserName = itemUserId.NormalizedUserName,
                        TestOnServerId = new Guid(label1.Text),
                        CountContinue = numericUpDown1.Value
                    };

                    application.AsignTestUsers.Add(item);
                    application.SaveChanges();
                }

                if (radioButton2.Checked)
                {
                    var data = new List<AsignTestUser>() { };
                    var itemUserId = application.ApplicationUsers.FirstOrDefault(x => x.Id == new Guid(dataGridView1.Rows[dataGridIndex].Cells["Id"].Value.ToString()));

                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                       var userId = application.ApplicationUsers.FirstOrDefault(x => x.Id == new Guid(item.Cells["Id"].Value.ToString()));

                        if (itemUserId.ApplicationRoleId == userId.ApplicationRoleId)
                        {
                            data.Add(new AsignTestUser()
                            {
                                Id = Guid.NewGuid(),
                                UserId = userId.Id,
                                TimeForTheTest = timeSpan,
                                UserUserName = userId.UserName,
                                UserNormalizedUserName = userId.NormalizedUserName,
                                TestOnServerId = new Guid(label1.Text),
                                CountContinue = numericUpDown1.Value
                            });
                           
                        }
                    }
                    application.AsignTestUsers.AddRange(data);
                    application.SaveChanges();
                }

                if (radioButton3.Checked)
                {
                    var data = new List<AsignTestUser>() { };

                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        var obk = item.Cells["Select"].Value;
                        if (obk != null && (bool)obk)
                        {
                            var itemUserId = application.ApplicationUsers.FirstOrDefault(x => x.Id == new Guid(item.Cells["Id"].Value.ToString()));
                            data.Add(new AsignTestUser()
                            {
                                Id = Guid.NewGuid(),
                                UserId = itemUserId.Id,
                                TimeForTheTest = timeSpan,
                                UserUserName = itemUserId?.UserName ?? "",
                                UserNormalizedUserName = itemUserId?.NormalizedUserName ?? "",
                                TestOnServerId = new Guid(label1.Text),
                                CountContinue = numericUpDown1.Value
                            });
                        }
                    }
                    application.AsignTestUsers.AddRange(data);
                    application.SaveChanges();
                }
                MessageBox.Show("Added user for new asign");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
