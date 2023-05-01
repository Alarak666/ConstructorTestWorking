using System.Windows.Forms;

namespace ConstructorTest.UI.Form
{
    partial class MainConstructor
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileTools = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Root = new System.Windows.Forms.Panel();
            this.SplitController = new System.Windows.Forms.SplitContainer();
            this.GroupBoxDescriptionMenu = new System.Windows.Forms.GroupBox();
            this.DescriptionMenu = new System.Windows.Forms.TableLayoutPanel();
            this.LMinimunPassingPercent = new System.Windows.Forms.Label();
            this.LMaximumPointForTest = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.LCountOfQuestion = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LInfoTestTaker = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LDescription = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LAuthor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridQuestions = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BDeleteQuestion = new System.Windows.Forms.Button();
            this.BEditQuestion = new System.Windows.Forms.Button();
            this.BAddQuestion = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridAnswer = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BPicture = new System.Windows.Forms.Button();
            this.LPircture = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Menu.SuspendLayout();
            this.Root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitController)).BeginInit();
            this.SplitController.Panel1.SuspendLayout();
            this.SplitController.Panel2.SuspendLayout();
            this.SplitController.SuspendLayout();
            this.GroupBoxDescriptionMenu.SuspendLayout();
            this.DescriptionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridQuestions)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAnswer)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTools});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1446, 28);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // FileTools
            // 
            this.FileTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTestToolStripMenuItem,
            this.openTestToolStripMenuItem,
            this.saveTestToolStripMenuItem,
            this.closeTestToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.FileTools.Name = "FileTools";
            this.FileTools.Size = new System.Drawing.Size(46, 24);
            this.FileTools.Text = "File";
            // 
            // createNewTestToolStripMenuItem
            // 
            this.createNewTestToolStripMenuItem.Name = "createNewTestToolStripMenuItem";
            this.createNewTestToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.createNewTestToolStripMenuItem.Text = "Create new test";
            this.createNewTestToolStripMenuItem.Click += new System.EventHandler(this.createNewTestToolStripMenuItem_Click);
            // 
            // openTestToolStripMenuItem
            // 
            this.openTestToolStripMenuItem.Name = "openTestToolStripMenuItem";
            this.openTestToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.openTestToolStripMenuItem.Text = "Open test";
            this.openTestToolStripMenuItem.Click += new System.EventHandler(this.openTestToolStripMenuItem_Click);
            // 
            // saveTestToolStripMenuItem
            // 
            this.saveTestToolStripMenuItem.Name = "saveTestToolStripMenuItem";
            this.saveTestToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.saveTestToolStripMenuItem.Text = "Save test";
            this.saveTestToolStripMenuItem.Click += new System.EventHandler(this.saveTestToolStripMenuItem_Click);
            // 
            // closeTestToolStripMenuItem
            // 
            this.closeTestToolStripMenuItem.Name = "closeTestToolStripMenuItem";
            this.closeTestToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.closeTestToolStripMenuItem.Text = "Close test";
            this.closeTestToolStripMenuItem.Click += new System.EventHandler(this.closeTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Root
            // 
            this.Root.Controls.Add(this.SplitController);
            this.Root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Root.Location = new System.Drawing.Point(0, 28);
            this.Root.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1446, 637);
            this.Root.TabIndex = 1;
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
            this.SplitController.Size = new System.Drawing.Size(1446, 637);
            this.SplitController.SplitterDistance = 481;
            this.SplitController.TabIndex = 0;
            // 
            // GroupBoxDescriptionMenu
            // 
            this.GroupBoxDescriptionMenu.Controls.Add(this.DescriptionMenu);
            this.GroupBoxDescriptionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxDescriptionMenu.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxDescriptionMenu.Name = "GroupBoxDescriptionMenu";
            this.GroupBoxDescriptionMenu.Size = new System.Drawing.Size(481, 637);
            this.GroupBoxDescriptionMenu.TabIndex = 0;
            this.GroupBoxDescriptionMenu.TabStop = false;
            this.GroupBoxDescriptionMenu.Text = "Test";
            // 
            // DescriptionMenu
            // 
            this.DescriptionMenu.ColumnCount = 2;
            this.DescriptionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68421F));
            this.DescriptionMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31579F));
            this.DescriptionMenu.Controls.Add(this.LMinimunPassingPercent, 0, 6);
            this.DescriptionMenu.Controls.Add(this.LMaximumPointForTest, 0, 5);
            this.DescriptionMenu.Controls.Add(this.textBox6, 1, 5);
            this.DescriptionMenu.Controls.Add(this.LCountOfQuestion, 0, 4);
            this.DescriptionMenu.Controls.Add(this.textBox5, 1, 4);
            this.DescriptionMenu.Controls.Add(this.LInfoTestTaker, 0, 3);
            this.DescriptionMenu.Controls.Add(this.textBox4, 1, 3);
            this.DescriptionMenu.Controls.Add(this.LDescription, 0, 2);
            this.DescriptionMenu.Controls.Add(this.textBox3, 1, 2);
            this.DescriptionMenu.Controls.Add(this.LTitle, 0, 1);
            this.DescriptionMenu.Controls.Add(this.textBox2, 1, 1);
            this.DescriptionMenu.Controls.Add(this.LAuthor, 0, 0);
            this.DescriptionMenu.Controls.Add(this.textBox1, 1, 0);
            this.DescriptionMenu.Controls.Add(this.numericUpDown1, 1, 6);
            this.DescriptionMenu.Controls.Add(this.BClose, 1, 7);
            this.DescriptionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionMenu.Location = new System.Drawing.Point(3, 23);
            this.DescriptionMenu.Name = "DescriptionMenu";
            this.DescriptionMenu.RowCount = 8;
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.DescriptionMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.DescriptionMenu.Size = new System.Drawing.Size(475, 611);
            this.DescriptionMenu.TabIndex = 0;
            this.DescriptionMenu.Text = "Test";
            // 
            // LMinimunPassingPercent
            // 
            this.LMinimunPassingPercent.AutoSize = true;
            this.LMinimunPassingPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LMinimunPassingPercent.Location = new System.Drawing.Point(3, 526);
            this.LMinimunPassingPercent.Name = "LMinimunPassingPercent";
            this.LMinimunPassingPercent.Size = new System.Drawing.Size(230, 51);
            this.LMinimunPassingPercent.TabIndex = 12;
            this.LMinimunPassingPercent.Text = "Minimun passing percent :";
            // 
            // LMaximumPointForTest
            // 
            this.LMaximumPointForTest.AutoSize = true;
            this.LMaximumPointForTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LMaximumPointForTest.Location = new System.Drawing.Point(3, 486);
            this.LMaximumPointForTest.Name = "LMaximumPointForTest";
            this.LMaximumPointForTest.Size = new System.Drawing.Size(230, 40);
            this.LMaximumPointForTest.TabIndex = 10;
            this.LMaximumPointForTest.Text = "Maximum point for test";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(239, 489);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(233, 34);
            this.textBox6.TabIndex = 11;
            // 
            // LCountOfQuestion
            // 
            this.LCountOfQuestion.AutoSize = true;
            this.LCountOfQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LCountOfQuestion.Location = new System.Drawing.Point(3, 444);
            this.LCountOfQuestion.Name = "LCountOfQuestion";
            this.LCountOfQuestion.Size = new System.Drawing.Size(230, 42);
            this.LCountOfQuestion.TabIndex = 8;
            this.LCountOfQuestion.Text = "Count of question";
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(239, 447);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 36);
            this.textBox5.TabIndex = 9;
            // 
            // LInfoTestTaker
            // 
            this.LInfoTestTaker.AutoSize = true;
            this.LInfoTestTaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LInfoTestTaker.Location = new System.Drawing.Point(3, 252);
            this.LInfoTestTaker.Name = "LInfoTestTaker";
            this.LInfoTestTaker.Size = new System.Drawing.Size(230, 192);
            this.LInfoTestTaker.TabIndex = 6;
            this.LInfoTestTaker.Text = "Info for test taker:";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(239, 255);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 186);
            this.textBox4.TabIndex = 7;
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LDescription.Location = new System.Drawing.Point(3, 60);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(230, 192);
            this.LDescription.TabIndex = 4;
            this.LDescription.Text = "Description";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(239, 63);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 186);
            this.textBox3.TabIndex = 5;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LTitle.Location = new System.Drawing.Point(3, 30);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(230, 30);
            this.LTitle.TabIndex = 2;
            this.LTitle.Text = "Title";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(239, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 24);
            this.textBox2.TabIndex = 3;
            // 
            // LAuthor
            // 
            this.LAuthor.AutoSize = true;
            this.LAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAuthor.Location = new System.Drawing.Point(3, 0);
            this.LAuthor.Name = "LAuthor";
            this.LAuthor.Size = new System.Drawing.Size(230, 30);
            this.LAuthor.TabIndex = 0;
            this.LAuthor.Text = "Author";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(239, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 24);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(239, 529);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(233, 27);
            this.numericUpDown1.TabIndex = 13;
            // 
            // BClose
            // 
            this.BClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BClose.Location = new System.Drawing.Point(239, 580);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(233, 28);
            this.BClose.TabIndex = 14;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.86907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.13093F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(961, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Text = "Test";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(949, 266);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridQuestions);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(943, 219);
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
            this.GridQuestions.Size = new System.Drawing.Size(937, 193);
            this.GridQuestions.TabIndex = 0;
            this.GridQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridQuestion_CellClick);
            this.GridQuestions.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridQuestion_CellMouseDown);
            this.GridQuestions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridQuestions_CellValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.BDeleteQuestion, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BEditQuestion, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BAddQuestion, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(943, 35);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // BDeleteQuestion
            // 
            this.BDeleteQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BDeleteQuestion.Location = new System.Drawing.Point(631, 3);
            this.BDeleteQuestion.Name = "BDeleteQuestion";
            this.BDeleteQuestion.Size = new System.Drawing.Size(309, 29);
            this.BDeleteQuestion.TabIndex = 9;
            this.BDeleteQuestion.Text = "Delete question";
            this.BDeleteQuestion.UseVisualStyleBackColor = true;
            this.BDeleteQuestion.Click += new System.EventHandler(this.BDeleteQuestion_Click);
            // 
            // BEditQuestion
            // 
            this.BEditQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BEditQuestion.Location = new System.Drawing.Point(317, 3);
            this.BEditQuestion.Name = "BEditQuestion";
            this.BEditQuestion.Size = new System.Drawing.Size(308, 29);
            this.BEditQuestion.TabIndex = 5;
            this.BEditQuestion.Text = "Edit question";
            this.BEditQuestion.UseVisualStyleBackColor = true;
            this.BEditQuestion.Click += new System.EventHandler(this.BEditQuestion_Click);
            // 
            // BAddQuestion
            // 
            this.BAddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BAddQuestion.Location = new System.Drawing.Point(3, 3);
            this.BAddQuestion.Name = "BAddQuestion";
            this.BAddQuestion.Size = new System.Drawing.Size(308, 29);
            this.BAddQuestion.TabIndex = 4;
            this.BAddQuestion.Text = "Add question";
            this.BAddQuestion.UseVisualStyleBackColor = true;
            this.BAddQuestion.Click += new System.EventHandler(this.BAddQuestion_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 301);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(955, 333);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridAnswer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(326, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(626, 327);
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
            this.GridAnswer.Size = new System.Drawing.Size(620, 301);
            this.GridAnswer.TabIndex = 0;
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(317, 37);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // BPicture
            // 
            this.BPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BPicture.Location = new System.Drawing.Point(198, 3);
            this.BPicture.Name = "BPicture";
            this.BPicture.Size = new System.Drawing.Size(116, 31);
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
            this.LPircture.Size = new System.Drawing.Size(189, 37);
            this.LPircture.TabIndex = 2;
            this.LPircture.Text = "Fullsize";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 284);
            this.panel1.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Image = global::ConstructorTest.UI.Properties.Resources.images;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(317, 284);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 665);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainConstructor";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Root.ResumeLayout(false);
            this.SplitController.Panel1.ResumeLayout(false);
            this.SplitController.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitController)).EndInit();
            this.SplitController.ResumeLayout(false);
            this.GroupBoxDescriptionMenu.ResumeLayout(false);
            this.DescriptionMenu.ResumeLayout(false);
            this.DescriptionMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridQuestions)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAnswer)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileTools;
        private System.Windows.Forms.Panel Root;
        private System.Windows.Forms.SplitContainer SplitController;
        private TableLayoutPanel DescriptionMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox GroupBoxDescriptionMenu;
        private Label LMinimunPassingPercent;
        private Label LMaximumPointForTest;
        private TextBox textBox6;
        private Label LCountOfQuestion;
        private TextBox textBox5;
        private Label LInfoTestTaker;
        private TextBox textBox4;
        private Label LDescription;
        private TextBox textBox3;
        private Label LTitle;
        private TextBox textBox2;
        private Label LAuthor;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BPicture;
        private Label LPircture;
        private PictureBox Picture;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox4;
        private DataGridView GridQuestions;
        private Button BDeleteQuestion;
        private Button BEditQuestion;
        private Button BAddQuestion;
        private GroupBox groupBox2;
        private DataGridView GridAnswer;
        private ImageList imageList1;
        private NumericUpDown numericUpDown1;
        private ToolStripMenuItem createNewTestToolStripMenuItem;
        private ToolStripMenuItem openTestToolStripMenuItem;
        private ToolStripMenuItem saveTestToolStripMenuItem;
        private ToolStripMenuItem closeTestToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button BClose;
    }
}

