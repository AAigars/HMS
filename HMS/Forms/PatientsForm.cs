using HMS.Database;
using HMS.Interface;
using HMS.Properties;

namespace HMS.Forms
{
    public partial class PatientsForm : Form
    {
        private bool isSwitching = false;

        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            // sanity check for user; although the form should never be loaded without user data
            if (Program.user == null)
            {
                MessageBox.Show("Seems like an error has occured, the user data could not be loaded.", Program.title);
                return;
            }

            // set the name label with the user data
            lblName.Text = Program.user.FirstName + " " + Program.user.LastName;

            // setup table
            var table = new Table(tblAppointments);
            table.CreateHeader(new string[] { "First Name", "Last Name", "Date of Birth", "Actions" });
            table.CreateAction(Resources.View);
            table.CreateAction(Resources.Delete);

            // load patients
            var patients = Program.databaseManager.ExecuteMappedQuery<Patient>("SELECT first_name, last_name, date_of_birth FROM Patient");

            foreach (var patient in patients)
            {
                table.CreateEntry(
                    new string?[]
                    {
                        patient.FirstName,
                        patient.LastName,
                        patient.DateOfBirth
                    }
                );
            }
        }

        private void PatientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, this form won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing this form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible && !isSwitching)
                Program.loginForm.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            isSwitching = true;
            new AppointmentsForm().Show();
            Close();
        }
    }
}
