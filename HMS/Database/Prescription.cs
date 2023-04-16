using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class PrescriptionModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("doctor_id")]
        public long DoctorId { get; set; }

        [DbColumn("patient_id")]
        public long PatientId { get; set; }

        [DbColumn("timestamp")]
        public string? TimeStamp { get; set; }

        [DbColumn("medicine")]
        public long Medicine { get; set; }

        [DbColumn("dosage")]
        public double Dosage { get; set; }
    }

    public static class Prescription
    {
        public static PrescriptionModel[] GetPrescription(PatientModel patient)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM Patient_Prescription WHERE patient_id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("patient_id", patient.Id));

            // attempt to fetch prescriptions
            return Program.databaseManager.ExecuteMappedQuery<PrescriptionModel>(command);
        }
    }
}
