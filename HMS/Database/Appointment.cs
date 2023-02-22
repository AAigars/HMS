using DbDataReaderMapper;

namespace HMS.Database
{
    public class Appointment
    {
        [DbColumn("id")]
        public long Id { get; set; }

        [DbColumn("doctor_id")]
        public long DoctorId { get; set; }

        [DbColumn("patient_id")]
        public long PatientId { get; set; }

        [DbColumn("first_name")]
        public string? PatientFirstName { get; set; }

        [DbColumn("last_name")]
        public string? PatientLastName { get; set; }

        [DbColumn("doctor")]
        public string? DoctorFirstName { get; set; }

        [DbColumn("timestamp")]
        public string? Timestamp { get; set; }

        [DbColumn("note")]
        public string? Note { get; set; }
    }
}
