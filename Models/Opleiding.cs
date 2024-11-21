using System.ComponentModel.DataAnnotations;

namespace ZiekenFonds.API.Models
{
    public class Opleiding
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Beschrijving is verplicht!")]
        [StringLength(100, ErrorMessage = "Beschrijving mag maximaal 100 karakters lang zijn!")]
        public string Beschrijving { get; set; }

        [Required(ErrorMessage = "Begindatum is verplicht!")]
        [DataType(DataType.Date)]
        public DateTime Begindatum { get; set; }

        [Required(ErrorMessage = "Einddatum is verplicht!")]
        [DataType(DataType.Date)]
        public DateTime Einddatum { get; set; }

        [Required(ErrorMessage = "Aantalplaatsen is verplicht!")]

        public int AantalPlaatsen { get; set; }

        public int OpleidingVereist {  get; set; }
    }
}
