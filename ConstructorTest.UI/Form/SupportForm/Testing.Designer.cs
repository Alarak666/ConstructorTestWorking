namespace ConstructorTest.UI.Form.SupportForm
{
    partial class Testing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Root = new System.Windows.Forms.Panel();
            this.SplitController = new System.Windows.Forms.SplitContainer();
            this.GroupBoxDescriptionMenu = new System.Windows.Forms.GroupBox();
            this.DescriptionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.LMinimunPassingPercent = new System.Windows.Forms.Label();
            this.LMaximumPointForTest = new System.Windows.Forms.Label();
            this.TMaximumPointForTest = new System.Windows.Forms.TextBox();
            this.LCountOfQuestion = new System.Windows.Forms.Label();
            this.TCountOfQuestion = new System.Windows.Forms.TextBox();
            this.LInfoTestTaker = new System.Windows.Forms.Label();
            this.TInfoTestTaker = new System.Windows.Forms.TextBox();
            this.LDescription = new System.Windows.Forms.Label();
            this.TDescription = new System.Windows.Forms.TextBox();
            this.LTitle = new System.Windows.Forms.Label();
            this.TTitle = new System.Windows.Forms.TextBox();
            this.LAuthor = new System.Windows.Forms.Label();
            this.TAuthor = new System.Windows.Forms.TextBox();
            this.TMinimunPassingPercent = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FinishedTest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridQuestions = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridAnswer = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BPicture = new System.Windows.Forms.Button();
            this.LPircture = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearCorrectAnswer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitController)).BeginInit();
            this.SplitController.Panel1.SuspendLayout();
            this.SplitController.Panel2.SuspendLayout();
            this.SplitController.SuspendLayout();
            this.GroupBoxDescriptionMenu.SuspendLayout();
            this.DescriptionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TMinimunPassingPercent)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridQuestions)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAnswer)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Root
            // 
            this.Root.Controls.Add(this.SplitController);
            this.Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1068, 616);
            this.Root.TabIndex = 2;
            // 
            // SplitController
            // 
            this.SplitController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitController.Location = new System.Drawing.Point(0, 0);
            this.SplitController.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SplitController.Name = "SplitController";
            // 
            // SplitController.Panel1
            // 
            this.SplitController.Panel1.Controls.Add(this.GroupBoxDescriptionMenu);
            // 
            // SplitController.Panel2
            // 
            this.SplitController.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.SplitController.Size = new System.Drawing.Size(1068, 616);
            this.SplitController.SplitterDistance = 355;
            this.SplitController.TabIndex = 0;
            // 
            // GroupBoxDescriptionMenu
            // 
            this.GroupBoxDescriptionMenu.Controls.Add(this.DescriptionMenu);
            this.GroupBoxDescriptionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxDescriptionMenu.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxDescriptionMenu.Name = "GroupBoxDescriptionMenu";
            this.GroupBoxDescriptionMenu.Size = new System.Drawing.Size(355, 616);
            this.GroupBoxDescriptionMenu.TabIndex = 0;
            this.GroupBoxDescriptionMenu.TabStop = false;
            this.GroupBoxDescriptionMenu.Text = "Test";
            // 
            // DescriptionMenu
            // 
            this.DescriptionMenu.ColumnCount = 2;
            this.DescriptionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DescriptionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DescriptionMenu.Controls.Add(this.LMinimunPassingPercent, 0, 6);
            this.DescriptionMenu.Controls.Add(this.LMaximumPointForTest, 0, 5);
            this.DescriptionMenu.Controls.Add(this.TMaximumPointForTest, 1, 5);
            this.DescriptionMenu.Controls.Add(this.LCountOfQuestion, 0, 4);
            this.DescriptionMenu.Controls.Add(this.TCountOfQuestion, 1, 4);
            this.DescriptionMenu.Controls.Add(this.LInfoTestTaker, 0, 3);
            this.DescriptionMenu.Controls.Add(this.TInfoTestTaker, 1, 3);
            this.DescriptionMenu.Controls.Add(this.LDescription, 0, 2);
            this.DescriptionMenu.Controls.Add(this.TDescription, 1, 2);
            this.DescriptionMenu.Controls.Add(this.LTitle, 0, 1);
            this.DescriptionMenu.Controls.Add(this.TTitle, 1, 1);
            this.DescriptionMenu.Controls.Add(this.LAuthor, 0, 0);
            this.DescriptionMenu.Controls.Add(this.TAuthor, 1, 0);
            this.DescriptionMenu.Controls.Add(this.TMinimunPassingPercent, 1, 6);
            this.DescriptionMenu.Controls.Add(this.panel4, 0, 7);
            this.DescriptionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionMenu.Location = new System.Drawing.Point(3, 23);
            this.DescriptionMenu.Name = "DescriptionMenu";
            this.DescriptionMenu.RowCount = 8;
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.DescriptionMenu.Size = new System.Drawing.Size(349, 590);
            this.DescriptionMenu.TabIndex = 0;
            this.DescriptionMenu.Text = "Test";
            // 
            // LMinimunPassingPercent
            // 
            this.LMinimunPassingPercent.AutoSize = true;
            this.LMinimunPassingPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LMinimunPassingPercent.Location = new System.Drawing.Point(3, 499);
            this.LMinimunPassingPercent.Name = "LMinimunPassingPercent";
            this.LMinimunPassingPercent.Size = new System.Drawing.Size(168, 49);
            this.LMinimunPassingPercent.TabIndex = 12;
            this.LMinimunPassingPercent.Text = "Minimun passing percent :";
            // 
            // LMaximumPointForTest
            // 
            this.LMaximumPointForTest.AutoSize = true;
            this.LMaximumPointForTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LMaximumPointForTest.Location = new System.Drawing.Point(3, 466);
            this.LMaximumPointForTest.Name = "LMaximumPointForTest";
            this.LMaximumPointForTest.Size = new System.Drawing.Size(168, 33);
            this.LMaximumPointForTest.TabIndex = 10;
            this.LMaximumPointForTest.Text = "Maximum point for test";
            // 
            // TMaximumPointForTest
            // 
            this.TMaximumPointForTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TMaximumPointForTest.Location = new System.Drawing.Point(177, 469);
            this.TMaximumPointForTest.Multiline = true;
            this.TMaximumPointForTest.Name = "TMaximumPointForTest";
            this.TMaximumPointForTest.ReadOnly = true;
            this.TMaximumPointForTest.Size = new System.Drawing.Size(169, 27);
            this.TMaximumPointForTest.TabIndex = 11;
            // 
            // LCountOfQuestion
            // 
            this.LCountOfQuestion.AutoSize = true;
            this.LCountOfQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LCountOfQuestion.Location = new System.Drawing.Point(3, 425);
            this.LCountOfQuestion.Name = "LCountOfQuestion";
            this.LCountOfQuestion.Size = new System.Drawing.Size(168, 41);
            this.LCountOfQuestion.TabIndex = 8;
            this.LCountOfQuestion.Text = "Count of question";
            // 
            // TCountOfQuestion
            // 
            this.TCountOfQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCountOfQuestion.Location = new System.Drawing.Point(177, 428);
            this.TCountOfQuestion.Multiline = true;
            this.TCountOfQuestion.Name = "TCountOfQuestion";
            this.TCountOfQuestion.ReadOnly = true;
            this.TCountOfQuestion.Size = new System.Drawing.Size(169, 35);
            this.TCountOfQuestion.TabIndex = 9;
            // 
            // LInfoTestTaker
            // 
            this.LInfoTestTaker.AutoSize = true;
            this.LInfoTestTaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LInfoTestTaker.Location = new System.Drawing.Point(3, 247);
            this.LInfoTestTaker.Name = "LInfoTestTaker";
            this.LInfoTestTaker.Size = new System.Drawing.Size(168, 178);
            this.LInfoTestTaker.TabIndex = 6;
            this.LInfoTestTaker.Text = "Info for test taker:";
            // 
            // TInfoTestTaker
            // 
            this.TInfoTestTaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TInfoTestTaker.Location = new System.Drawing.Point(177, 250);
            this.TInfoTestTaker.Multiline = true;
            this.TInfoTestTaker.Name = "TInfoTestTaker";
            this.TInfoTestTaker.ReadOnly = true;
            this.TInfoTestTaker.Size = new System.Drawing.Size(169, 172);
            this.TInfoTestTaker.TabIndex = 7;
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LDescription.Location = new System.Drawing.Point(3, 69);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(168, 178);
            this.LDescription.TabIndex = 4;
            this.LDescription.Text = "Description";
            // 
            // TDescription
            // 
            this.TDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TDescription.Location = new System.Drawing.Point(177, 72);
            this.TDescription.Multiline = true;
            this.TDescription.Name = "TDescription";
            this.TDescription.ReadOnly = true;
            this.TDescription.Size = new System.Drawing.Size(169, 172);
            this.TDescription.TabIndex = 5;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LTitle.Location = new System.Drawing.Point(3, 34);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(168, 35);
            this.LTitle.TabIndex = 2;
            this.LTitle.Text = "Title";
            // 
            // TTitle
            // 
            this.TTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TTitle.Location = new System.Drawing.Point(177, 37);
            this.TTitle.Multiline = true;
            this.TTitle.Name = "TTitle";
            this.TTitle.ReadOnly = true;
            this.TTitle.Size = new System.Drawing.Size(169, 29);
            this.TTitle.TabIndex = 3;
            // 
            // LAuthor
            // 
            this.LAuthor.AutoSize = true;
            this.LAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAuthor.Location = new System.Drawing.Point(3, 0);
            this.LAuthor.Name = "LAuthor";
            this.LAuthor.Size = new System.Drawing.Size(168, 34);
            this.LAuthor.TabIndex = 0;
            this.LAuthor.Text = "Author";
            // 
            // TAuthor
            // 
            this.TAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAuthor.Location = new System.Drawing.Point(177, 3);
            this.TAuthor.Multiline = true;
            this.TAuthor.Name = "TAuthor";
            this.TAuthor.ReadOnly = true;
            this.TAuthor.Size = new System.Drawing.Size(169, 28);
            this.TAuthor.TabIndex = 1;
            // 
            // TMinimunPassingPercent
            // 
            this.TMinimunPassingPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TMinimunPassingPercent.Location = new System.Drawing.Point(177, 502);
            this.TMinimunPassingPercent.Name = "TMinimunPassingPercent";
            this.TMinimunPassingPercent.ReadOnly = true;
            this.TMinimunPassingPercent.Size = new System.Drawing.Size(169, 27);
            this.TMinimunPassingPercent.TabIndex = 13;
            // 
            // panel4
            // 
            this.DescriptionMenu.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.FinishedTest);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 36);
            this.panel4.TabIndex = 14;
            // 
            // FinishedTest
            // 
            this.FinishedTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinishedTest.Location = new System.Drawing.Point(0, 0);
            this.FinishedTest.Name = "FinishedTest";
            this.FinishedTest.Size = new System.Drawing.Size(343, 36);
            this.FinishedTest.TabIndex = 2;
            this.FinishedTest.Text = "Finish Test";
            this.FinishedTest.UseVisualStyleBackColor = true;
            this.FinishedTest.Click += new System.EventHandler(this.FinishedTest_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.56493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.006494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 616);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Text = "Test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(697, 260);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridQuestions);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(691, 213);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // GridQuestions
            // 
            this.GridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridQuestions.Location = new System.Drawing.Point(3, 23);
            this.GridQuestions.Name = "GridQuestions";
            this.GridQuestions.RowHeadersWidth = 51;
            this.GridQuestions.RowTemplate.Height = 29;
            this.GridQuestions.Size = new System.Drawing.Size(685, 187);
            this.GridQuestions.TabIndex = 0;
            this.GridQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridQuestions_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 35);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.14872F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 281);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridAnswer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(240, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(460, 275);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answer for question";
            // 
            // GridAnswer
            // 
            this.GridAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridAnswer.Location = new System.Drawing.Point(3, 23);
            this.GridAnswer.Name = "GridAnswer";
            this.GridAnswer.RowHeadersWidth = 51;
            this.GridAnswer.RowTemplate.Height = 29;
            this.GridAnswer.Size = new System.Drawing.Size(454, 249);
            this.GridAnswer.TabIndex = 0;
            this.GridAnswer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAnswer_CellValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.81319F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.18681F));
            this.tableLayoutPanel4.Controls.Add(this.BPicture, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LPircture, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(231, 37);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // BPicture
            // 
            this.BPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPicture.Location = new System.Drawing.Point(145, 3);
            this.BPicture.Name = "BPicture";
            this.BPicture.Size = new System.Drawing.Size(83, 31);
            this.BPicture.TabIndex = 3;
            this.BPicture.Text = "Open picture";
            this.BPicture.UseVisualStyleBackColor = true;
            this.BPicture.Click += new System.EventHandler(this.BPicture_Click);
            // 
            // LPircture
            // 
            this.LPircture.AutoSize = true;
            this.LPircture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LPircture.Location = new System.Drawing.Point(3, 0);
            this.LPircture.Name = "LPircture";
            this.LPircture.Size = new System.Drawing.Size(136, 37);
            this.LPircture.TabIndex = 2;
            this.LPircture.Text = "Fullsize";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 232);
            this.panel1.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Image = global::ConstructorTest.UI.Properties.Resources.images;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(231, 232);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ClearCorrectAnswer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 31);
            this.panel3.TabIndex = 2;
            // 
            // ClearCorrectAnswer
            // 
            this.ClearCorrectAnswer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearCorrectAnswer.Location = new System.Drawing.Point(428, 0);
            this.ClearCorrectAnswer.Name = "ClearCorrectAnswer";
            this.ClearCorrectAnswer.Size = new System.Drawing.Size(275, 31);
            this.ClearCorrectAnswer.TabIndex = 0;
            this.ClearCorrectAnswer.Text = "Clear correct answer";
            this.ClearCorrectAnswer.UseVisualStyleBackColor = true;
            this.ClearCorrectAnswer.Click += new System.EventHandler(this.ClearCorrectAnswer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 616);
            this.Controls.Add(this.Root);
            this.Name = "Testing";
            this.Text = "TestClient";
            this.Root.ResumeLayout(false);
            this.SplitController.Panel1.ResumeLayout(false);
            this.SplitController.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitController)).EndInit();
            this.SplitController.ResumeLayout(false);
            this.GroupBoxDescriptionMenu.ResumeLayout(false);
            this.DescriptionMenu.ResumeLayout(false);
            this.DescriptionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TMinimunPassingPercent)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridQuestions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAnswer)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Root;
        private SplitContainer SplitController;
        private GroupBox GroupBoxDescriptionMenu;
        private TableLayoutPanel DescriptionMenu;
        private Label LMinimunPassingPercent;
        private Label LMaximumPointForTest;
        private TextBox TMaximumPointForTest;
        private Label LCountOfQuestion;
        private TextBox TCountOfQuestion;
        private Label LInfoTestTaker;
        private TextBox TInfoTestTaker;
        private Label LDescription;
        private TextBox TDescription;
        private Label LTitle;
        private TextBox TTitle;
        private Label LAuthor;
        private TextBox TAuthor;
        private NumericUpDown TMinimunPassingPercent;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox4;
        private DataGridView GridQuestions;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private DataGridView GridAnswer;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BPicture;
        private Label LPircture;
        private Panel panel1;
        private PictureBox Picture;
        private Panel panel2;
        private Panel panel3;
        private Button ClearCorrectAnswer;
        private Panel panel4;
        private Button FinishedTest;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}