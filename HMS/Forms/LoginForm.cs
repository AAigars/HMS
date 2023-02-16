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
            var user = Program.databaseManager.ExecuteMappedQuery<User>(command);

            // check if the user is valid
            if (user != null)
            {
                // allows us to access the user object globally
                Program.user = user;

                // todo: redirect to dashboard
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
    }
}