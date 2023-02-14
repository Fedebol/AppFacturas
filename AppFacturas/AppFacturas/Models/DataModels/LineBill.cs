using System.ComponentModel.DataAnnotations;

namespace AppFacturas.Models.DataModels
{
    public class LineBill: BaseEntity
    {
        [Required]
        public int CodeProduct { get; set; }
        [Required]
        public string NameProduct { get; set; } = string.Empty;
        [Required]
        public int ProductUnits { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
