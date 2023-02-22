using DbDataReaderMapper;

namespace HMS.Database
{
    public class Patient
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
}
