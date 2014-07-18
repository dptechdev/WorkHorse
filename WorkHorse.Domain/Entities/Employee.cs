using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHorse.Domain
{
    
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public Department Department { get; set; }
    }
}
