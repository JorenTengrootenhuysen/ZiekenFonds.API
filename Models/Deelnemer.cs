using System.ComponentModel.DataAnnotations;

namespace ZiekenFonds.API.Models
{
    public class Deelnemer
    {
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "KindId is verplicht!")]
        public int KindId { get; set; }

        [Required(ErrorMessage = "GroepsreisDetailsId is verplicht!")]
        public int GroepsreisDetailsId { get; set; }

        public string Opmerking { get; set; }

        public int ReviewScore { get; set; }

        public string Review { get; set; }
    }
}