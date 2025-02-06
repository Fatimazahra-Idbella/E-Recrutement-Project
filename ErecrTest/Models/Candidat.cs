using System.ComponentModel.DataAnnotations;

namespace ErecrTest.Models
{
    public class Candidat
    {
        [Key]
        public int CandidatId { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Titre { get; set; }
        [Required]
        public string Diplome { get; set; }
        [Required]
        public int AnneeExperience { get; set; }
        [Required]
        public string CV { get; set; }
        public List<Candidature> Candidatures { get; set; }
    }
}
