using System.ComponentModel.DataAnnotations;

namespace Lab_01.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PlayerName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
