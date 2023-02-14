using System.ComponentModel.DataAnnotations;

namespace AppFacturas.Models.DataModels
{
    public class Enterprise: BaseEntity
    {

        [Required, StringLength(50)]
        public string EnterpriseName { get; set; } = string.Empty;

        public ICollection<Bill> Bills { get; set; } = new List<Bill>();

        public Bill Bill { get; set; } = new Bill();
    }
}
