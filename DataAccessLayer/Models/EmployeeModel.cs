using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAdress { get; set; }

        public string EmployeeContact { get; set; }
         public DateTime DOB { get; set; }

        public string Status { get; set; }

        public string EmployeeDesignation { get; set; }
    }
}
