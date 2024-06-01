

namespace Course
{
    internal class Course
    {
        public List<Group> groups = new List<Group>();

        public object Groups { get; internal set; }

        public void AddGroup(Group group)
        {
            if (!groups.Any(g => g.Name == group.Name))
            {
                groups.Add(group);
                Console.WriteLine($"Group {group.Name} added to the course.");
            }
            else
            {
                Console.WriteLine($"A group with name {group.Name} already exists.");
            }
        }

        public void DisplayGroups()
        {
            Console.WriteLine("Groups in the course:");
            foreach (var group in groups)
            {
                Console.WriteLine($"Group ID: {group.Id}, Name: {group.Name}, Limit: {group.Limit}");
            }
        }

        public void DisplayStudentsInAllGroups()
        {
            foreach (var group in groups)
            {
                group.DisplayStudents();
            }
        }

        public void AddStudentToGroup(string groupName, Student student)
        {
            Group group = groups.FirstOrDefault(g => g.Name == groupName);
            if (group != null)
            {
                group.AddStudent(student);
            }
            else
            {
                Console.WriteLine($"Group {groupName} not found.");
            }
        }

        public void RemoveStudentFromGroup(string groupName, int studentId)
        {
            Group group = groups.FirstOrDefault(g => g.Name == groupName);
            if (group != null)
            {
                group.RemoveStudent(studentId);
            }
            else
            {
                Console.WriteLine($"Group {groupName} not found.");
            }
        }

        public void EditStudentInGroup(string groupName, int studentId)
        {
            Group group = groups.FirstOrDefault(g => g.Name == groupName);
            if (group != null)
            {
                Student student = group.Students.FirstOrDefault(s => s.Id == studentId);
                if (student != null)
                {
                    Console.WriteLine("Enter new details for the student:");
                    Console.Write("Name: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Surname: ");
                    student.Surname = Console.ReadLine();
                    Console.Write("Age: ");
                    student.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    student.Grade = Console.ReadLine();
                    Console.WriteLine("Student details updated successfully.");
                }
                else
                {
                    Console.WriteLine($"Student with ID {studentId} not found in group {groupName}.");
                }
            }
            else
            {
                Console.WriteLine($"Group {groupName} not found.");
            }
        }

        public void SearchStudents(string searchTerm)
        {
            Console.WriteLine($"Search results for '{searchTerm}':");
            foreach (var group in groups)
            {
                foreach (var student in group.Students)
                {
                    if (student.Name.Contains(searchTerm))
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Group: {group.Name}");
                    }
                }
            }
        }

        public void RemoveStudentById(int studentId)
        {
            foreach (var group in groups)
            {
                Student student = group.Students.FirstOrDefault(s => s.Id == studentId);
                if (student != null)
                {
                    group.Students.Remove(student);
                    Console.WriteLine($"Student {student.Name} removed from group {group.Name}");
                    return;
                }
            }
            Console.WriteLine($"Student with ID {studentId} not found in any group.");
        }

        public void DisplayStudentsInGroup(string groupName)
        {
            Group group = groups.FirstOrDefault(g => g.Name == groupName);
            if (group != null)
            {
                group.DisplayStudents();
            }
            else
            {
                Console.WriteLine($"Group {groupName} not found.");
            }
        }
    }
}
