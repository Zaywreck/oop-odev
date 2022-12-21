//  ADO.NET

// CONNECTION

using System.Data.SqlClient;

string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=localdb;Integrated Security=True";
var conn = new SqlConnection(connectionString);
conn.Open();
string firstname = "Mert";
string lastname = "gulle";

var cmd = new SqlCommand($"INSERT INTO Employee(FirstName, LastName) VALUES (@FirstName, @LastName)", conn);
cmd.Parameters.AddWithValue("FirstName", firstname);
cmd.Parameters.AddWithValue("LastName", lastname);
var result = cmd.ExecuteNonQuery();

Console.WriteLine(result);

conn.Close();
conn.Dispose();
cmd.Dispose();