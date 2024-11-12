using System.ComponentModel.DataAnnotations;

namespace MyGrades.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public EmailAddressAttribute EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
