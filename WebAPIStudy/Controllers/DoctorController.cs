using Microsoft.AspNetCore.Mvc;
using WebAPIStudy.Model;

namespace WebAPIStudy.Controllers
{
    /*
     * HTTP RESPONSE CODES/STATUS
     * 1xx	Request received and under processing
2xx	Successful
3xx	Redirection, an action must be taken by either user agent (browser) or user
4xx	Invalid Request by the client, might be because of incomplete and invalid data
    5xx	Server Error
     * */
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {

        private List<Doctor> lstDoctor;
        ApplicationDBContext Db;
        
        [HttpGet(Name = "GetDoctor")]
        public IActionResult Get()
        {
            lstDoctor = Db.Doctors.ToList(); 
            return Ok(lstDoctor);
        }

        [HttpPost(Name = "AddDoctor")]
        public IActionResult Add(Doctor doctor)
        {
            
            Db.Doctors.Add(doctor);
            Db.SaveChanges();
            return Ok();
        }

        [HttpPatch(Name = "UpdateDoctor")]
        public IActionResult EditDoctor(Doctor doctor)
        {
            var existingDoctor = Db.Doctors.FirstOrDefault(x => x.ID == doctor.ID);
            if(existingDoctor != null)
            {
                existingDoctor.Name = doctor.Name;
                existingDoctor.Speciality = doctor.Speciality;
                Db.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
           
            
           
        }

        [HttpDelete(Name = "DeleteDoctor")]
        public IActionResult DeleteDoctor(int ID)
        {
            var existingDoctor = Db.Doctors.FirstOrDefault(x => x.ID == ID);
            if (existingDoctor != null)
            {
                Db.Doctors.Remove(existingDoctor);
                Db.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }

            

        }
       
        [HttpGet(Name = "SearchDoctor")]
        public IActionResult SearchDoctor(string valueSearch)
        {
            //var existingDoctor = Db.Doctors.Find(x => x.Name.);
            lstDoctor = Db.Doctors.ToList();
            return Ok(lstDoctor);
        }


        public DoctorController(ApplicationDBContext _db)
        {
            //lstDoctor = new List<Doctor>();
            //lstDoctor.Add(new Doctor() { ID = 1, Name = "nilesh", Speciality = "Cardiologist" });
            //lstDoctor.Add(new Doctor() { ID = 2, Name = "ranveer", Speciality = "Orthologist" });
            //lstDoctor.Add(new Doctor() { ID = 3, Name = "rahul", Speciality = "Dentist" });
            Db = _db;
        }
    }
}
