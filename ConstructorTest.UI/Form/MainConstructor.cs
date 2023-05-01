using ConstructorTest.UI.Form.FormComunication;
using ConstructorTest.UI.Form.SupportForm;
using Data;
using Data.Data.TestCreate;
using System.Xml.Serialization;

namespace ConstructorTest.UI.Form
{
    public partial class MainConstructor : System.Windows.Forms.Form
    {
        ApplicationDbContext context;
        int selectedRowIndex = -1;
        private Test testComponent = new Test();

        public MainConstructor()
        {
            context = new ApplicationDbContext();
            InitializeComponent();
            GridQuestions.Columns.Add("TextQuestion", "Text of question");
            GridQuestions.Columns.Add("Point", "Point");
            GridQuestions.Columns.Add("CountAnswer", "Count of answer");
            GridQuestions.ReadOnly = true;
            foreach (DataGridViewColumn column in GridQuestions.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            var text = context.ApplicationUsers.FirstOrDefault(x => x.UserName == "Admin");
            textBox1.Text = text.UserName.ToString();
        }
        private void GridQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            if (testComponent.listTests.Count > 0 && GridQuestions.Rows.Count - 1 > selectedRowIndex)
                Picture.ImageLocation = (testComponent.listTests[selectedRowIndex].Photo ?? string.Empty).ToString();
        }
        private void GridQuestion_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void BAddQuestion_Click(object sender, EventArgs e)
        {
            CreateTest.Questions = new ListTest();
            using (CreateTest createTest = new CreateTest())
            {

                createTest.ShowDialog();

                ListTest result = (ListTest)createTest.Tag;
                if (createTest.DialogResult == DialogResult.OK)
                {
                    int index = GridQuestions.Rows.Add();

                    GridQuestions.Rows[index].Cells[0].Value = result.Question;
                    GridQuestions.Rows[index].Cells[1].Value = result.Point;
                    GridQuestions.Rows[index].Cells[2].Value = result.Answers.Count;
                    testComponent.listTests.Add(result);
                    Picture.ImageLocation = result.Photo ?? string.Empty;
                }
            }
        }
        private void BEditQuestion_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1 && testComponent.listTests.Count > 0)
                MessageBox.Show("Need select row");
            CreateTest.Questions = testComponent.listTests[selectedRowIndex];

            using (CreateTest createTest = new CreateTest())
            {

                createTest.ShowDialog();

                ListTest result = (ListTest)createTest.Tag;
                if (createTest.DialogResult == DialogResult.OK)
                {
                    testComponent.listTests[selectedRowIndex] = result;

                    GridQuestions.Rows[selectedRowIndex].Cells[0].Value = result.Question;
                    GridQuestions.Rows[selectedRowIndex].Cells[1].Value = result.Point;
                    GridQuestions.Rows[selectedRowIndex].Cells[2].Value = result.Answers.Count;
                }
            }
        }
        private void BDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1 || (selectedRowIndex == 0 && GridQuestions.Rows.Count <= 1))
            {
                MessageBox.Show("Need select row");
                return;
            }
            if (selectedRowIndex >= 0 && selectedRowIndex < testComponent.listTests.Count)
            {
                // Remove an item from the Test.listTests list
                testComponent.listTests.RemoveAt(selectedRowIndex);
                GridQuestions.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("Need select row");

            }

            // Remove a row from the GridQuestions DataGridView
        }

        private void BPicture_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex != -1)
            {
                using (PhotoFullSize photoFullSize = new PhotoFullSize())
                {
                    if (testComponent?.listTests != null && testComponent.listTests.Count > selectedRowIndex && testComponent.listTests[selectedRowIndex] != null)
                    {
                        // Perform actions with photo

                        string photo = testComponent.listTests[selectedRowIndex].Photo;
                        photoFullSize.UrlPhoto = photo;
                        photoFullSize.ShowDialog();
                    }



                }
            }
            else
                MessageBox.Show("Photo is empty");
        }

        private void GridQuestions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int pointSum = 0;
            int answerCount = 0;

            foreach (DataGridViewRow row in GridQuestions.Rows)
            {
                if (row.Cells["Point"].Value != null)
                {
                    pointSum += Convert.ToInt32(row.Cells["Point"].Value);
                }

                if (row.Cells["CountAnswer"].Value != null)
                {
                    answerCount++;
                }
            }
            textBox5.Text = answerCount.ToString();
            textBox6.Text = pointSum.ToString();
        }

        private void createNewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainConstructor mainForm = new MainConstructor();
            mainForm.Show();
        }

        private void openTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Test File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                Test test;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        test = (Test)serializer.Deserialize(reader);
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

                foreach (var item in testComponent.listTests)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridQuestions);

                    row.Cells[0].Value = item.Question;
                    row.Cells[1].Value = item.Point;
                    row.Cells[2].Value = item.Answers.Count;

                    // add row in DataGridView
                    GridQuestions.Rows.Add(row);
                }

            }
        }

        private void saveTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal result;
            testComponent.Author = textBox1.Text;
            testComponent.id = Guid.NewGuid();
            testComponent.Title = textBox2.Text;
            testComponent.Description = textBox3.Text;
            testComponent.InfoTestTaker = textBox4.Text;
            if (decimal.TryParse(textBox5.Text, out result))
            {
                testComponent.CountQuestion = (int)result;
            }
            if (decimal.TryParse(textBox6.Text, out result))
            {
                testComponent.MaxPoint = result;
            }
            testComponent.Percent = numericUpDown1.Value;

            // Call the save to XML method
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Test File";
            saveFileDialog.Filter = "XML Files (.xml)|.xml"; // Add filter for XML files

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Create a serializer object
                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                // Create a stream for writing to the file
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    // Serialize the Test object to the stream
                    serializer.Serialize(streamWriter, testComponent);
                }
            }
        }

        private void closeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (testComponent.listTests.Any())
            {
                var result = MessageBox.Show("Do you want to save changes before closing?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveTestToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            TestServer testServer = new TestServer();
            testServer.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            if (testComponent.listTests.Any())
            {
                var result = MessageBox.Show("Do you want to save changes before closing?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveTestToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            TestServer testServer = new TestServer();
            testServer.Show();
            this.Hide();
        }
    }
}
