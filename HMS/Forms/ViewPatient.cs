using HMS.Database;

namespace HMS.Forms
{
    public partial class ViewPatient : Form
    {
        private PatientModel patient;
        private bool isSwitching = false;

        public ViewPatient(PatientModel patient)
        {
            InitializeComponent();
            this.patient = patient;
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

            // set data
            lblPatient.Text = patient.FirstName + " " + patient.LastName;
            lblDateOfBirth.Text = patient.DateOfBirth;
            lblGender.Text = "Male";
            lblAddress.Text = string.Join("\n", patient.Address.Split(","));

            // get medical history
            var history = MedicalHistory.GetMedicalHistory(patient);
            lblMedicalHistory.Text = string.Join("\n", history.Select(h => h.Note));

            // get prescriptions
            var prescriptions = Prescription.GetPrescription(patient);
            lblPrescriptions.Text = string.Join("\n", prescriptions.Select(h =>
            {
                var medicine = Medicine.GetMedicine(h.Medicine);
                return (medicine != null ? medicine.Name : "Unknown") + " (" + h.Dosage + "mg)";
            }));
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

        private void label1_Click(object sender, EventArgs e)
        {
            isSwitching = true;
            new PatientsForm().Show();
            Close();
        }
    }
}
