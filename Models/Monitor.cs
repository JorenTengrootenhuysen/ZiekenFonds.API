using System.ComponentModel.DataAnnotations;

namespace ZiekenFonds.API.Models
{
    public class Monitor
    {
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "PersoonId is verplicht!")]
        public string PersoonId { get; set; }
        [Required(ErrorMessage = "GroepsreisId is verplicht!")]
        public int GroepsreisId { get; set; }

        public bool IsHoofMonitor { get; set; }
    }
}
