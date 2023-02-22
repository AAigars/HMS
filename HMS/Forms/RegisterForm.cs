using HMS.Database;
using System.Data.SQLite;

namespace HMS.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // check the fields are valid
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("You have not specified an username or password!", Program.title); 
                return;
            }

            // check if user exists
            var exists = new SQLiteCommand("SELECT COUNT(id) FROM User WHERE username = ?", Program.databaseManager.GetConnection());
            exists.Parameters.Add(new SQLiteParameter("username", txtUsername.Text));

            // execute query and retrieve amount of users with the same username
            var count = Program.databaseManager.ExecuteQuery<long>(exists).FirstOrDefault();
            if (count > 0)
            {
                MessageBox.Show("User with that username already exists!", Program.title);
                return;
            }

            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO User (username, password) VALUES (?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("username", txtUsername.Text));
            command.Parameters.Add(new SQLiteParameter("password", txtPassword.Text));

            // attempt to insert the new user into the table
            var user = Program.databaseManager.ExecuteMappedQuery<User>(command).FirstOrDefault();

            // check if the user is valid
            if (user != null)
            {
                // todo: account needs verification
            }
            else
            {
                MessageBox.Show("An error has occured during the account creation process, try again!", Program.title);
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            btnRegister_Click(sender, e);
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
            if (Program.loginForm != null && !Program.loginForm.Visible)
                Program.loginForm.Close();
        }
    }
}