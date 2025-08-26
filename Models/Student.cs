using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentRegistry.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,ErrorMessage ="Name can't be longer than 50 characters")]
        [DisplayName("Name")]
        public string name { get; set; }

        
        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required")]
        public int age { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Please enter a valid email ")]
        [DisplayName("Email")]
        public string email { get; set; }


        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime dateOfBirth { get; set; }
    }
}
