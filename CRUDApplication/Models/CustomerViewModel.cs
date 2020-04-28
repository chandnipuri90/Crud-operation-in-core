using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class CustomerViewModel
    {
        public long Id { get; set; }

        [Display(Name = "First Name")]

        public string FirstName { get; set; }

        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [Display(Name = "Mobile No")]

        public string MobileNo { get; set; }
    }
}
