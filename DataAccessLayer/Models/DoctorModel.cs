using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Models
{
    public class DoctorModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public int Years_of_Exp { get; set; }
        public string Gender { get; set; }
    }
}