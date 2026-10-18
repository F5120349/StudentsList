using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using StudentsList;


Console.WriteLine("Students List LINQ\n");

List<Student> students = AddStudents();

static void DisplayStudents(List<Student> students)
{
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}

Console.WriteLine("Students enrolled in Computer Science sorted in descending order\n");

var CS_Students_Descending = students
    .Where(s => s.course == "Computer Science") // filter by students enrolled in Computer Science
    .OrderByDescending(s => s.mark) // sort the list of marks of those students into descending order
    .ToList(); // convert the result to a list

DisplayStudents(CS_Students_Descending);

static List<Student> AddStudents()
{
    return new List<Student>
{
    new Student("Smith", "John", 20, "Computer Science", 85, 2022),
    new Student("Johnson", "Emily", 22, "Mathematics", 90, 2021),
    new Student("Williams", "Michael", 21, "Physics", 78, 2022),
    new Student("Brown", "Sarah", 19, "Chemistry", 92, 2023),
    new Student("Davis", "David", 23, "Biology", 88, 2021),
    new Student("Miller", "Jessica", 20, "Computer Science", 95, 2022),
    new Student("Wilson", "Daniel", 22, "Mathematics", 80, 2021)
};
}
