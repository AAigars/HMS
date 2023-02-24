using HMS.Database;
using HMS.Interface;
using HMS.Properties;

namespace HMS.Forms
{
    public partial class AppointmentsForm : Form
    {
        private bool isSwitching = false;
        private Table table;
        private int page = 0;

        public AppointmentsForm()
        {
            InitializeComponent();
            table = new Table(tblAppointments);
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
            table.CreateHeader(new string[] { "First Name", "Last Name", "Doctor", "Timestamp", "Actions" });
            table.CreateAction(Resources.View);
            table.CreateAction(Resources.Delete);

            // load appointments
            var appointments = Appointment.GetAppointments();

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
            if (Program.loginForm != null && !Program.loginForm.Visible && !isSwitching)
                Program.loginForm.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isSwitching = true;
            new AddAppointmentForm().Show();
            Close();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            isSwitching = true;
            new PatientsForm().Show();
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // fetch data
            page += 1;
            var appointments = Appointment.GetAppointments(5, page * 5);

            // check if we got any data
            if (appointments.Length == 0)
            {
                page -= 1;
                return;
            }

            // clear table data
            table.Clear();

            // insert data
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // check if at end
            if (page == 0)
                return;

            // clear table data
            table.Clear();

            // fetch data
            page -= 1;
            var appointments = Appointment.GetAppointments(5, page * 5);

            // insert data
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
    }
}
