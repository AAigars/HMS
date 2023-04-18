using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class PatientModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("first_name")]
        public string? FirstName { get; set; }

        [DbColumn("last_name")]
        public string? LastName { get; set; }

        [DbColumn("date_of_birth")]
        public string? DateOfBirth { get; set; }

        [DbColumn("gender")]
        public string? Gender { get; set; }

        [DbColumn("address")]
        public string? Address { get; set; }

        [DbColumn("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    public static class Patient
    {
        public static PatientModel[] GetPatients(int limit = 0, int offset = 0)
        {
            string query = "SELECT * FROM Patient ORDER BY id";
            if (limit != 0)
            {
                query += " LIMIT " + limit + " OFFSET " + offset;
            }

            return Program.databaseManager.ExecuteMappedQuery<PatientModel>(query);
        }

        public static PatientModel? GetPatient(string firstName, string lastName)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM Patient WHERE first_name = ? AND last_name = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("first_name", firstName));
            command.Parameters.Add(new SQLiteParameter("last_name", lastName));

            // attempt to fetch user
            return Program.databaseManager.ExecuteMappedQuery<PatientModel>(command).FirstOrDefault();
        }

        public static PatientModel? UpdatePatient(PatientModel patient)
        {
            // set up prepared statement
            var command = new SQLiteCommand("UPDATE Patient SET first_name = @first_name, last_name = @last_name, date_of_birth = @date_of_birth, gender = @gender, address = @address, phone_number = @phone_number WHERE id = @id", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("@id", patient.Id));
            command.Parameters.Add(new SQLiteParameter("@first_name", patient.FirstName));
            command.Parameters.Add(new SQLiteParameter("@last_name", patient.LastName));
            command.Parameters.Add(new SQLiteParameter("@date_of_birth", patient.DateOfBirth));
            command.Parameters.Add(new SQLiteParameter("@gender", patient.Gender));
            command.Parameters.Add(new SQLiteParameter("@address", patient.Address));
            command.Parameters.Add(new SQLiteParameter("@phone_number", patient.PhoneNumber));

            // attempt to update patient data
            return Program.databaseManager.ExecuteMappedQuery<PatientModel>(command).FirstOrDefault();
        }

        public static PatientModel? AddPatient(string firstName, string lastName, string dateOfBirth, string gender, string address, string phoneNumber)
        {
            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO Patient (first_name, last_name, date_of_birth, address, phone_number) VALUES (?, ?, ?, ?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("first_name", firstName));
            command.Parameters.Add(new SQLiteParameter("last_name", lastName));
            command.Parameters.Add(new SQLiteParameter("date_of_birth", dateOfBirth));
            command.Parameters.Add(new SQLiteParameter("gender", gender));
            command.Parameters.Add(new SQLiteParameter("address", address));
            command.Parameters.Add(new SQLiteParameter("phone_number", phoneNumber));

            // attempt to insert the new patient into the table
            return Program.databaseManager.ExecuteMappedQuery<PatientModel>(command).FirstOrDefault();
        }

        public static void DeletePatient(PatientModel patient)
        {
            // prepare query
            var command = new SQLiteCommand("DELETE FROM Patient WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", patient.Id));

            // execute query
            Program.databaseManager.ExecuteMappedQuery<PatientModel>(command);
        }
    }
}
