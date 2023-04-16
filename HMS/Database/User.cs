using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class UserModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("department_id")]
        public long DepartmentId { get; set; }

        [DbColumn("first_name")]
        public string? FirstName { get; set; }

        [DbColumn("last_name")]
        public string? LastName { get; set; }

        [DbColumn("address")]
        public string? Address { get; set; }

        [DbColumn("phone_number")]
        public long PhoneNumber { get; set; }

        [DbColumn("role")]
        public long Role { get; set; }
    }

    public static class User
    {
        public static UserModel[] GetUsers(int role = 0)
        {
            string query = "SELECT * FROM User";
            if (role != 0) query += " WHERE role = " + role;

            return Program.databaseManager.ExecuteMappedQuery<UserModel>(query);
        }

        public static UserModel? GetUser(string firstName, string lastName)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM User WHERE first_name = ? AND last_name = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("first_name", firstName));
            command.Parameters.Add(new SQLiteParameter("last_name", lastName));

            // attempt to fetch user
            return Program.databaseManager.ExecuteMappedQuery<UserModel>(command).FirstOrDefault();
        }

        public static UserModel? AuthUser(string username, string password)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM User WHERE username = ? AND password = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("username", username));
            command.Parameters.Add(new SQLiteParameter("password", password));

            // attempt to authenticate the user
            return Program.databaseManager.ExecuteMappedQuery<UserModel>(command).FirstOrDefault();
        }

        public static UserModel? RegisterUser(string username, string password)
        {
            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO User (username, password) VALUES (?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("username", username));
            command.Parameters.Add(new SQLiteParameter("password", password));

            // attempt to insert the new user into the table
            return Program.databaseManager.ExecuteMappedQuery<UserModel>(command).FirstOrDefault();

        }
    }
}
