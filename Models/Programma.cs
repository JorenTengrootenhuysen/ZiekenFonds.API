using System.ComponentModel.DataAnnotations;

namespace Api.Ziekenfonds.Models
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