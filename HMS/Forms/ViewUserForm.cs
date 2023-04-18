using HMS.Database;
using Microsoft.VisualBasic;

namespace HMS.Forms
{
    public partial class ViewUserForm : Form
    {
        private readonly UserModel user;
        private bool isSwitching = false;

        public ViewUserForm(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserForm_Load(object sender, EventArgs? e)
        {
            // sanity check for user; although the form should never be loaded without user data
            if (Program.user == null)
            {
                MessageBox.Show("Seems like an error has occured, the user data could not be loaded.", Program.title);
                return;
            }

            // set the name label with the user data
            lblName.Text = Program.user.FirstName + " " + Program.user.LastName;

            // set data
            lblUser.Text = user.FirstName + " " + user.LastName;
            lblDateOfBirth.Text = user.DateOfBirth;
            lblGender.Text = user.Gender;
            lblPhoneNumber.Text = user.PhoneNumber;
            lblAddress.Text = string.Join("\n", user.Address.Split(","));

            lblUsername.Text = user.Username;
            lblRole.Text = user.Role.ToString();
            lblDepartment.Text = user.DepartmentId.ToString();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, this form won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing this form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible && !isSwitching)
                Program.loginForm.Close();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            isSwitching = true;
            new AppointmentsForm().Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            isSwitching = true;
            new PatientsForm().Show();
            Close();
        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, user.DateOfBirth);
            if (input.Length <= 0) return;

            user.DateOfBirth = input;

            User.UpdateUser(user);
            UserForm_Load(this, null);
        }

        private void lblGender_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, user.Gender);
            if (input.Length <= 0) return;

            user.Gender = input;

            User.UpdateUser(user);
            UserForm_Load(this, null);
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, user.Address);
            if (input.Length <= 0) return;

            user.Address = input;

            User.UpdateUser(user);
            UserForm_Load(this, null);
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, user.PhoneNumber);
            if (input.Length <= 0) return;

            user.PhoneNumber = input;

            User.UpdateUser(user);
            UserForm_Load(this, null);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (Program.user.Role < 4)
            {
                MessageBox.Show("You do not have the correct role to access this menu.", Program.title);
                return;
            }

            isSwitching = true;
            new AdminForm().Show();
            Close();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, "password123");
            if (input.Length <= 0) return;

            User.ResetPassword(user, input);
        }
    }
}
