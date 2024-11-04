using System.Data;
using Microsoft.Data.SqlClient;

Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
Console.WriteLine();

Console.WriteLine("--------------------------------");

#region Kategori Ekleme İşlemi
//Console.WriteLine("Eklemek istediğiniz kategori adı: ");
//string categoryName = Console.ReadLine();

//SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
//sqlConnection.Open();
//SqlCommand command = new SqlCommand("insert into Categories (Name) values (@p1)", sqlConnection);
//command.Parameters.AddWithValue("@p1", categoryName);
//command.ExecuteNonQuery();
//sqlConnection.Close();

//Console.Write("Kategori başarıyla eklendi!");
#endregion

#region Ürün Ekleme İşlemi
//string productName;
//decimal productPrice;
//bool productStatus;

//Console.Write("Ürün adı: ");
//productName = Console.ReadLine();
//Console.Write("Ürün fiyatı: ");
//productPrice = decimal.Parse(Console.ReadLine());

//SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
//sqlConnection.Open();
//SqlCommand command = new SqlCommand("insert into Products (Name, ProductPrice, ProductStatus) values(@name, @productPrice, @productStatus)", sqlConnection);
//command.Parameters.AddWithValue("@name", productName);
//command.Parameters.AddWithValue("@productPrice", productPrice);
//command.Parameters.AddWithValue("@productStatus", true);
//command.ExecuteNonQuery();
//sqlConnection.Close();

//Console.WriteLine("Ürün Eklemesi Başarılı!");
#endregion

#region Ürün Listeleme İşlemi
//SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
//sqlConnection.Open();
//SqlCommand command = new SqlCommand("select * from Products", sqlConnection);
//SqlDataAdapter adapter = new SqlDataAdapter(command);
//DataTable dataTable = new DataTable();
//adapter.Fill(dataTable);

////Önce satıra gidiyor. Sonra alttaki döngü ile o satırın içine giriyor.
//foreach(DataRow row in dataTable.Rows)
//{
//    foreach (var item in row.ItemArray)
//    {
//        Console.Write(item.ToString() + " ");
//    }
//    Console.WriteLine();
//}
//sqlConnection.Close();
#endregion

#region Ürün Silme İşlemi
//Console.WriteLine("Silinecek Ürün Id: ");
//int productId = int.Parse(Console.ReadLine());

//SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
//sqlConnection.Open();

//SqlCommand sqlCommand = new SqlCommand("delete from products where Id = @productId", sqlConnection);
//sqlCommand.Parameters.AddWithValue("@productId", productId);
//sqlCommand.ExecuteNonQuery();

//sqlConnection.Close();

//Console.WriteLine("Silme işlemi yapıldı!");
#endregion

#region Ürün Güncelleme İşlemi
Console.Write("Güncellenecek Ürün Id: ");
int productId = int.Parse(Console.ReadLine());

Console.Write("Güncellenecek Ürün Adı: ");
string productName = Console.ReadLine();

Console.Write("Güncellenecek Ürün Fiyatı: ");
decimal productPrice = decimal.Parse(Console.ReadLine());

SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
sqlConnection.Open();
SqlCommand sqlCommand = new SqlCommand("update products set name=@productName, productPrice=@productPrice where Id=@productId", sqlConnection);
sqlCommand.Parameters.AddWithValue("@productName", productName);
sqlCommand.Parameters.AddWithValue("@productPrice", productPrice);
sqlCommand.Parameters.AddWithValue("@productId", productId);
sqlCommand.ExecuteNonQuery();

sqlConnection.Close();

Console.WriteLine("Güncelleme işlemi başarılı");
#endregion
