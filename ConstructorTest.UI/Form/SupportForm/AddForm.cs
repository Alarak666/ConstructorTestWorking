namespace ConstructorTest.UI.Form.SupportForm
{
    public partial class AddForm : System.Windows.Forms.Form
    {
        public bool TrueAnswer
        {
            get
            {
                return checkBox1.Checked;
            }
            set
            {
                checkBox1.Checked = value;
            }
        }
        public string Answer
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public AddForm()
        {
            InitializeComponent();
            textBox1.Text = Answer;
            checkBox1.Checked = TrueAnswer;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tag = new { TrueAnswer = checkBox1.Checked, Answer = textBox1.Text };

            // Set the DialogResult to OK to indicate a successful completion of the dialog
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
