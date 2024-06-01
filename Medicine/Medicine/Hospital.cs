namespace Medicine
{
    internal class Hospital
    {
        private List<Doctor> doctors = new List<Doctor>();
        private List<Appointment> appointments = new List<Appointment>();

        public void AddDoctor(string name)
        {
            doctors.Add(new Doctor(name));
            Console.WriteLine($"Doctor {name} added successfully.");
        }

        public void ViewAllDoctors()
        {
            Console.WriteLine("List of doctors:");
            foreach (var doctor in doctors)
            {
                Console.WriteLine(doctor.Name);
            }
        }

        public void ScheduleAppointment(string patientName, DateTime date)
        {
            if (IsSlotAvailable(date))
            {
                appointments.Add(new Appointment(patientName, date));
                Console.WriteLine($"Appointment scheduled for {patientName} on {date}.");
            }
            else
            {
                Console.WriteLine($"Appointment slot already taken for {date}. Please choose another time.");
            }
        }

        public void ViewAppointmentsOfDoctor(string doctorName)
        {
            var doctorAppointments = appointments.Where(appointment => doctors.Any(doctor => doctor.Name == doctorName) && appointment.Date > DateTime.Now).ToList();
            if (doctorAppointments.Any())
            {
                Console.WriteLine($"Appointments of {doctorName}:");
                foreach (var appointment in doctorAppointments)
                {
                    Console.WriteLine($"Patient: {appointment.PatientName}, Date: {appointment.Date}");
                }
            }
            else
            {
                Console.WriteLine($"No appointments found for {doctorName}.");
            }
        }

        private bool IsSlotAvailable(DateTime date)
        {
            return !appointments.Any(appointment => appointment.Date == date);
        }
    }
}