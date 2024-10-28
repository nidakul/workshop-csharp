Console.WriteLine();

#region
//void Sum()
//{
//    int x = 1, y = 2;
//    int z = x + y;
//    Console.WriteLine(z);
//}
//Sum();
#endregion

#region Geriye değer döndürmeyen string parametreli metotlar
//void WriteMethod(string customerName)
//{
//    Console.WriteLine(customerName);
//}
//WriteMethod("Nida");

//void CustomerCard(string name, string surname)
//{
//    Console.WriteLine("Müşteri: " + name + " "+ surname);
//}
//CustomerCard("Nida", "Kul");
//CustomerCard("Zehra", "Kul");
//CustomerCard("Ela", "Kul");
#endregion

#region Geriye değer döndürmeyen int parametreli metotlar
//void Sum(int number1, int number2, int number3)
//{
//    int result = number1 + number2 + number3;
//    Console.WriteLine(result);
//}
//Sum(3, 4, 6);
#endregion

#region Geriye değer döndüren metotlar
//string CustomerName()
//{
//    return "Buse Yıldız";
//}
//CustomerName();

//string StudentCard()
//{
//    string name = "Ali";
//    string surname = "Kaya";
//    return name + " " + surname;
//}
//Console.WriteLine(StudentCard());
#endregion

#region Geriye değer döndüren string parametreli metotlar
//using System.Globalization;

//string CountryCard(string countryName, string capital, string flagColor)
//{
//    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
//    return cardInfo;
//}
//string x, y, z; 
//Console.Write("Ülke Adını Giriniz: ");
//x = Console.ReadLine();

//Console.Write("Başkenti Giriniz: ");
//y = Console.ReadLine();

//Console.Write("Bayrak Rengini Giriniz: ");
//z = Console.ReadLine();

//Console.WriteLine(CountryCard(x, y, z));
//Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
#endregion

#region Geriye değer döndüren int parametreli metotlar
//int Sum(int number1, int number2)
//{
//    int result = number1 + number2;
//    return result;
//}
//Console.WriteLine(Sum(45,76));
//Console.WriteLine(Sum(15,89));
#endregion

#region Exam Example
//string ExamResult(string student, int exam1, int exam2, int exam3)
//{
//    int result = (exam1 + exam2 + exam3) / 3;
//    if (result <= 50) 
//    {
//        return student +  " isimli öğrenci sınavı geçti" + " Ortalama: " + result;
//    }
//    else
//    {
//        return student + " isimli öğrenci başarısız oldu" + " Ortalama: " + result;
//    }
//}

//Console.WriteLine(ExamResult("Ali",25,41,55));
//Console.WriteLine(ExamResult("Ayşe",36,88,33));

#endregion
