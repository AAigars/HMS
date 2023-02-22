using HMS.Database;
using System.Data.SQLite;

namespace HMS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check the fields are valid
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("You have not specified an username or password!", Program.title); 
                return;
            }

            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM User WHERE username = ? AND password = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("username", txtUsername.Text));
            command.Parameters.Add(new SQLiteParameter("password", txtPassword.Text));

            // attempt to authenticate the user
            var user = Program.databaseManager.ExecuteMappedQuery<User>(command).FirstOrDefault();

            // check if the user is valid
            if (user != null)
            {
                // check user role
                if (user.Role == 0)
                {
                    MessageBox.Show("The account has not been verified, please contact a system administrator!", Program.title);
                    return;
                }

                // allows us to access the user object globally
                Program.user = user;

                // redirect to the appointments form
                Hide();
                new AppointmentsForm().Show();
            }
            else
            {
                MessageBox.Show("You have entered an incorrect username or password!", Program.title);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            // redirect to the register form
            Hide();
            new RegisterForm().Show();
        }
    }
}