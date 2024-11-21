using System.ComponentModel.DataAnnotations;

namespace ZiekenFonds.API.Models
{
    public class OpleidingPersoon
    {
        [Required(ErrorMessage = "Id is verplicht!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "OpleidingId is verplicht!")]
        public int OpleidingId { get; set; }

        [Required(ErrorMessage = "PersoonId is verplicht!")]
        public int PersoonId { get; set; }
    }
}