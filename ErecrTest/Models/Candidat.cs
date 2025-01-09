namespace ErecrTest.Models
{
    public class Candidat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Titre { get; set; }
        public string Diplome { get; set; }
        public int AnneeExperience { get; set; }
        public string CV { get; set; }
        public List<Candidature> Candidatures { get; set; }
    }
}
