namespace ErecrTest.Models;
using System.ComponentModel.DataAnnotations.Schema;
    public class Offre
    {
        public int Id { get; set; }
        public int RecruteurId { get; set; }
        public string TypeContrat { get; set; }                                                                                                                                                                                     
        public string Secteur { get; set; }
        public string Profil { get; set; }
        public string Poste { get; set; }
        public decimal Remuneration { get; set; }
        public List<Candidature> Candidatures { get; set; }
        [ForeignKey("RecruteurId")] 
        public Recruteur Recruteur { get; set; }
    }

