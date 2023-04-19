using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class MedicineModel
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("name")]
        public string? Name { get; set; }
    }

    public static class Medicine
    {
        public static MedicineModel[] GetMedicines()
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM Medicine", Program.databaseManager.GetConnection());

            // attempt to fetch medicine
            return Program.databaseManager.ExecuteMappedQuery<MedicineModel>(command);
        }

        public static MedicineModel? GetMedicine(long id)
        {
            // set up prepared statement
            var command = new SQLiteCommand("SELECT * FROM Medicine WHERE id = ?", Program.databaseManager.GetConnection());
            command.Parameters.Add(new SQLiteParameter("id", id));

            // attempt to fetch medicine
            return Program.databaseManager.ExecuteMappedQuery<MedicineModel>(command).FirstOrDefault();
        }
    }
}
