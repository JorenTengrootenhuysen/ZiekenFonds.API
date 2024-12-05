namespace ZiekenFonds.API.Dto.Kind
{
    public class CreateKind
    {
        public string PersoonId { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Allergieën { get; set; }
        public string Medicatie { get; set; }
    }
}
