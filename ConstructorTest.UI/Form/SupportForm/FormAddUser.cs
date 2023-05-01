using ConstructorTest.UI.Form.FormComunication;
using Data;
using Data.Data.Identity;
using Microsoft.AspNetCore.Identity;

namespace ConstructorTest.UI.Form.SupportForm
{
    public partial class FormAddUser : System.Windows.Forms.Form
    {
        ApplicationDbContext context = new ApplicationDbContext();

        List<ApplicationRole> Data = new List<ApplicationRole>();
        public static ApplicationUser? ApplicationUser
        {
            get; set;
        } = new ApplicationUser();
        public FormAddUser()
        {
            Data = context.ApplicationRoles.Select(x => new ApplicationRole { Id = x.Id, Name = x.Name }).ToList();
            InitializeComponent();
            comboBox1.DataSource = Data;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            if(ApplicationUser?.Id != Guid.Empty && ApplicationUser != null)
            {
                textBox1.Text = ApplicationUser.UserName;
                textBox2.Text = ApplicationUser.Id.ToString();
                comboBox1.SelectedValue = Data.FirstOrDefault(x => x.Id == ApplicationUser.ApplicationRoleId).Id;
                textBox3.Text = ApplicationUser.NormalizedUserName;
                textBox4.Text = ApplicationUser.Email;
                textBox5.Text = ApplicationUser.NormalizedEmail;
                textBox6.Text = ""; // Clear password
                textBox7.Text = ApplicationUser.PhoneNumber;
                ApplicationUser = null;
            }
            
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            ApplicationDbContext saveContext = new ApplicationDbContext();
            var hasher = new PasswordHasher<ApplicationUser>();
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("AplicationRole require");
                return;
            }
            if (!IsValidEmail(textBox4.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            if (textBox2.Text == "")
            {
                var roleId = Data.FirstOrDefault(x => x.Name == comboBox1.SelectedItem.ToString());
                var newUser = new ApplicationUser
                {
                    UserName = textBox1.Text,
                    Id = (textBox2.Text != "") ? new Guid(textBox2.Text) : Guid.NewGuid(),
                    ApplicationRoleId = roleId.Id,
                    NormalizedUserName = textBox3.Text,
                    Email = textBox4.Text,
                    NormalizedEmail = textBox5.Text,
                    PasswordHash = hasher.HashPassword(new ApplicationUser(), textBox6.Text),
                    PhoneNumber = textBox7.Text,
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    TwoFactorEnabled = false,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ApplicationRoleName = roleId.Name
                };

                saveContext.ApplicationUsers.Add(newUser);
                saveContext.SaveChanges();
            }
            else
            {
                ApplicationUser applicationUserToUpdate = saveContext.ApplicationUsers.Find(new Guid(textBox2.Text));
                
                // If the object is found, update its properties and save changes to the database
                if (applicationUserToUpdate != null)
                {
                    applicationUserToUpdate.UserName = textBox1.Text;
                    applicationUserToUpdate.ApplicationRoleId = Data.FirstOrDefault(x => x.Name == comboBox1.SelectedItem.ToString()).Id;
                    applicationUserToUpdate.ApplicationRoleName = Data.FirstOrDefault(x => x.Name == comboBox1.SelectedItem.ToString()).Name;
                    applicationUserToUpdate.NormalizedUserName = textBox3.Text;
                    applicationUserToUpdate.Email = textBox4.Text;
                    applicationUserToUpdate.NormalizedEmail = textBox5.Text;
                    applicationUserToUpdate.PasswordHash = hasher.HashPassword(new ApplicationUser(), textBox6.Text);
                    applicationUserToUpdate.PhoneNumber = textBox7.Text;

                    saveContext.Update(applicationUserToUpdate);
                    saveContext.SaveChanges();
                }
            }
            saveContext.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
              
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
