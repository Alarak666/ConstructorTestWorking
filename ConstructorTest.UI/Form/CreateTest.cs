using Bogus;
using ConstructorTest.UI.Form.SupportForm;
using Data.Data.TestCreate;

namespace ConstructorTest.UI.Form
{
    public partial class CreateTest : System.Windows.Forms.Form
    {

        public static ListTest Questions
        {
            get;set;
        } = new ListTest();

        public CreateTest()
        {
            InitializeComponent();
            GridAnswer.Columns.Add("Answer", "Answer");

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "CorrectAnswer";
            dgvCmb.HeaderText = "CorrectAnswer";
            GridAnswer.Columns.Add(dgvCmb);

            if (Questions != null)
            {
                textBox1.Text = Questions.Question;
                numericUpDown1.Value = Questions.Point;
                pictureBox1.ImageLocation = Questions.Photo;

                foreach (var item in Questions.Answers)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridAnswer);

                    row.Cells[0].Value = item;
                    row.Cells[1].Value = Questions.CorectAnswers.Contains(item);

                    GridAnswer.Rows.Add(row);
                }

            }
        }


        private int selectedRowIndex;

        private void GridAnswer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }
        private void BEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0 && selectedRowIndex < GridAnswer.Rows.Count - 1)
                {
                    // Get the selected row from GridAnswer

                    DataGridViewRow selectedRow = GridAnswer.Rows[selectedRowIndex];

                    // Create an instance of the AddForm and pass the data from the selected row to it
                    bool answerbool = (bool)selectedRow?.Cells["CorrectAnswer"]?.Value;
                    using (AddForm addForm = new AddForm())
                    {
                        if (selectedRow != null && selectedRow.Cells["Answer"] != null && selectedRow.Cells["Answer"].Value != null)
                        {
                            addForm.Answer = selectedRow.Cells["Answer"].Value.ToString();
                        }
                        else
                        {
                            addForm.Answer = string.Empty;
                        }
                        addForm.TrueAnswer = answerbool;
                        addForm.ShowDialog();

                        var result = (dynamic)addForm.Tag;
                        if (addForm.DialogResult == DialogResult.OK)
                        {
                            selectedRow.Cells["Answer"].Value = result.Answer;
                            selectedRow.Cells["CorrectAnswer"].Value = result.TrueAnswer;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void BAdd_Click(object sender, EventArgs e)
        {
            using (AddForm addForm = new AddForm())
            {
                addForm.ShowDialog();

                if (addForm.DialogResult == DialogResult.OK)
                {
                    // Get the passed data from the Tag property
                    var result = (dynamic)addForm.Tag;

                    // Create a new row for the DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridAnswer);

                    // Fill the cells with values
                    row.Cells[0].Value = result.Answer;
                    row.Cells[1].Value = result.TrueAnswer;

                    // Add the row to the DataGridView
                    GridAnswer.Rows.Add(row);
                }
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < GridAnswer.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = GridAnswer.Rows[selectedRowIndex];
                GridAnswer.Rows.Remove(selectedRow);
            }
        }

        private void GridAnswer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (GridAnswer.RowCount > 0)
            {
                ListTest question = new ListTest();
                question.Question = textBox1.Text;
                question.Photo = pictureBox1.ImageLocation;
                question.Point = (int)numericUpDown1.Value;

                foreach (DataGridViewRow row in GridAnswer.Rows)
                {
                    if (row.Cells[0].Value == null)
                        break;

                    question.Answers.Add( row.Cells["Answer"].Value.ToString());

                    if ((bool)(row.Cells["CorrectAnswer"].Value ?? false))
                        question.CorectAnswers.Add(row.Cells["Answer"].Value.ToString());
                }

                this.DialogResult = DialogResult.OK;
                this.Tag = question;
            }
            else
            {
                MessageBox.Show("There are no rows in the GridAnswer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BClearImage_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
        }

        private void BLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                string name =  Path.GetFileNameWithoutExtension(fileName);
                string extension = Path.GetExtension(fileName);
                string destinationFolder = @"..\..\..\Source\Picture\PictureTest\";
                string destinationFile = Path.Combine(destinationFolder, GetUniqueFileName(Path.Combine(destinationFolder, name)+'.'+ extension));
                File.Copy(fileName, destinationFile);
                pictureBox1.ImageLocation = destinationFile;
            }
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
    }
}
