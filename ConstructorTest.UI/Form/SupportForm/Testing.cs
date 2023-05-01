using Data;
using Data.Data.InformationData;
using Data.Data.TestCreate;
using System.Xml.Serialization;

namespace ConstructorTest.UI.Form.SupportForm
{
    public partial class Testing : System.Windows.Forms.Form
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        public static Guid AsignTestId { get; set; } 
        private Guid TestOnServerId;
        private Guid UserId;
        private TimeSpan? TimeToTest;

        List<UserAnswer> UserAnswers = new List<UserAnswer>();
        Test TestComponent = new Test();



        public Testing()
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();

            var asignTest = applicationDbContext.AsignTestUsers.FirstOrDefault(x => x.Id == AsignTestId);

            TestOnServerId = (Guid)asignTest.TestOnServerId;
            UserId = (Guid)asignTest.UserId;
            TimeToTest = asignTest.TimeForTheTest;
            InitializeComponent();
            timer1.Interval = 1000;

            TestingCreate();

            TAuthor.Text = TestComponent.Author;
            TTitle.Text = TestComponent.Title;
            TDescription.Text = TestComponent.Description;
            TInfoTestTaker.Text = TestComponent.InfoTestTaker;
            TCountOfQuestion.Text = TestComponent.CountQuestion.ToString();
            TMaximumPointForTest.Text = TestComponent.MaxPoint.ToString();
            TMinimunPassingPercent.Text = TestComponent.Percent.ToString();
            GridQuestions.Columns.Add("TextQuestion", "Text of question");
            GridQuestions.Columns.Add("Point", "Point");
            GridQuestions.Columns.Add("CountAnswer", "Count of answer");
            GridQuestions.AllowUserToAddRows = false;
            GridQuestions.AllowUserToDeleteRows = false;

            foreach (var question in TestComponent.listTests)
            {
                object[] row = new object[]
                {
                    question.Question, 
                    question.Point,
                    question.CorectAnswers.Count 
                };
                GridQuestions.Rows.Add(row);
            }

