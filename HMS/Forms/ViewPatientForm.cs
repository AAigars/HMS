using HMS.Database;
using Microsoft.VisualBasic;

namespace HMS.Forms
{
    public partial class ViewPatientForm : Form
    {
        private readonly PatientModel patient;
        private bool isSwitching = false;

        private readonly ContextMenuStrip contextMenuMedical;
        private readonly ContextMenuStrip contextMenuMedical_2;

        private readonly ContextMenuStrip contextMenuPrescriptions;
        private readonly ContextMenuStrip contextMenuPrescriptions_2;

        private int selectedIndex;

        public ViewPatientForm(PatientModel patient)
        {
            InitializeComponent();
            this.patient = patient;

            // setup context menu for medical history
            var viewHistory = new ToolStripMenuItem
            {
                Text = "View"
            };

            var addHistory = new ToolStripMenuItem
            {
                Text = "Add"
            };

            var deleteHistory = new ToolStripMenuItem
            {
                Text = "Delete"
            };

            // setup mouse events
            viewHistory.MouseDown += ViewHistory_MouseDown;
            addHistory.MouseDown += AddHistory_MouseDown;
            deleteHistory.MouseDown += DeleteHistory_MouseDown;

            // create context menus
            contextMenuMedical = new ContextMenuStrip();
            contextMenuMedical.Items.AddRange(new ToolStripMenuItem[] { viewHistory, deleteHistory });

            contextMenuMedical_2 = new ContextMenuStrip();
            contextMenuMedical_2.Items.AddRange(new ToolStripItem[] { addHistory });

            // asign mouse down event on listbox
            lbxMedicalHistory.MouseDown += lbxMedicalHistory_MouseDown;

            // setup context menu for prescriptions
            var viewPrescription = new ToolStripMenuItem
            {
                Text = "View"

            };

            var addPrescription = new ToolStripMenuItem
            {
                Text = "Add"
            };

            var deletePrescription = new ToolStripMenuItem
            {
                Text = "Delete"
            };

            // setup mouse events
            viewPrescription.MouseDown += ViewPrescription_MouseDown;
            addPrescription.MouseDown += AddPrescription_MouseDown;
            deletePrescription.MouseDown += DeletePrescription_MouseDown;

            // create context menus
            contextMenuPrescriptions = new ContextMenuStrip();
            contextMenuPrescriptions.Items.AddRange(new ToolStripMenuItem[] { viewPrescription, deletePrescription });

            contextMenuPrescriptions_2 = new ContextMenuStrip();
            contextMenuPrescriptions_2.Items.AddRange(new ToolStripItem[] { addPrescription });

            // assign mouse down event on listbox
            lbxPrescriptions.MouseDown += lbxPrescriptions_MouseDown;
        }

        private void ViewPrescription_MouseDown(object? sender, MouseEventArgs e)
        {
            var prescription = lbxPrescriptions.Items[selectedIndex] as PrescriptionModel;
            if (prescription == null) return;

            var medicine = Medicine.GetMedicine(prescription.Medicine);
            if (medicine == null) return;

            var doctor = User.GetUser(prescription.DoctorId);
            if (doctor == null) return;

            MessageBox.Show(
                "Medicine: " + medicine.Name + Environment.NewLine +
                "Dosage: " + prescription.Dosage + "mg" + Environment.NewLine +
                "Doctor: " + doctor.FirstName + " " + doctor.LastName + Environment.NewLine +
                "Timestamp: " + prescription.Timestamp, Program.title);
        }

        private void ViewHistory_MouseDown(object? sender, MouseEventArgs e)
        {
            var history = lbxMedicalHistory.Items[selectedIndex] as MedicalHistoryModel;
            if (history == null) return;

            var doctor = User.GetUser(history.DoctorId);
            if (doctor == null) return;

            MessageBox.Show(
                "Note: " + history.Note + Environment.NewLine +
                "Doctor: " + doctor.FirstName + " " + doctor.LastName + Environment.NewLine +
                "Timestamp: " + history.Timestamp, Program.title);
        }

        private void DeletePrescription_MouseDown(object? sender, MouseEventArgs e)
        {
            var prescription = lbxPrescriptions.Items[selectedIndex] as PrescriptionModel;
            if (prescription == null) return;

            Prescription.DeletePrescription(prescription);
            PatientsForm_Load(this, null);
        }

        private void DeleteHistory_MouseDown(object? sender, MouseEventArgs e)
        {
            var history = lbxMedicalHistory.Items[selectedIndex] as MedicalHistoryModel;
            if (history == null) return;

            MedicalHistory.DeleteMedicalHistory(history);
            PatientsForm_Load(this, null);
        }

        private void AddHistory_MouseDown(object? sender, MouseEventArgs e)
        {
            isSwitching = true;
            new AddMedicalHistoryForm(patient).Show();
            Close();
        }

        private void AddPrescription_MouseDown(object? sender, MouseEventArgs e)
        {
            isSwitching = true;
            new AddPrescriptionForm(patient).Show();
            Close();
        }

        private void lbxPrescriptions_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            selectedIndex = lbxPrescriptions.IndexFromPoint(e.Location);
            if (selectedIndex != ListBox.NoMatches)
            {
                contextMenuPrescriptions.Show(Cursor.Position);
            }
            else
            {
                contextMenuPrescriptions_2.Show(Cursor.Position);
            }
        }

        private void lbxMedicalHistory_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            selectedIndex = lbxMedicalHistory.IndexFromPoint(e.Location);
            if (selectedIndex != ListBox.NoMatches)
            {
                contextMenuMedical.Show(Cursor.Position);
            }
            else
            {
                contextMenuMedical_2.Show(Cursor.Position);
            }
        }

        private void PatientsForm_Load(object sender, EventArgs? e)
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
            lblGender.Text = patient.Gender;
            lblPhoneNumber.Text = patient.PhoneNumber;
            lblAddress.Text = string.Join("\n", patient.Address.Split(","));

            // get medical history
            var history = MedicalHistory.GetMedicalHistory(patient);
            lbxMedicalHistory.Items.Clear();
            lbxMedicalHistory.Items.AddRange(history);

            // get prescriptions
            var prescriptions = Prescription.GetPrescription(patient);
            lbxPrescriptions.Items.Clear();
            lbxPrescriptions.Items.AddRange(prescriptions);
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

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, patient.DateOfBirth);
            if (input.Length <= 0) return;

            patient.DateOfBirth = input;

            Patient.UpdatePatient(patient);
            PatientsForm_Load(this, null);
        }

        private void lblGender_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, patient.Gender);
            if (input.Length <= 0) return;

            patient.Gender = input;

            Patient.UpdatePatient(patient);
            PatientsForm_Load(this, null);
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, patient.Address);
            if (input.Length <= 0) return;

            patient.Address = input;

            Patient.UpdatePatient(patient);
            PatientsForm_Load(this, null);
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            var input = Interaction.InputBox("To update this field; please input the new value.", Program.title, patient.PhoneNumber);
            if (input.Length <= 0) return;

            patient.PhoneNumber = input;

            Patient.UpdatePatient(patient);
            PatientsForm_Load(this, null);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (Program.user.Role < 5)
            {
                MessageBox.Show("You do not have the correct role to access this menu.", Program.title);
                return;
            }

            isSwitching = true;
            new AdminForm().Show();
            Close();
        }
    }
}
