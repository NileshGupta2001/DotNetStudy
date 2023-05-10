using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorStudy.Model;

namespace RazorStudy.Pages.StudentsList
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Student objStudent { get; set; }
        private ApplicationDBContext db;
        public void OnGet()
        {
        }
        public CreateModel(ApplicationDBContext _db)
        {
            this.db = _db;
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(objStudent);
                db.SaveChanges();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
            
            
        }
    }
}
