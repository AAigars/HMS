using HMS.Database;

namespace HMSUnitTests
{
    [TestClass]
    public class UserTests
    {
        public UserTests()
        {
            // find database path
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "/HMS/bin/Debug/net6.0-windows/hms.db";

            // connect to database
            HMS.Program.databaseManager = new(path);
        }

        [TestMethod]
        public void Create_Delete_User()
        {               
            // create user
            var user = User.RegisterUser("John", "Doe", "john.doe", "password123");

            // check if object returned
            if (user == null) Assert.Fail();

            // delete user
            User.DeleteUser(user);
        }
    }
}