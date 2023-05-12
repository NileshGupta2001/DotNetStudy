using Microsoft.AspNetCore.Mvc;
using WebAPIStudy.Model;

namespace WebAPIStudy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {

        private List<Doctor> lstDoctor;
        ApplicationDBContext Db;
        
        [HttpGet(Name = "GetDoctor")]
        public List<Doctor> Get()
        {
            lstDoctor = Db.Doctors.ToList(); 
            return lstDoctor;
        }

        public DoctorController(ApplicationDBContext _db)
        {
            lstDoctor = new List<Doctor>();
            //lstDoctor.Add(new Doctor() { ID = 1, Name = "nilesh", Speciality = "Cardiologist" });
            //lstDoctor.Add(new Doctor() { ID = 2, Name = "ranveer", Speciality = "Orthologist" });
            //lstDoctor.Add(new Doctor() { ID = 3, Name = "rahul", Speciality = "Dentist" });
            Db = _db;
        }
    }
}
