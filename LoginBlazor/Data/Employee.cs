using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginBlazor.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
