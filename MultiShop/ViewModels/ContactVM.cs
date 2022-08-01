using System.ComponentModel.DataAnnotations;

namespace MultiShop.ViewModels
{
    public class ContactVM
    {
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
