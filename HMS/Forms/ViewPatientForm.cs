using HMS.Database;

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
            var addHistory = new ToolStripMenuItem
            {
                Text = "Add"
            };

            var deleteHistory = new ToolStripMenuItem {
                Text = "Delete"
            };

            // setup mouse events
            addHistory.MouseDown += AddHistory_MouseDown;
            deleteHistory.MouseDown += DeleteHistory_MouseDown;

            // create context menus
            contextMenuMedical = new ContextMenuStrip();
            contextMenuMedical.Items.AddRange(new ToolStripMenuItem[] { deleteHistory });

            contextMenuMedical_2 = new ContextMenuStrip();
            contextMenuMedical_2.Items.AddRange(new ToolStripItem[] { addHistory });

            // asign mouse down event on listbox
            lbxMedicalHistory.MouseDown += lbxMedicalHistory_MouseDown;

            // setup context menu for prescriptions
            var addPrescription = new ToolStripMenuItem
            {
                Text = "Add"
            };

            var deletePrescription = new ToolStripMenuItem
            {
                Text = "Delete"
            };

            // setup mouse events
            addPrescription.MouseDown += AddPrescription_MouseDown;
            deletePrescription.MouseDown += DeletePrescription_MouseDown;

            // create context menus
            contextMenuPrescriptions = new ContextMenuStrip();
            contextMenuPrescriptions.Items.AddRange(new ToolStripMenuItem[] { deletePrescription });

            contextMenuPrescriptions_2 = new ContextMenuStrip();
            contextMenuPrescriptions_2.Items.AddRange(new ToolStripItem[] { addPrescription });

            // assign mouse down event on listbox
            lbxPrescriptions.MouseDown += lbxPrescriptions_MouseDown;
        }

        private void DeletePrescription_MouseDown(object? sender, MouseEventArgs e)
        {
            Prescription.DeletePrescription(lbxPrescriptions.Items[selectedIndex] as PrescriptionModel);
            PatientsForm_Load(sender, null);
        }

        private void DeleteHistory_MouseDown(object? sender, MouseEventArgs e)
        {
            MedicalHistory.DeleteMedicalHistory(lbxMedicalHistory.Items[selectedIndex] as MedicalHistoryModel);
            PatientsForm_Load(sender, null);
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
    }
}
