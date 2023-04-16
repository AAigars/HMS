using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class MedicalHistoryModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("patient_id")]
        public long PatientId { get; set; }

        [DbColumn("timestamp")]
        public string? TimeStamp { get; set; }

        [DbColumn("note")]
        public string? Note { get; set; }
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
    }
}
