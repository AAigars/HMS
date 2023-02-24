using HMS.Database;
using HMS.Interface;
using HMS.Properties;

namespace HMS.Forms
{
    public partial class PatientsForm : Form
    {
        private bool isSwitching = false;
        private Table table;
        private int page = 0;

        public PatientsForm()
        {
            InitializeComponent();
            table = new Table(tblAppointments);
        }

        private void OnView(object data)
        {
            var patient = (PatientModel)data;
        }

        private void OnDelete(object data)
        {
            var patient = (PatientModel)data;
        }

        private void LoadData()
        {
            // load patients
            var patients = Patient.GetPatients(5, page * 5);

            // check if we got any data
            if (patients.Length == 0)
            {
                page -= 1;
                return;
            }

            // clear table data
            table.Clear();

            // insert data
            foreach (var patient in patients)
            {
                table.CreateEntry(
                    new string?[]
                    {
                        patient.FirstName,
                        patient.LastName,
                        patient.DateOfBirth
                    },
                    patient
                );
            }
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
            table.CreateHeader(new string[] { "First Name", "Last Name", "Date of Birth", "Actions" });
            table.CreateAction(Resources.View, OnView);
            table.CreateAction(Resources.Delete, OnDelete);

            // load patients
            LoadData();
        }

        private void PatientsForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            // fetch data
            page += 1;
            LoadData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // check if at end
            if (page == 0)
                return;

            // fetch data
            page -= 1;
            LoadData();
        }
    }
}
