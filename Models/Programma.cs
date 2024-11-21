using System.ComponentModel.DataAnnotations;

namespace ZiekenFonds.API.Models
{
    public class Programma
    {
        [Key]
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "ActiviteitId is verplicht!")]
        public int ActiviteitId { get; set; }
    }
}