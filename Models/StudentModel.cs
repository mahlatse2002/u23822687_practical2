using System.ComponentModel.DataAnnotations;

namespace Practical2.Models
{
    public class StudentModel
    {



        [Display(Name = "first NAME")]
        public string FirstName { get; set; }

        [Display(Name = "last NAME")]
        public string LastName { get; set; }


        [Display(Name = "student number")]
        public string StudentNumber { get; set; }

        [Display(Name = "email")]
        public string Email { get; set; }

        
        
        

    }
}


