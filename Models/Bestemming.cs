using System.ComponentModel.DataAnnotations;

namespace Api.Ziekenfonds.Models
{
    public class Bestemming
    {
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Naam is verplicht!")]
        [StringLength(75, ErrorMessage = "Naam mag maximaal 75 karakters zijn!")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Beschrijving is verplicht!")]
        [StringLength(200, ErrorMessage = "Naam mag maximaal 200 karakters zijn!")]
        public string Beschrijving { get; set; }

        [Required(ErrorMessage = "Mininum leeftijd is verplicht!")]
        [Range(6, 21, ErrorMessage = "Leeftijd mag niet onder 6!")]
        public int MinLeeftijd { get; set; }

        [Required(ErrorMessage = "Maximum leeftijd is verplicht!")]
        [Range(6, 21, ErrorMessage = "Leeftijd mag niet Boven 21!")]
        public int MaxLeeftijd { get; set; }
    }
}