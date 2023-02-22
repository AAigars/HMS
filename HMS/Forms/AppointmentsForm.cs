using HMS.Database;
using HMS.Interface;
using HMS.Properties;

namespace HMS.Forms
{
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
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
            table.CreateHeader(new string[] { "First Name", "Last Name", "Doctor", "Timestamp", "Actions" });
            table.CreateAction(Resources.View);
            table.CreateAction(Resources.Delete);

            // load appointments
            var appointments = Program.databaseManager.ExecuteMappedQuery<Appointment>("SELECT Patient.first_name, Patient.last_name, User.first_name AS doctor, timestamp FROM Appointment INNER JOIN Patient ON Appointment.patient_id = Patient.id INNER JOIN User ON Appointment.doctor_id = User.id");

            foreach (var appointment in appointments)
            {
                table.CreateEntry(
                    new string?[]
                    {
                        appointment.PatientFirstName,
                        appointment.PatientLastName,
                        appointment.DoctorFirstName,
                        appointment.Timestamp
                    }
                );
            }
        }

        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // shouldn't ever be null anyway (without LoginForm, this form won't even be instantiated)
            // force the login form to close as that is the entry point of the program
            // otherwise closing this form will cause the program to remain open in the background.
            if (Program.loginForm != null && !Program.loginForm.Visible)
                Program.loginForm.Close();
        }
    }
}
