using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Data.Shopping;

[Table("CustomerInfo")]
public class Customer
{
    [Column("UserName"), Required]
    public string Id { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please provide password")]
    public string Password { get; set; } = string.Empty;

    public List<Order> Orders { get; set; }
}
