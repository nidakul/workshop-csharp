
//Ado.Net:C#'da Sql yapılarını kullanabilmemize olanak sağlayan teknolojidir.
using System.Data;
using Microsoft.Data.SqlClient;

Console.WriteLine("****** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ******");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("----------------------------");
Console.WriteLine("1-Kategoriler");
Console.WriteLine("1-Ürünler");
Console.WriteLine("1-Siparişler");
Console.WriteLine("1-Çıkış Yap");
Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
string tableNumber = Console.ReadLine();
Console.WriteLine("----------------------------");

SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
SqlCommand command = new SqlCommand("Select * From Categories", sqlConnection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
DataTable dataTable = new DataTable();
sqlDataAdapter.Fill(dataTable);
sqlConnection.Close();

foreach (DataRow row in dataTable.Rows)
{
    foreach (var item in row.ItemArray)
    {
        Console.WriteLine(item.ToString());
    }
    Console.WriteLine();
} 

