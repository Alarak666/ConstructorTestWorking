namespace ConstructorTest.UI.Form.SupportForm
{
    partial class AnswerUserTest
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
            this.GRUserAnswer = new System.Windows.Forms.GroupBox();
            this.PanelAnswer = new System.Windows.Forms.Panel();
            this.GRUserAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRUserAnswer
            // 
            this.GRUserAnswer.Controls.Add(this.PanelAnswer);
            this.GRUserAnswer.Location = new System.Drawing.Point(68, 24);
            this.GRUserAnswer.Name = "GRUserAnswer";
            this.GRUserAnswer.Size = new System.Drawing.Size(895, 623);
            this.GRUserAnswer.TabIndex = 0;
            this.GRUserAnswer.TabStop = false;
            this.GRUserAnswer.Text = "User Answer";
            // 
            // PanelAnswer
            // 
            this.PanelAnswer.AutoScroll = true;
            this.PanelAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAnswer.Location = new System.Drawing.Point(3, 23);
            this.PanelAnswer.Name = "PanelAnswer";
            this.PanelAnswer.Size = new System.Drawing.Size(889, 597);
            this.PanelAnswer.TabIndex = 0;
            // 
            // AnswerUserTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 687);
            this.Controls.Add(this.GRUserAnswer);
            this.Name = "AnswerUserTest";
            this.Text = "AnswerUserTest";
            this.GRUserAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GRUserAnswer;
        private Panel PanelAnswer;
    }
}