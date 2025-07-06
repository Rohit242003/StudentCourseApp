using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_University_Course_Enrollment
{
    internal class OnlineCourse : Student,ICourse
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        public static string Link { get; set; } = "https://www.example.com";

        public OnlineCourse(int id, string studentname, DateOnly dob, int course_id, string courseName, int courseDuration) : base(id, studentname, dob)
        { 
            CourseId = course_id;
            CourseName = courseName;
            CourseDuration = courseDuration;

        }

        public override string GetCourseDetails()
        {
            return $"Online Course: {CourseName}, Duration: {CourseDuration} months, Link: {Link}";
        }

    }
}
