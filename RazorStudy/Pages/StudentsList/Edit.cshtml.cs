using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudy.Model;

namespace RazorStudy.Pages.StudentsList
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Student objStudent { get; set; }
        private ApplicationDBContext db;
        public EditModel(ApplicationDBContext _db)
        {
            this.db = _db;

        }
        public void OnGet(int StudID)
        {
            objStudent = db.Students.FirstOrDefault(x => x.ID == StudID);
        }

        public IActionResult OnPost()
        {
            var temp=db.Students.Find(objStudent.ID);
            temp.StudentName = objStudent.StudentName;
            temp.Marks = objStudent.Marks;
            db.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
