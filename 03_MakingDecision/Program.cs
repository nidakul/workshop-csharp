#region If Else
//Console.WriteLine("Lütfen şifreyi giriniz: ");
//string password;
//password = Console.ReadLine();
//if(password == "abcd")
//    Console.WriteLine("Şifre Doğru");
//else
//    Console.WriteLine("Şifre Yanlış");

//string capital, country;
//Console.WriteLine("Başkenti Giriniz: ");
//capital = Console.ReadLine();

//Console.WriteLine("Ülkeyi Giriniz: ");
//country = Console.ReadLine();

//if(capital == "ankara" & country == "türkiye")
//    Console.Write("veriler doğrulandı");
//else
//    Console.Write("hatalı bilgi");

//int number;
//Console.Write("Sayıyı Giriniz: ");
//number = int.Parse(Console.ReadLine()); 
//if(number==5)
//    Console.WriteLine("Sayı doğru");
//else
//    Console.WriteLine("Sayı hatalı");

//int exam1, exam2, exam3, avarage;
//string result ="Hata";

//Console.Write("Sınav 1: ");
//exam1 = int.Parse(Console.ReadLine());
//Console.Write("Sınav 2: ");
//exam2 = int.Parse(Console.ReadLine());
//Console.Write("Sınav 3: ");
//exam3 = int.Parse(Console.ReadLine());

//avarage = (exam1 + exam2 + exam3) / 3;
//Console.WriteLine("Sınavların ortalaması: " + avarage);

//if (avarage > 0 & avarage <= 50)
//    result = "Sonuç vasat"; 
//if(avarage>50 & avarage<=70)
//    result = "Sonuç orta";
//if (avarage > 70 & avarage <= 84)
//    result = "Sonuç iyi";
//if (avarage >84)
//    result = "Sonuç çok iyi";
//Console.WriteLine(result);

//Console.Write("Lütfen şehir girişi yapınız: ");
//string city = Console.ReadLine();

//if(city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")
//    Console.WriteLine("Şehir mevcut");
//else
//    Console.WriteLine("Şehir mevcut değil");

//Console.Write("Lütfen kullanıcı adını giriniz: ");
//string username = Console.ReadLine();
//if(username != "admin")
//    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
//else
//    Console.WriteLine("Hoş geldiniz");
#endregion

#region Mod
//int number = 26;
//int result = number % 5;
//Console.WriteLine(result);

//Console.Write("Lütfen 1. sayıyı giriniz: ");
//int number = int.Parse(Console.ReadLine());

//Console.Write("Lütfen 2. sayıyı giriniz: ");
//int number2 = int.Parse(Console.ReadLine());

//int result = number % number2;
//Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

//Console.Write("Lütfen sayıyı giriniz: ");
//int number = int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//    Console.WriteLine("Sayı çifttir.");
//else
//    Console.WriteLine("Sayı tektir.");
#endregion

#region char if-else
//char team;
//Console.Write("Lütfen takım sembolünü giriniz: ");
//team = char.Parse(Console.ReadLine());

//if(team == 'g' | team=='G')
//    Console.WriteLine("Galatasaray");
//if (team == 'f' | team == 'F')
//    Console.WriteLine("Fenerbahçe");
//if (team == 'b' | team == 'B')
//    Console.WriteLine("Beşiktaş");
#endregion


#region example
//Console.WriteLine("****** C# Eğitim Restoran ******");
//Console.WriteLine();
//Console.WriteLine("--------------------------------");
//Console.WriteLine("1-Ana Yemekler");
//Console.WriteLine("2-Çorbalar");
//Console.WriteLine("3-Pizzalar");
//Console.WriteLine("4-İçecekler");
//Console.WriteLine("5-Tatlılar");
//Console.WriteLine("--------------------------------");
//Console.WriteLine();

//Console.Write("Detayını görmek istediğiniz menü seçimi: ");
//string menuItem = Console.ReadLine();

//if (menuItem == "1")
//{
//    Console.WriteLine();
//    Console.WriteLine("----------Ana Yemekler----------");
//    Console.WriteLine();
//    Console.WriteLine("1-Köri Soslu Tavuk");
//    Console.WriteLine("2-Kızartma Tabağı");
//    Console.WriteLine("3-Fasulye Pilav");
//    Console.WriteLine("4-Fırında Somon");
//    Console.WriteLine("5-Patlıcan Musakka");
//    Console.WriteLine();
//    Console.WriteLine("----------Ana Yemekler----------");
//}
//if (menuItem == "2")
//{
//    Console.WriteLine();
//    Console.WriteLine("----------Çorbalar----------");
//    Console.WriteLine();
//    Console.WriteLine("1-Mercimek Çorbası");
//    Console.WriteLine("2-Ezogelin Çorbası");
//    Console.WriteLine();
//    Console.WriteLine("----------Çorbalar----------");
//}
//if (menuItem == "3")
//{
//    Console.WriteLine();
//    Console.WriteLine("----------Pizzalar----------");
//    Console.WriteLine();
//    Console.WriteLine("1-Akdeniz Pizza");
//    Console.WriteLine("2-Margaritha");
//    Console.WriteLine("2-Tavuklu Pizza");
//    Console.WriteLine();
//    Console.WriteLine("----------Pizzalar----------");
//}
//if (menuItem == "4")
//{
//    Console.WriteLine();
//    Console.WriteLine("----------İçecekler----------");
//    Console.WriteLine();
//    Console.WriteLine("1-Kola");
//    Console.WriteLine("2-Ayran");
//    Console.WriteLine("2-Su");
//    Console.WriteLine();
//    Console.WriteLine("----------İçecekler----------");
//}
//if (menuItem == "5")
//{
//    Console.WriteLine();
//    Console.WriteLine("----------Tatlılar----------");
//    Console.WriteLine();
//    Console.WriteLine("1-Triliçe");
//    Console.WriteLine("2-Kazandibi");
//    Console.WriteLine("2-Sütlaç");
//    Console.WriteLine();
//    Console.WriteLine("----------Tatlılar----------");
//}
#endregion