using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudy.Model;

namespace RazorStudy.Pages.StudentsList
{
    public class IndexModel : PageModel
    {
        public List<Student> lstStudents = new List<Student>();
        //public Student objStud { get; set; }

        private ApplicationDBContext db;
        public IndexModel(ApplicationDBContext _db)
        {

            this.db = _db;
            //objStud = new Student();
            //objStud.ID = 1;
            //objStud.StudentName = "nilesh";
            //objStud.Marks = 90;

            //Student obj = new Student();
            //obj.ID = 1;
            //obj.StudentName = "nilesh";
            //obj.Marks = 90;

            //lstStudents.Add(obj);

            //Student obj2 = new Student();
            //obj2.ID = 2;
            //obj2.StudentName = "ranveer";
            //obj2.Marks = 100;

            //lstStudents.Add(obj2);

            //Student obj3 = new Student();
            //obj3.ID = 3;
            //obj3.StudentName = "Surya";
            //obj3.Marks = 100;

            //lstStudents.Add(obj3);

            //Student obj4 = new Student();
            //obj4.ID = 4;
            //obj4.StudentName = "rahul";
            //obj4.Marks = 100;

            //lstStudents.Add(obj4);



        }
        public void OnGet()
        {
            lstStudents=db.Students.ToList();
        }
    }
}
