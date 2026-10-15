using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsList
{
    public class Student
    {
        public string surname { get; set; }
        public string forename { get; set; }
        public int age { get; set; }
        public string course { get; set; }
        public int mark { get; set; }
        public int EnrolmentYear { get; set; }

        public Student()
        {
            surname = "Unknown";
            forename = "Unknown";
            age = 0;
            course = "Unknown";
            mark = 0;
            EnrolmentYear = 0;
        }

        public Student(string surname, string forename, int age,
            string course,
            int mark, int EnrolmentYear)
        {
            surname = surname;
            forename = forename;
            age = age;
            course = course;
            mark = mark;
            EnrolmentYear = EnrolmentYear;
        }

        public override string ToString()
        {
            return $"Surname: {surname}, Forename: {forename}," +
                $" Age: {age}, Course: {course}," +
                $" Mark: {mark}, Enrolment Year: {EnrolmentYear}";
        }
    }
}
