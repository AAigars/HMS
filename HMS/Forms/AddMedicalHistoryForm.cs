using HMS.Database;

namespace HMS.Forms
{
    public partial class AddMedicalHistoryForm : Form
    {
        private readonly PatientModel patient;

        public AddMedicalHistoryForm(PatientModel patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            // sanity check medicine and dosage
            if (txtHistory.Text == string.Empty)
            {
                MessageBox.Show("History has not been provided!", Program.title);
                return;
            }

            // attempt to insert medical history
            MedicalHistory.AddMedicalHistory(patient, txtHistory.Text);

            // todo: proper success/error dialog
            Close();
        }

        private void AddMedicalHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ViewPatientForm(patient).Show();
        }
    }
}