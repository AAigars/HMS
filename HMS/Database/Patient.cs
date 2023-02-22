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

        [DbColumn("address")]
        public string? Address { get; set; }

        [DbColumn("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    public static class Patient
    {
        public static PatientModel[] GetPatients()
        {
            string query = "SELECT * FROM Patient";
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
    }
}
