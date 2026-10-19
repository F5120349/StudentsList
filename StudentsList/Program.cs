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

Console.WriteLine("\nStudents who enrolled after 2020 sorted by enrolment year\n");

var Students_After_2020 = students
    .Where(s => s.EnrolmentYear > 2020) // filter by students who enrolled after 2020
    .OrderBy(s => s.EnrolmentYear) // sort the list of enrolment years of those students into ascending order
    .ToList(); // convert the result to a list

DisplayStudents(Students_After_2020);

Console.WriteLine("\nAverage mark for each course\n");

var Average_Mark_Per_Course = students
    .GroupBy(s => s.course) // group the students by course
    .Select(g => new
    {
        Course = g.Key, // get the course name
        AverageMark = g.Average(s => s.mark) // calculate the average mark for each course
    });

foreach (var course in Average_Mark_Per_Course)
{
    Console.WriteLine($"Course: {course.Course}, Average Mark: {course.AverageMark}");
}

Console.WriteLine("\nYoungest student in each course\n");

var Youngest_Student_Per_Course = students
    .GroupBy(s => s.course) // group the students by course
    .Select(g => new
    {
        Course = g.Key, // get the course name
        YoungestStudent = g.OrderBy(s => s.age).FirstOrDefault() // get the youngest student in each course
    });

foreach (var course in Youngest_Student_Per_Course)
{
    Console.WriteLine($"Course: {course.Course}, Youngest Student: {course.YoungestStudent}");
}

Console.WriteLine("\nNumber of students in each enrolment year\n");

var Students_Per_Enrolment_Year = students
    .GroupBy(s => s.EnrolmentYear)
    .Select(g => new
    {
        EnrolmentYear = g.Key,
        NumberOfStudents = g.Count()
    });

foreach (var year in Students_Per_Enrolment_Year)
{
    Console.WriteLine($"Enrolment Year: {year.EnrolmentYear}, Number of Students: {year.NumberOfStudents}");
}

Console.WriteLine("\nStudents with marks between 70 and 85 sorted by mark in ascending order\n");

var Students_Between_70_And_85 = students
    .Where(s => s.mark >= 70 && s.mark <= 85)
    .OrderBy(s => s.mark)
    .ToList();

DisplayStudents(Students_Between_70_And_85);

Console.WriteLine("\nStudents older than 21 sorted by mark in descending order\n");

var Students_Older_Than_21 = students
    .Where(s => s.age > 21)
    .OrderByDescending(s => s.mark)
    .ToList();

DisplayStudents(Students_Older_Than_21);

Console.WriteLine("\nTop 3 students with the highest marks\n");

var Top_3_Students = students
    .OrderByDescending(s => s.mark)
    .Take(3)
    .ToList();

DisplayStudents(Top_3_Students);

Console.WriteLine("\nSelect and transform data\n");

var Students_Above_80 = students
    .Select(s => new
    {
        Name = $"{s.forename} {s.surname}",
        Course = s.course,
        IsAbove80 = s.mark > 80
    })
    .ToList();

foreach (var student in Students_Above_80)
{
    Console.WriteLine($"Name: {student.Name}, Course: {student.Course}, Is Above 80: {student.IsAbove80}");
}

Console.WriteLine("\nAggregate data\n");

var Aggregate_Data = students
    .GroupBy(_ => 1)
    .Select(g => new
    {
        TotalStudents = g.Count(),
        AverageMark = g.Average(s => s.mark),
        HighestMark = g.Max(s => s.mark)
    })
    .FirstOrDefault();

if (Aggregate_Data != null)
{
    Console.WriteLine($"Total Students: {Aggregate_Data.TotalStudents}");
    Console.WriteLine($"Average Mark: {Aggregate_Data.AverageMark:F0}");
    Console.WriteLine($"Highest Mark: {Aggregate_Data.HighestMark}");
}

static List<Student> AddStudents()
{
    return new List<Student>
{
    new Student("Smith", "John", 20, "Computer Science", 85, 2022),
    new Student("Johnson", "Emily", 22, "Mathematics", 90, 2021),
    new Student("Williams", "Michael", 21, "Physics", 78, 2022),
    new Student("Brown", "Sarah", 19, "Chemistry", 92, 2023),
    new Student("Davis", "David", 11, "Biology", 88, 2021),
    new Student("Miller", "Jessica", 20, "Computer Science", 95, 2022),
    new Student("Wilson", "Daniel", 22, "Mathematics", 80, 2021),
    new Student("Nicholson", "Alfie", 21, "Computer Science", 75, 2018),
};
}
