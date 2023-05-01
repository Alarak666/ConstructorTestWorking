using ConstructorTest.UI.Form.FormComunication;
using Data;
using Data.Data.Identity;

namespace ConstructorTest.UI.Form.SupportForm
{
    public partial class RoleAddForm : System.Windows.Forms.Form
    {

        public string Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string FullName
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public Guid Id
        {
            get { return new Guid(textBox3.Text); }
            set { textBox3.Text = value.ToString(); }
        }
        ApplicationDbContext context = new ApplicationDbContext();
        public RoleAddForm()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                context.ApplicationRoles.Add(
                       new Data.Data.Identity.ApplicationRole
                       {
                           Id = (textBox3.Text != "") ? new Guid(textBox3.Text) : Guid.NewGuid(),
                           Name = textBox1.Text,
                           NormalizedName = textBox2.Text,
                           ConcurrencyStamp = Guid.NewGuid().ToString(),
                       });
                context.SaveChanges();
            }
            else
            {
                ApplicationRole roleToUpdate = context.ApplicationRoles.Find(new Guid(textBox3.Text));
                // If the object is found, update its properties and save changes to the database
                if (roleToUpdate != null)
                {
                    roleToUpdate.Name = textBox1.Text;
                    roleToUpdate.NormalizedName = textBox2.Text;
                    context.Update(roleToUpdate);
                    context.SaveChanges();
                }
            }
            context.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
