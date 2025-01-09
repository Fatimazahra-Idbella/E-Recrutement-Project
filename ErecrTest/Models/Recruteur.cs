namespace ErecrTest.Models
{
    public class Recruteur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public ICollection<Offre> Offres { get; set; }
    }
}
