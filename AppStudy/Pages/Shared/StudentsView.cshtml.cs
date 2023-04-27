using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppStudy.Pages.Model;
namespace AppStudy.Pages.Shared
{
    public class StudentsViewModel : PageModel
    {
        //public List<Student> lstStudents = new List<Student>();
        public Student objStud { get; set; } 
        public StudentsViewModel()
        {
            objStud = new Student();
            objStud.StudId = 1;
            objStud.StudentName = "nilesh";
            objStud.Marks = 90;

            //Student obj = new Student();
            //obj.StudId = 1;
            //obj.StudentName = "nilesh";
            //obj.Marks = 90;

            //lstStudents.Add(obj);

        }

        public void OnGet()
        {
            
        }
    }
}
