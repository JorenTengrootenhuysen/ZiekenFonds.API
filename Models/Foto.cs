using System.ComponentModel.DataAnnotations;

namespace Api.Ziekenfonds.Models
{
    public class Foto
    {
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Naam is verplicht!")]
        [StringLength(50, ErrorMessage = "Naam mag maximaal 50 karakters zijn!")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "BestemmingId is verplicht!")]
        public int BestemmingId { get; set; }
    }
}