namespace Medicine
{
    internal class Appointment
    {

        public string PatientName { get; set; }
        public DateTime Date { get; set; }

        public Appointment(string patientName, DateTime date)
        {
            PatientName = patientName;
            Date = date;
        }
    }
}
