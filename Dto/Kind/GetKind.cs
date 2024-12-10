namespace ZiekenFonds.API.Dto.Kind
{
    public class GetKind
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string? Allergieën { get; set; }
        public string? Medicatie { get; set; }

        // Extra velden voor persoon als ouder
        public string OuderNaam { get; set; }
        public string OuderVoornaam { get; set; }
    }
}
