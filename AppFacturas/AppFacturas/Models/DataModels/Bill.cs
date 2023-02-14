namespace AppFacturas.Models.DataModels
{
    public class Bill: BaseEntity
    {
        public ICollection<LineBill> LineBills { get; set; } = new List<LineBill>();

        public LineBill LineBill { get; set; } = new LineBill();
    }
}
