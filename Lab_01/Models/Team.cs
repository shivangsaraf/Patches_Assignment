using System.ComponentModel.DataAnnotations;

namespace Lab_01.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EstablishedDate { get; set; }
    }
}
