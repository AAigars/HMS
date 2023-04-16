using HMS.Database;

namespace HMS.Forms
{
    public partial class AddPrescriptionForm : Form
    {
        private readonly PatientModel patient;
        private Dictionary<string, long> medicineMap = new Dictionary<string, long>();

        public AddPrescriptionForm(PatientModel patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            // sanity check medicine and dosage
            if (txtMedicine.Text == string.Empty || txtDosage.Text == string.Empty)
            {
                MessageBox.Show("Medicine or dosage has not been provided!", Program.title);
                return;
            }

            // attempt to insert prescription
            Prescription.AddPrescription(patient, medicineMap[txtMedicine.Text], double.Parse(txtDosage.Text));

            // todo: proper success/error dialog
            Close();
        }

        private void AddPrescriptionForm_Load(object sender, EventArgs e)
        {
            // auto complete patients
            var medicines = Medicine.GetMedicines();
            foreach (var medicine in medicines)
            {
                medicineMap.Add(medicine.Name, medicine.Id);
                txtMedicine.AutoCompleteCustomSource.Add(medicine.Name);
            }
        }

        private void AddPrescriptiontForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ViewPatientForm(patient).Show();
        }
    }
}