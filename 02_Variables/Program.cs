#region Double
////double number = 4.85;
////Console.WriteLine(number);

//Console.WriteLine("****** Fiyat Listesi ******");
//double applePrice = 14.85, orangePrice= 20.95, strawberryPrice=45, potatoPrice=9.74, tomatoPrice=6.88;

////₺ for mac without any problems
//Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
//Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
//Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " ₺");
//Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " ₺");
//Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " ₺");

//Console.WriteLine();

//double appleGram = 1.245, orangeGram=2.650, strawberryGram=0.750, potatoGram=4.859, tomatoGram=3.745;

//double appleTotalPrice = appleGram * applePrice;
//double orangeTotalPrice = orangeGram * orangePrice;
//double strawberryTotalPrice = strawberryGram * strawberryPrice;
//double potatoTotalPrice = potatoGram * potatoPrice;
//double tomatoTotalPrice = tomatoGram * tomatoPrice;

//Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
//Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
//Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
//Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
//Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
//Console.WriteLine();

//double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
//Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " ₺");
#endregion

#region Char
//char symbol = 'a';
//Console.WriteLine(symbol);
#endregion

#region Data Entries From Keyboard String
//Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
//Console.WriteLine();

//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
//Console.Write("Yolcu Adı: ");
//passengerName = Console.ReadLine();

//Console.Write("Yolcu Soyadı: ");
//passengerSurname = Console.ReadLine();

//Console.Write("İlçe Bigisi: ");
//passengerDistrict = Console.ReadLine();

//Console.Write("Şehir Bigisi: ");
//passengerCity = Console.ReadLine();

//Console.Write("Yolcu Yaş: ");
//passengerAge = Console.ReadLine();

//Console.Write("Yolcu TC Kimlik No: ");
//passengerIdentityNumber = Console.ReadLine();

//Console.WriteLine();
//Console.WriteLine("------------------------");
//Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity
//    + " " + passengerAge);

#endregion

#region Data Entries From Keyboard Int
//int shoesPrice = 1000, computerPrice = 20000, chairPrice = 5000, tvPrice = 12000;
//int shoesCount, computerCount, chairCount, tvCount;

//Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
//shoesCount = int.Parse(Console.ReadLine());

//Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
//computerCount = int.Parse(Console.ReadLine());

//Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
//chairCount = int.Parse(Console.ReadLine());

//Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
//tvCount = int.Parse(Console.ReadLine());

//int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
//Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);
#endregion

#region Data Entries From Keyboard Double
//double exam1, exam2, exam3, result;

//Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
//exam1 = double.Parse(Console.ReadLine());

//Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
//exam2 = double.Parse(Console.ReadLine());

//Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
//exam3 = double.Parse(Console.ReadLine());

//result = (exam1 + exam2 + exam3) / 3;
//Console.WriteLine();
//Console.WriteLine("Sınav Ortalamanız: " + result);
#endregion

#region Data Entries From Keyboard Char
char gender;
Console.WriteLine("Lütfen cinsiyetinizi seçiniz: ");
gender = char.Parse(Console.ReadLine());

Console.WriteLine("Seçtiğiniz cinsiyet: " + gender); 

#endregion
