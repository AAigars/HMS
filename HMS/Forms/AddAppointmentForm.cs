using HMS.Database;

namespace HMS.Forms
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (txtPatient.Text == string.Empty || txtDoctor.Text == string.Empty)
            {
                MessageBox.Show("Invalid patient or doctor has been selected!", Program.title);
                return;
            }

            // fetch patient and user ids.
            var patientName = txtPatient.Text.Split(' ');
            var patient = Patient.GetPatient(patientName[0], patientName[1]);

            var doctorName = txtDoctor.Text.Split(' ');
            var doctor = User.GetUser(doctorName[0], doctorName[1]);

            // sanity check patient and doctor
            if (patient == null || doctor == null)
            {
                MessageBox.Show("Invalid patient or doctor has been selected!", Program.title);
                return;
            }

            if (txtTimestamp.Text == string.Empty || txtNote.Text == string.Empty)
            {
                MessageBox.Show("Timestamp or note has not been provided!", Program.title);
                return;
            }

            // attempt to insert appointment
            Appointment.AddAppointment(doctor, patient, txtTimestamp.Text, txtNote.Text);

            // todo: proper success/error dialog
            new AppointmentsForm().Show();
            Close();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            // auto complete patients
            var patients = Patient.GetPatients();
            foreach (var patient in patients)
            {
                txtPatient.AutoCompleteCustomSource.Add(patient.FirstName + " " + patient.LastName);
            }

            // auto complete doctors
            var doctors = User.GetUsers(3); // TODO: Role enum...
            foreach (var doctor in doctors)
            {
                txtDoctor.AutoCompleteCustomSource.Add(doctor.FirstName + " " + doctor.LastName);
            }

            // auto complete check in time
            var times = new List<DateTime>();
            var currentTime = DateTime.ParseExact(DateTime.Now.ToShortDateString() + " 08:00:00", "dd/MM/yyyy HH:mm:ss", null);

            for (int i = 0; i < 10; i++)
            {
                currentTime = currentTime.AddMinutes(30);
                times.Add(currentTime);
            }

            foreach (var time in times)
            {
                // TODO: check if time slot is taken before adding to autocomplete
                txtTimestamp.AutoCompleteCustomSource.Add(time.ToString());
            }
        }

        private void AddAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AppointmentsForm().Show();
        }
    }
}