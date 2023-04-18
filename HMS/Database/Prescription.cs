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
        public string? Timestamp { get; set; }

        [DbColumn("medicine")]
        public long Medicine { get; set; }

        [DbColumn("dosage")]
        public double Dosage { get; set; }

        public override string ToString()
        {
            var medicine = Database.Medicine.GetMedicine(Medicine);
            return (medicine != null ? medicine.Name : "Unknown") + " (" + Dosage + "mg)";
        }
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

        public static PrescriptionModel? AddPrescription(PatientModel patient, long medicine, double dosage)
        {
            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO Patient_Prescription (doctor_id, patient_id, timestamp, medicine, dosage) VALUES (?, ?, ?, ?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("doctor_id", Program.user.Id));
            command.Parameters.Add(new SQLiteParameter("patient_id", patient.Id));
            command.Parameters.Add(new SQLiteParameter("timestamp", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString()));
            command.Parameters.Add(new SQLiteParameter("medicine", medicine));
            command.Parameters.Add(new SQLiteParameter("dosage", dosage));

            // attempt to insert the new appointment into the table
            return Program.databaseManager.ExecuteMappedQuery<PrescriptionModel>(command).FirstOrDefault();
        }

        public static void DeletePrescription(PrescriptionModel prescription)
        {
            // prepare query
            var command = new SQLiteCommand("DELETE FROM Patient_Prescription WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", prescription.Id));

            // execute query
            Program.databaseManager.ExecuteMappedQuery<PrescriptionModel>(command);
        }
    }
}
