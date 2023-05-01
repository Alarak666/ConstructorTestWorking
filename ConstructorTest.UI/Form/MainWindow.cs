using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorTest.UI.Form
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BWinfowAuthentication_Click(object sender, EventArgs e)
        {
            WindowAuthentication windowAuthentication = new WindowAuthentication();
            this.Hide();
            windowAuthentication.Show();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Testing_Click(object sender, EventArgs e)
        {
            SupportForm.Testing testing = new SupportForm.Testing();
            testing.Show();
            this.Hide();


        }
    }
}
