using DbDataReaderMapper;

namespace HMS.Database
{
    public class RoleModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("name")]
        public string? Name { get; set; }

        public override string? ToString()
        {
            return Name;
        }
    }

    public static class Role
    {
        public static RoleModel[] GetRoles()
        {
            string query = "SELECT * FROM Role";
            return Program.databaseManager.ExecuteMappedQuery<RoleModel>(query);
        }
    }
}
