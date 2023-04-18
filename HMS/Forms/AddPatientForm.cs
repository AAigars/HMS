using HMS.Database;

namespace HMS.Forms
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            // sanity check fields
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Invalid first name or last name!", Program.title);
                return;
            }

            if (txtDateOfBirth.Text == string.Empty)
            {
                MessageBox.Show("Invalid date of birth!", Program.title);
            }

            if (txtGender.Text == string.Empty)
            {
                MessageBox.Show("Invalid gender!", Program.title);
            }

            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Invalid address!", Program.title);
            }

            if (txtPhoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Invalid phone number!", Program.title);
            }

            // attempt to insert patient
            Patient.AddPatient(txtFirstName.Text, txtLastName.Text, txtDateOfBirth.Text, txtGender.Text, txtAddress.Text, txtPhoneNumber.Text);

            // todo: proper success/error dialog
            Close();
        }

        private void AddPatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new PatientsForm().Show();
        }
    }
}