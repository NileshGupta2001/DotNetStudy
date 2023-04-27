using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStudy
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudName { get; set; }
        public int Marks { get; set; }
        public List<Course> EnrolledCourses { get; set; }
        public Student()
        {
            EnrolledCourses = new List<Course>();
        }
    }
}
