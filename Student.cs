using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_University_Course_Enrollment
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DOB { get; set; }

        public Student(int id, string name, DateOnly dOB)
        {
            Id = id;
            Name = name;
            DOB = dOB;
        }

        public static int GenerateStudentId()
        {
            Random rnd = new Random();
           return rnd.Next(100000,999999);

        }
        public virtual string GetCourseDetails()
        {
            return "No course information available.";
        }


    }
}
