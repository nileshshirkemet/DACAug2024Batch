using System.Data;
using Microsoft.Data.SqlClient;

string customerId = args[0].ToUpper();
int productNo = int.Parse(args[1]);
int quantity = int.Parse(args[2]);
using var connection = new SqlConnection("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False");
connection.Open();
using var command = connection.CreateCommand();
command.CommandText = "PlaceOrder";
command.CommandType = CommandType.StoredProcedure;
command.Parameters.AddWithValue("@Customer", customerId);
command.Parameters.AddWithValue("@Product", productNo);
command.Parameters.AddWithValue("@Quantity", quantity);
var orderIdParam = command.Parameters.Add("@orderId", SqlDbType.Int);
orderIdParam.Direction = ParameterDirection.Output;
try
{
    command.ExecuteNonQuery();
    Console.WriteLine("New Order Number: {0}", orderIdParam.Value);
}
catch(Exception ex)
{
    Console.WriteLine("Order Failed: {0}", ex.Message);
}