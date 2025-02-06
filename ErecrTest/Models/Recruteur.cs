using System.ComponentModel.DataAnnotations;

namespace ErecrTest.Models
{
    public class Recruteur
    {
        [Key]
        public int RecruteurId { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        public string Email { get; set; }

        public ICollection<Offre> Offres { get; set; }
    }
}
