using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Data;

[Table("CustomerInfo")]
public class Customer
{
    [Column("UserName")]
    public string Id { get; set; }

    public decimal Credit { get; set; }

    public List<Order> Orders { get; set; }
}
