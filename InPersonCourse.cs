using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_University_Course_Enrollment
{
    internal class InPersonCourse:Student, ICourse
    {
        public static int count ; // to track capacity of room;
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int  CourseDuration { get; set; }
        public int RoomNo { get; set; } = 3;
        
       
        public InPersonCourse(int id, string studentname, DateOnly dob, int course_id, string courseName, int courseDuration) : base(id, studentname, dob)
        {
            CourseId = course_id;
            CourseName = courseName;
            CourseDuration = courseDuration;
            count++;
            
        }
        
        public override string GetCourseDetails()
        {
            return $"In Person Course: {CourseName}, Duration: {CourseDuration} months, RoomNo: {RoomNo}";
        }

    }
}
