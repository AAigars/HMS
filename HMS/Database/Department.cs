using DbDataReaderMapper;

namespace HMS.Database
{
    public class DepartmentModel
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

    public static class Department
    {
        public static DepartmentModel[] GetDepartments()
        {
            string query = "SELECT * FROM Department";
            return Program.databaseManager.ExecuteMappedQuery<DepartmentModel>(query);
        }
    }
}
