using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyGrades.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public EmailAddressAttribute EmailAddress { get; set; }
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Senha")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Password { get; set; }

    }
}
