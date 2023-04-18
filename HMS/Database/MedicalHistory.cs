using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class MedicalHistoryModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("doctor_id")]
        public long DoctorId { get; set; }

        [DbColumn("patient_id")]
        public long PatientId { get; set; }

        [DbColumn("timestamp")]
        public string? Timestamp { get; set; }

        [DbColumn("note")]
        public string? Note { get; set; }

        public override string? ToString()
        {
            return Note;
        }
    }

    public static class MedicalHistory
    {
        public static MedicalHistoryModel[] GetMedicalHistory(PatientModel patient)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM Patient_Medical WHERE patient_id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("patient_id", patient.Id));

            // attempt to fetch history
            return Program.databaseManager.ExecuteMappedQuery<MedicalHistoryModel>(command);
        }

        public static MedicalHistoryModel? AddMedicalHistory(PatientModel patient, string note)
        {
            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO Patient_Medical (patient_id, doctor_id, timestamp, note) VALUES (?, ?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("doctor_id", Program.user.Id));           
            command.Parameters.Add(new SQLiteParameter("patient_id", patient.Id));
            command.Parameters.Add(new SQLiteParameter("timestamp", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()));
            command.Parameters.Add(new SQLiteParameter("note", note));

            // attempt to insert the new appointment into the table
            return Program.databaseManager.ExecuteMappedQuery<MedicalHistoryModel>(command).FirstOrDefault();
        }

        public static void DeleteMedicalHistory(MedicalHistoryModel history)
        {
            // prepare query
            var command = new SQLiteCommand("DELETE FROM Patient_Medical WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", history.Id));

            // execute query
            Program.databaseManager.ExecuteMappedQuery<MedicalHistoryModel>(command);
        }
    }
}
