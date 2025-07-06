using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_University_Course_Enrollment
{
    internal class LabCourse:Student ,ICourse 
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
       

        public LabCourse(int id , string studentname, DateOnly dob,int course_id, string courseName, int courseDuration): base(id,studentname,dob)
        {
            CourseId = course_id;
            CourseName = courseName;
            CourseDuration = courseDuration;

        }
        public static bool ValidateCertificate()
        {
            Console.WriteLine("Did you Complete Safety training for Lab Courses. Enter Yes or No");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                Console.WriteLine("Enter Your Safety Course Certificate Number");
                string course_no = (Console.ReadLine());
                if (course_no.Length < 10)
                {
                    throw new Exception("Enter Valid Course Detail");
                }
                if (course_no.Length == 10)
                {
                    Console.WriteLine("Certificate Number Verified.........");
                    return true;
                }
            }
            
            Console.WriteLine("You must finish your safety course to enroll for this Course");
           
            return false;
        }
        public override string GetCourseDetails()
        {
            return $"Lab Course: {CourseName}, Duration: {CourseDuration} months";
        }

    }
}
