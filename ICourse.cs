using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_University_Course_Enrollment
{
    internal interface ICourse
    {
        int CourseId { get; set; }
        string CourseName { get; set; }
        int CourseDuration { get; set; }

    }
}
