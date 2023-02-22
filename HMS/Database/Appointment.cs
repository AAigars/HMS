using DbDataReaderMapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SQLite;

namespace HMS.Database
{
    public class AppointmentModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("doctor_id")]
        public long DoctorId { get; set; }

        [DbColumn("patient_id")]
        public long PatientId { get; set; }

        [DbColumn("first_name")]
        public string? PatientFirstName { get; set; }

        [DbColumn("last_name")]
        public string? PatientLastName { get; set; }

        [DbColumn("doctor")]
        public string? DoctorFirstName { get; set; }

        [DbColumn("timestamp")]
        public string? Timestamp { get; set; }

        [DbColumn("note")]
        public string? Note { get; set; }
    }

    public static class Appointment
    {
        public static AppointmentModel[] GetAppointments()
        {
            // prepare query
            string query = 
                "SELECT Patient.first_name, Patient.last_name, User.first_name AS doctor, timestamp, note " +
                "FROM Appointment " +
                "INNER JOIN Patient ON Appointment.patient_id = Patient.id " +
                "INNER JOIN User ON Appointment.doctor_id = User.id";

            // execute and return query
            return Program.databaseManager.ExecuteMappedQuery<AppointmentModel>(query);
        }

        public static void RemoveAppointment(AppointmentModel appointment)
        {
            // prepare query
            var command = new SQLiteCommand("DELETE FROM Appointment WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", appointment.Id));

            // execute query
            Program.databaseManager.ExecuteMappedQuery<AppointmentModel>(command);
        }

        public static AppointmentModel? AddAppointment(UserModel doctor, PatientModel patient, string timestamp, string note)
        {
            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO Appointment (doctor_id, patient_id, timestamp, note) VALUES (?, ?, ?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("doctor_id", doctor.Id));
            command.Parameters.Add(new SQLiteParameter("patient_id", patient.Id));
            command.Parameters.Add(new SQLiteParameter("timestamp", timestamp));
            command.Parameters.Add(new SQLiteParameter("note", note));

            // attempt to insert the new appointment into the table
            return Program.databaseManager.ExecuteMappedQuery<AppointmentModel>(command).FirstOrDefault();
        }
    }
}
