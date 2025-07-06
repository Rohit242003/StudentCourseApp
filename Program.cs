namespace Day_15_University_Course_Enrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("1.  Add a student\n2.  Delete Student\n3.  Display Student\n4.  Update Student");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        {
                            Console.WriteLine("Enter the Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the Date of birth");
                            DateOnly date = DateOnly.Parse(Console.ReadLine());
                            int id = Student.GenerateStudentId();
                            Console.WriteLine("Student Id:  " + id);
                            Console.WriteLine("Enter the Mode of Course:\n1.  OnlineCourse\n2.  labcourse\n3.In Person");
                            int ch = Convert.ToInt32(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter Course Id");
                                        int course_id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter Course Name");
                                        string Coursename = Console.ReadLine();
                                        Console.WriteLine("Enter Course Duration in Months");
                                        int courseDuration = int.Parse(Console.ReadLine());
                                        Student stu = new OnlineCourse(id, name,date, course_id, Coursename, courseDuration);
                                        students.Add(stu);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter Course Id");
                                        int course_id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter Course Name");
                                        string Coursename = Console.ReadLine();
                                        Console.WriteLine("Enter Course Duration in Months");
                                        int courseDuration = int.Parse(Console.ReadLine());
                                        Student stu = new LabCourse(id, name, date, course_id, Coursename, courseDuration);
                                        students.Add(stu);
                                        break;

                                    }
                                case 3:
                                    {
                                       
                                        Console.WriteLine("Enter Course Id");
                                        int course_id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter Course Name");
                                        string Coursename = Console.ReadLine();
                                        Console.WriteLine("Enter Course Duration in Months");
                                        int courseDuration = int.Parse(Console.ReadLine());
                                        Student stu = new InPersonCourse(id, name, date, course_id, Coursename, courseDuration);
                                        if (InPersonCourse.count < 5)
                                        {
                                            students.Add(stu);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Capapcity of Course is Full");
                                        }
                                            break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Enter valid Choice....");
                                        break;
                                    }
                            }



                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Enter the Student Id to Delete");
                            int id = int.Parse(Console.ReadLine());
                            bool foundId = false;

                            foreach (Student student in students)
                            {
                                if(student.Id == id)
                                {
                                    students.Remove(student);
                                    foundId = true;
                                }

                            }
                            if (foundId)
                            {
                                Console.WriteLine("Student Deleted Succesfully");
                            }
                            else
                            {
                                Console.WriteLine("Cannot find the Student Please Enter valid Id");
                            }
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Student Id to Display");
                            int id = int.Parse(Console.ReadLine());
                            bool foundId = false;

                            foreach (Student student in students)
                            {
                                if (student.Id == id)
                                {
                                    Console.WriteLine($"Student: {student.Name}\nId:  {student.Id}\nDOB:  {student.DOB}\nCourseName:  {student.GetCourseDetails()}");
                                }

                            }
                            if (foundId)
                            {
                                
                            }
                            else
                            {
                                Console.WriteLine("Cannot find the Student Please Enter valid Id");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the Student Id to Update");
                            int id = int.Parse(Console.ReadLine());
                            bool foundId = false;

                            foreach (Student student in students)
                            {
                                if (student.Id == id)
                                {
                                    Console.WriteLine("Enter the New name:");
                                    student.Name = Console.ReadLine();
                                    Console.WriteLine("Enter the new DOB");
                                    student.DOB = DateOnly.Parse(Console.ReadLine());
                                    Console.WriteLine($"Student: {student.Name}\nId:  {student.Id}\nDOB:  {student.DOB}");
                                }

                            }
                            if (foundId)
                            {
                                Console.WriteLine("Student Updated Succesfully");
                            }
                            else
                            {
                                Console.WriteLine("Cannot find the Student Please Enter valid Id");
                            }
                            break;
                        }

                 }

            

            }
            
        }
    }
}
