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

        public Student(string surname, string forename, int age,
            string course,
            int mark, int EnrolmentYear)
        {
            this.surname = surname;
            this.forename = forename;
            this.age = age;
            this.course = course;
            this.mark = mark;
            this.EnrolmentYear = EnrolmentYear;
        }

        public override string ToString()
        {
            return $"Surname: {surname}, Forename: {forename}," +
                $" Age: {age}, Course: {course}," +
                $" Mark: {mark}, Enrolment Year: {EnrolmentYear}";
        }
    }
}
