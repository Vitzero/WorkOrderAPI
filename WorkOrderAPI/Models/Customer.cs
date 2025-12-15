using System.ComponentModel.DataAnnotations;

namespace WorkOrderAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Telefone' é obrigatório.")]
        public string PhoneNumber { get; set; }

        [Required]
        public virtual Address Address { get; set; }


    }
}
