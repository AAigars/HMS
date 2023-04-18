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

        [DbColumn("date_of_birth")]
        public string? DateOfBirth { get; set; }

        [DbColumn("gender")]
        public string? Gender { get; set; }

        [DbColumn("address")]
        public string? Address { get; set; }

        [DbColumn("phone_number")]
        public string? PhoneNumber { get; set; }

        [DbColumn("role")]
        public long Role { get; set; }

        [DbColumn("username")]
        public string? Username { get; set; }
    }

    public static class User
    {
        public static UserModel[] GetUsers(int role = 0, int limit = 0, int offset = 0)
        {
            string query = "SELECT * FROM User ORDER BY id";

            if (limit != 0)
            {
                query += " LIMIT " + limit + " OFFSET " + offset;
            }

            if (role != 0)
            {
                query += " WHERE role = " + role;
            }

            return Program.databaseManager.ExecuteMappedQuery<UserModel>(query);
        }

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

        public static UserModel? GetUser(long id)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM User WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", id));

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

        public static UserModel? RegisterUser(string first_name, string last_name, string username, string password)
        {
            // set up prepared statement
            var command = new SQLiteCommand("INSERT INTO User (first_name, last_name, username, password) VALUES (?, ?, ?, ?) RETURNING *", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("first_name", first_name));
            command.Parameters.Add(new SQLiteParameter("last_name", last_name));
            command.Parameters.Add(new SQLiteParameter("username", username));
            command.Parameters.Add(new SQLiteParameter("password", password));

            // attempt to insert the new user into the table
            return Program.databaseManager.ExecuteMappedQuery<UserModel>(command).FirstOrDefault();
        }

        public static void DeleteUser(UserModel user)
        {
            // prepare query
            var command = new SQLiteCommand("DELETE FROM User WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", user.Id));

            // execute query
            Program.databaseManager.ExecuteMappedQuery<UserModel>(command);
        }

        public static UserModel? UpdateUser(UserModel user)
        {
            // set up prepared statement
            var command = new SQLiteCommand("UPDATE User SET first_name = @first_name, last_name = @last_name, date_of_birth = @date_of_birth, gender = @gender, address = @address, phone_number = @phone_number, role = @role, department_id = @department_id WHERE id = @id", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("@id", user.Id));
            command.Parameters.Add(new SQLiteParameter("@first_name", user.FirstName));
            command.Parameters.Add(new SQLiteParameter("@last_name", user.LastName));
            command.Parameters.Add(new SQLiteParameter("@date_of_birth", user.DateOfBirth));
            command.Parameters.Add(new SQLiteParameter("@gender", user.Gender));
            command.Parameters.Add(new SQLiteParameter("@address", user.Address));
            command.Parameters.Add(new SQLiteParameter("@phone_number", user.PhoneNumber));
            command.Parameters.Add(new SQLiteParameter("@role", user.Role));
            command.Parameters.Add(new SQLiteParameter("@department_id", user.DepartmentId));

            // attempt to update user data
            return Program.databaseManager.ExecuteMappedQuery<UserModel>(command).FirstOrDefault();
        }

        public static UserModel? ResetPassword(UserModel user, string password = "password123")
        {
            var command = new SQLiteCommand("UPDATE User SET password = @password WHERE id = @id", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("@id", user.Id));
            command.Parameters.Add(new SQLiteParameter("@password", password));

            // attempt to update user data
            return Program.databaseManager.ExecuteMappedQuery<UserModel>(command).FirstOrDefault();
        }
    }
}
