namespace Medicine
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospital hospital = new Hospital();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add doctor");
                Console.WriteLine("2. View all doctors");
                Console.WriteLine("3. Schedule appointment");
                Console.WriteLine("4. View appointments of doctor");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter doctor's name: ");
                        string doctorName = Console.ReadLine();
                        hospital.AddDoctor(doctorName);
                        break;
                    case 2:
                        hospital.ViewAllDoctors();
                        break;
                    case 3:
                        Console.Write("Enter patient's name: ");
                        string patientName = Console.ReadLine();
                        Console.Write("Enter appointment date and time (yyyy-MM-dd HH:mm): ");
                        DateTime appointmentDate = DateTime.Parse(Console.ReadLine());
                        hospital.ScheduleAppointment(patientName, appointmentDate);
                        break;
                    case 4:
                        Console.Write("Enter doctor's name: ");
                        string doctorNameToViewAppointments = Console.ReadLine();
                        hospital.ViewAppointmentsOfDoctor(doctorNameToViewAppointments);
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
        
    
}