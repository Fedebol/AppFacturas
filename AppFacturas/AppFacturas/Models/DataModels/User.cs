using System.ComponentModel.DataAnnotations;

namespace AppFacturas.Models.DataModels
{
    public enum Rol
    {
        User,
        Admin
    }

    public class User: BaseEntity
    {
        [Required, StringLength(50)]
        public string UserName { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public Rol Rol { get; set; } = Rol.User;
        [Required]
        public ICollection<Enterprise> Enterprises { get; set; } = new List<Enterprise>();
        [Required]
        public ICollection<Bill> Bills { get; set; } = new List<Bill>();
        [Required]
        public ICollection<User> Users { get; set; } = new List<User>();
        [Required]
        public Enterprise Enterprise { get; set; } = new Enterprise();
        [Required]
        public Bill Bill { get; set; } = new Bill();
        [Required]
        public LineBill LineBill { get; set; } = new LineBill();
        
    }
}
