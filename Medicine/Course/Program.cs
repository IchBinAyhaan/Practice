namespace Course
{
   class Program
{
    static void Main(string[] args)
    {
        Course course = new Course();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Group");
            Console.WriteLine("2. Display Groups");
            Console.WriteLine("3. Display Students in All Groups");
            Console.WriteLine("4. Add Student to Group");
            Console.WriteLine("5. Remove Student from Group");
            Console.WriteLine("6. Edit Student in Group");
            Console.WriteLine("7. Search Students");
            Console.WriteLine("8. Remove Student by ID");
            Console.WriteLine("9. Display Students in Group");
            Console.WriteLine("10. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter group name: ");
                    string groupName = Console.ReadLine();
                    Console.Write("Enter group limit: ");
                    int groupLimit = Convert.ToInt32(Console.ReadLine());
                        Group newGroup = new Group(course.groups.Count + 1, groupName, groupLimit);

                        course.AddGroup(newGroup);
                    break;
                case 2:
                    course.DisplayGroups();
                    break;
                case 3:
                    course.DisplayStudentsInAllGroups();
                    break;
                case 4:
                    Console.Write("Enter group name: ");
                    string groupNameToAdd = Console.ReadLine();
                    Console.Write("Enter student name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Enter student surname: ");
                    string studentSurname = Console.ReadLine();
                    Console.Write("Enter student age: ");
                    int studentAge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter student grade: ");
                    string studentGrade = Console.ReadLine();
                    Student newStudent = new Student(studentName, studentSurname, studentAge, studentGrade);
                    course.AddStudentToGroup(groupNameToAdd, newStudent);
                    break;
                case 5:
                    Console.Write("Enter group name: ");
                    string groupNameToRemove = Console.ReadLine();
                    Console.Write("Enter student ID: ");
                    int studentIdToRemove = Convert.ToInt32(Console.ReadLine());
                    course.RemoveStudentFromGroup(groupNameToRemove, studentIdToRemove);
                    break;
                case 6:
                    Console.Write("Enter group name: ");
                    string groupNameToEdit = Console.ReadLine();
                    Console.Write("Enter student ID: ");
                    int studentIdToEdit = Convert.ToInt32(Console.ReadLine());
                    course.EditStudentInGroup(groupNameToEdit, studentIdToEdit);
                    break;
                case 7:
                    Console.Write("Enter search term: ");
                    string searchTerm = Console.ReadLine();
                    course.SearchStudents(searchTerm);
                    break;
                case 8:
                    Console.Write("Enter student ID: ");
                    int studentIdToRemoveById = Convert.ToInt32(Console.ReadLine());
                    course.RemoveStudentById(studentIdToRemoveById);
                    break;
                case 9:
                    Console.Write("Enter group name: ");
                    string groupNameToDisplay = Console.ReadLine();
                    course.DisplayStudentsInGroup(groupNameToDisplay);
                    break;
                case 10:
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