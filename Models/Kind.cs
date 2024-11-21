using System.ComponentModel.DataAnnotations;

namespace ZiekenFonds.API.Models
{
    public class Kind
    {
        [Required(ErrorMessage = "Id is Verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "PersoonId is Verplicht!")]
        public int PersoonId { get; set; }

        [Required(ErrorMessage = "Naam is Verplicht!")]
        [StringLength(50, ErrorMessage = "Naam mag maximaal 50 karakters zijn!")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Voornaam is Verplicht!")]
        [StringLength(50, ErrorMessage = "Voornaam mag maximaal 50 karakters zijn!")]
        public string Voornaam { get; set; }

        [Required(ErrorMessage = "Geboortedatum is Verplicht!")]
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }

        [Required(ErrorMessage = "Allergieën is Verplicht!")]
        [StringLength(200, ErrorMessage = "Naam mag maximaal 200 karakters zijn!")]
        public string Allergieën { get; set; }

        [Required(ErrorMessage = "Medicatie is Verplicht!")]
        [StringLength(200, ErrorMessage = "Naam mag maximaal 200 karakters zijn!")]
        public string Medicatie { get; set; }
    }
}