            GridAnswer.Columns.Add("TextOfAnswer", "Text of answer");

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "SelectTrueAnswer";
            dgvCmb.HeaderText = "Text of question";
            GridAnswer.Columns.Add(dgvCmb);
            timer1.Enabled = true;
        }
        public void TestingCreate()
        {
            try
            {
                var testInBase = dbContext.TestOnServers.FirstOrDefault(x => x.Id == TestOnServerId);
                if (testInBase == null)
                    throw new Exception();

                string filePath = Path.GetFullPath(testInBase.Root);

                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                Test test;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    test = (Test)serializer.Deserialize(reader);
                }

                TestComponent = test;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File format is not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void FinishedTest_Click(object sender, EventArgs e)
        {
            bool completeTest = true;
            foreach (ListTest question in TestComponent.listTests)
            {
                var userAnswer = UserAnswers.FirstOrDefault(x => x.Question == question.Question);
                if (userAnswer == null)
                {
                    MessageBox.Show("You have not answered the question: " + question.Question);
                    completeTest = false;
                    return;
                }
                // the rest of your code to calculate the points
            }

            if (completeTest)
            {
                Result();
            }


        }
        private void Result()
        {
            timer1.Enabled = false;
            // Calculation of points for user answers
            int totalPoints = 0;
            decimal userPoints = 0;
            int correctCount = 0;
            int selectedCount = 0;
            decimal pointsPerCorrectAnswer = 0;

            foreach (ListTest question in TestComponent.listTests)
            {
                totalPoints += question.Point;
                correctCount = 0;
                selectedCount = 0;
                pointsPerCorrectAnswer = (decimal)question.Point / question.CorectAnswers.Count;

                var userAnswer = UserAnswers.FirstOrDefault(x => x.Question == question.Question);
                if (userAnswer != null)
                {
                    for (int i = 0; i < question.Answers.Count; i++)
                    {
                        if (userAnswer.IsSelected[i] && question.CorectAnswers.Contains(question.Answers[i]))
                        {
                            correctCount++;
                        }
                        if(!question.CorectAnswers.Contains(question.Answers[i]) && userAnswer.IsSelected[i])
                        {
                            correctCount--;
                        }
                    }
                    if (correctCount < 0 )
                    {
                        correctCount = 0;
                    }
                    userPoints += correctCount * pointsPerCorrectAnswer;
                }
            }

            decimal percent = Math.Round(userPoints / totalPoints * 100, 2);
            decimal minimumPercent = TestComponent.Percent; // set minimum percentage required to pass the test
            string passStatus = percent >= minimumPercent ? "Good you passed the test!" : "Sorry, you didn`t pass the test.";

            decimal roundedUserPoints = Math.Round(userPoints, 2);


            decimal roundedPercent = Math.Round(percent + 0.05m, 1);
            if (roundedPercent % 1 == 0)
            {
                roundedPercent = Math.Round(percent + 0.05m, 1);
            }
            else
            {
                roundedPercent = Math.Floor(roundedPercent);
            }



            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            var testInBase = dbContext.TestOnServers.FirstOrDefault(x => x.Id == TestOnServerId);

            var asignTestUsers = applicationDbContext.AsignTestUsers.FirstOrDefault(x => x.Id == AsignTestId);

            XmlSerializer serializer = new XmlSerializer(typeof(List<UserAnswer>));
            string filePath = $@"..\..\..\Source\TestUser\{UserId}-{AsignTestId}.xml";

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                serializer.Serialize(streamWriter, UserAnswers);
            }

            asignTestUsers.AnswerRoot = filePath;

            if (userPoints > asignTestUsers.TestScoreHigh)
            {
                asignTestUsers.TestScoreHigh = userPoints;
                asignTestUsers.TestScore = userPoints;
            }
            else
            {
                asignTestUsers.TestScore = asignTestUsers.TestScoreHigh;
            }

            asignTestUsers.CompleteTestDateTime = DateTime.Now;
            asignTestUsers.TestDateTime = TimeSpan.FromSeconds(elapsedSeconds);
            asignTestUsers.CountContinue = asignTestUsers.CountContinue - 1;
            applicationDbContext.Update(asignTestUsers);
            applicationDbContext.SaveChanges();

            DialogResult result = MessageBox.Show($"Maximum Points: {totalPoints}\nResult Points: {roundedUserPoints}\nMinimum Percent: {minimumPercent}%\nYour Percent: {roundedPercent}%\n\n{passStatus}");

            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }
        private void BPicture_Click(object sender, EventArgs e)
        {
            using (PhotoFullSize photoFullSize = new PhotoFullSize())
            {
                if (TestComponent?.listTests != null && TestComponent.listTests.Count > selectedQuestionIndex && TestComponent.listTests[selectedQuestionIndex] != null)
                {
                    string photo = TestComponent.listTests[selectedQuestionIndex].Photo;
                    if (!string.IsNullOrEmpty(photo))
                    {
                        photoFullSize.UrlPhoto = photo;
                        photoFullSize.ShowDialog();
                    }
                    else
                        MessageBox.Show("Photo is empty");
                }
            }
        }

        private void ClearCorrectAnswer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridAnswer.Rows)
            {
                row.Cells["SelectTrueAnswer"].Value = false;
            }
        }

        private int selectedQuestionIndex; 

        private void GridQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedQuestionIndex = e.RowIndex; // Save the index of the selected question
            if (selectedQuestionIndex == -1) return;
            // Clear the answer table and add answers for the selected question
            GridAnswer.Rows.Clear();

            var existingAnswer = UserAnswers.FirstOrDefault(a => a.Question == TestComponent.listTests[selectedQuestionIndex].Question);
            Picture.ImageLocation = TestComponent.listTests[selectedQuestionIndex].Photo;

            if (existingAnswer != null) 
            {

                for (int i = 0; i < existingAnswer.Answer.Count; i++)
                {
                    object[] row = new object[]
                    {
                            existingAnswer.Answer[i],
                            existingAnswer.IsSelected[i]
                    };
                    GridAnswer.Rows.Add(row);
                }
            }
            else // If there is no answer yet, we create empty rows of the answer table
            {
                foreach (var answer in TestComponent.listTests[selectedQuestionIndex].Answers)
                {
                    object[] row = new object[]
                    {
                            answer,
                            false
                    };
                    GridAnswer.AllowUserToAddRows = false;
                    GridAnswer.AllowUserToDeleteRows = false;
                    GridAnswer.Rows.Add(row);
                }
            }
        }


        private void GridAnswer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && selectedQuestionIndex != -1)
                {
                    var textQuestion = GridQuestions.Rows[selectedQuestionIndex].Cells["TextQuestion"].Value.ToString();
                    int index = UserAnswers.FindIndex(x => x.Question == textQuestion);

                    var newObj = new UserAnswer
                    {
                        Answer = new List<string>(),
                        IsSelected = new List<bool>()
                    };
                    newObj.Question = (index == -1) ? textQuestion : UserAnswers[index].Question;

                    foreach (DataGridViewRow row in GridAnswer.Rows)
                    {
                        string answerText = row.Cells["TextOfAnswer"].Value.ToString();
                        bool isSelected = (bool)row.Cells["SelectTrueAnswer"].Value;

                        newObj.Answer.Add(answerText);
                        newObj.IsSelected.Add(isSelected);
                    }

                    if (index != -1)
                    {
                        UserAnswers[index] = newObj;
                    }
                    else
                    {
                        UserAnswers.Add(newObj);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            //Test
            //string message = "";
            //foreach (var userAnswer in UserAnswers)
            //{
            //    message += "Question: " + userAnswer.Question + "\n";
            //    message += "Answers: ";
            //    for (int i = 0; i < userAnswer.Answer.Count; i++)
            //    {
            //        message += userAnswer.Answer[i] + " (Selected: " + userAnswer.IsSelected[i] + ")";
            //        if (i != userAnswer.Answer.Count - 1)
            //        {
            //            message += ", ";
            //        }
            //    }
            //    message += "\n\n";
            //}

            //MessageBox.Show(message, "User Answers");
        }
        private int elapsedSeconds;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++; // increase the number of elapsed seconds by 1

            // calculate the number of hours, minutes and seconds
            int hours = elapsedSeconds / 3600;
            int minutes = (elapsedSeconds % 3600) / 60;
            int seconds = elapsedSeconds % 60;

            string timeString = $"{hours:D1}:{minutes:D2}:{seconds:D2}";
            label2.Text = timeString;
            if (TimeToTest.HasValue && TimeSpan.FromSeconds(elapsedSeconds) >= TimeToTest.Value)
            {
                timer1.Stop();
                Result();
            }
        }
    }
}
