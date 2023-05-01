namespace ConstructorTest.UI.Form
{
    partial class WindowAuthentication
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
            this.GBAuthentication = new System.Windows.Forms.GroupBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GBAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAuthentication
            // 
            this.GBAuthentication.Controls.Add(this.BLogin);
            this.GBAuthentication.Controls.Add(this.label1);
            this.GBAuthentication.Controls.Add(this.textBox1);
            this.GBAuthentication.Controls.Add(this.label2);
            this.GBAuthentication.Controls.Add(this.textBox2);
            this.GBAuthentication.Location = new System.Drawing.Point(146, 77);
            this.GBAuthentication.Name = "GBAuthentication";
            this.GBAuthentication.Size = new System.Drawing.Size(549, 280);
            this.GBAuthentication.TabIndex = 0;
            this.GBAuthentication.TabStop = false;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(208, 200);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(94, 29);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "Log in";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // WindowAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBAuthentication);
            this.Name = "WindowAuthentication";
            this.Text = "WinfowAuthentication";
            this.GBAuthentication.ResumeLayout(false);
            this.GBAuthentication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GBAuthentication;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button BLogin;
    }
}