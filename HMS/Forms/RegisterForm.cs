using HMS.Database;
using System.Data.SQLite;

namespace HMS.Forms
{
    public partial class RegisterForm : Form
    {
        private bool isSwitching = false;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // check the fields are valid
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("You have not filled in all the required fields!", Program.title);
                return;
            }

            var username = string.Format("{0}.{1}", txtFirstName.Text.ToLower(), txtLastName.Text.ToLower());

            // check if user exists
            var exists = new SQLiteCommand("SELECT COUNT(id) FROM User WHERE username = ?", Program.databaseManager.GetConnection());
            exists.Parameters.Add(new SQLiteParameter("username", username));

            // execute query and retrieve amount of users with the same username
            var count = Program.databaseManager.ExecuteQuery<long>(exists).FirstOrDefault();
            if (count > 0)
            {
                MessageBox.Show("User with that username already exists!", Program.title);
                return;
            }

            // attempt to insert the new user into the table
            var user = User.RegisterUser(txtFirstName.Text, txtLastName.Text, username, txtPassword.Text);

            // check if the user is valid
            if (user != null)
            {
                MessageBox.Show("Your account has been created, please contact the system admin to approve the account!", Program.title);

                isSwitching = true;
                Program.loginForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("An error has occured during the account creation process, try again!", Program.title);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            // redirect to login form
            if (Program.loginForm == null)
                return;

            Program.loginForm.Show();
            Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, this form won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing this form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible && !isSwitching)
                Program.loginForm.Close();
        }
    }
}