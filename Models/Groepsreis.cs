using System.ComponentModel.DataAnnotations;

namespace Api.Ziekenfonds.Models
{
    public class Groepsreis
    {
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "GroepsreisId is verplicht!")]
        public int GroepsreisId { get; set; }

        [Required(ErrorMessage = "Begindatum is verplicht!")]
        [DataType(DataType.Date)]
        public DateTime Begindatum { get; set; }

        [Required(ErrorMessage = "Einddatum is verplicht!")]
        [DataType(DataType.Date)]
        public DateTime Einddatum { get; set; }

        [Required(ErrorMessage = "Prijs is verplicht!")]
        public float Prijs { get; set; }
    }
}