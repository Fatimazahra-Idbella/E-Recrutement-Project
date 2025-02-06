using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ErecrTest.Models
{
    public class Candidature
    {
        [Key]
        public int CandidatureId { get; set; }
        [ForeignKey("CandidatId")]
        public int CandidatId { get; set; }
        public Candidat Candidat { get; set; }  
        [ForeignKey("OffreId")]
        public int OffreId { get; set; }
        public Offre Offre { get; set; }
        public DateTime DatePostulation { get; set; }
        public string State { get; set; } = "Pending";
        
    }
}
