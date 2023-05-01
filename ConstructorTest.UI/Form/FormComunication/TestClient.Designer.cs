namespace ConstructorTest.UI.Form.FormComunication
{
    partial class TestClient
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextGuid = new System.Windows.Forms.TextBox();
            this.BRefresh = new System.Windows.Forms.Button();
            this.BGetTested = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.GridUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " New test for user:";
            // 
            // GridUser
            // 
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUser.Location = new System.Drawing.Point(3, 23);
            this.GridUser.Name = "GridUser";
            this.GridUser.ReadOnly = true;
            this.GridUser.RowHeadersWidth = 51;
            this.GridUser.RowTemplate.Height = 29;
            this.GridUser.Size = new System.Drawing.Size(788, 129);
            this.GridUser.TabIndex = 0;
            this.GridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_CellClick);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.GridResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result test :";
            // 
            // GridResult
            // 
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridResult.Location = new System.Drawing.Point(3, 23);
            this.GridResult.Name = "GridResult";
            this.GridResult.ReadOnly = true;
            this.GridResult.RowHeadersWidth = 51;
            this.GridResult.RowTemplate.Height = 29;
            this.GridResult.Size = new System.Drawing.Size(788, 212);
            this.GridResult.TabIndex = 1;
            this.GridResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellClick);
            this.GridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellContentClick);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 39);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BRefresh, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BGetTested, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextGuid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 33);
            this.panel2.TabIndex = 0;
            // 
            // TextGuid
            // 
            this.TextGuid.Location = new System.Drawing.Point(3, -1);
            this.TextGuid.Multiline = true;
            this.TextGuid.Name = "TextGuid";
            this.TextGuid.Size = new System.Drawing.Size(204, 34);
            this.TextGuid.TabIndex = 0;
            this.TextGuid.Visible = false;
            // 
            // BRefresh
            // 
            this.BRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BRefresh.Location = new System.Drawing.Point(216, 3);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(197, 33);
            this.BRefresh.TabIndex = 1;
            this.BRefresh.Text = "Refresh";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // BGetTested
            // 
            this.BGetTested.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGetTested.Location = new System.Drawing.Point(419, 3);
            this.BGetTested.Name = "BGetTested";
            this.BGetTested.Size = new System.Drawing.Size(158, 33);
            this.BGetTested.TabIndex = 2;
            this.BGetTested.Text = "Get tested";
            this.BGetTested.UseVisualStyleBackColor = true;
            this.BGetTested.Click += new System.EventHandler(this.BGetTested_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(583, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestClient";
            this.Text = "TestClient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView GridUser;
        private DataGridView GridResult;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button BRefresh;
        private Button BGetTested;
        private Button button1;
        private TextBox TextGuid;
    }
}