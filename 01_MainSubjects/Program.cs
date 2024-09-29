//Console.WriteLine("Hello");
//Console.Write("Hello World");

#region
//Console.WriteLine("****** Yemek Kategorileri ******");
//Console.WriteLine();
//Console.WriteLine("1-Çorbalar");
//Console.WriteLine("2-Ana Yemekler");
//Console.WriteLine("3-Soğuk Başlangıçlar");
//Console.WriteLine("4-Salatalar");
//Console.WriteLine("5-Tatlılar");
//Console.WriteLine("6-İçecekler");
//Console.WriteLine();
//Console.WriteLine("****** Yemek Kategorileri ******");
#endregion

#region String Variable
//string name = "Nida";
//Console.WriteLine(name);

//string customerName = "Nida";
//string customerSurname = "Kul";
//string customerPhone = "124343432432" ;
//string customerEmail= "nida@gmail.com", district="Battalgazi", city = "Malatya";

//Console.WriteLine("****** Rezervasyon Kartı ******");
//Console.WriteLine();
//Console.WriteLine("-----------------------------------------");
//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
//Console.WriteLine("İletişim: " + customerPhone);
//Console.WriteLine("Email Adresi: " + customerEmail);
//Console.WriteLine("Adres: " + district + "/" + city);
//Console.WriteLine("-----------------------------------------");

//Console.WriteLine();

//customerName = "Ela";
//customerSurname = "Kul";
//customerPhone = "124343432432";
//customerEmail = "ela@gmail.com";
//district = "Battalgazi";
//city = "Malatya";

//Console.WriteLine("-----------------------------------------");
//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
//Console.WriteLine("İletişim: " + customerPhone);
//Console.WriteLine("Email Adresi: " + customerEmail);
//Console.WriteLine("Adres: " + district + "/" + city);
//Console.WriteLine("-----------------------------------------");

#endregion

#region Int Variable
//int number = 24;
//Console.WriteLine(number);

int hamburgerPrice = 300;
int cokePrice = 35;
int waterPrice = 10;
int friesPrice = 50;
int pizzaPrice = 250;
int lemonadePrice = 30;

Console.WriteLine("***** Restoran Menü Fiyatı *****");
Console.WriteLine();
Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL");
Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
Console.WriteLine();
Console.WriteLine("***** Restoran Menü Fiyatı *****");
Console.WriteLine();

int hamburgerCount = 3; 
int cokeCount = 3;
int waterCount = 3;
int friesCount = 1;
int pizzaCount = 0;
int lemonadeCount = 0;

int totalPrice = 0;

totalPrice = (hamburgerPrice * hamburgerCount) + (cokePrice * cokeCount) + (waterPrice * waterCount) + (friesPrice * friesCount);
Console.WriteLine("--------------------");
Console.WriteLine("Toplam Tutar: " + totalPrice + " TL"); 

#endregion