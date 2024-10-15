#region Foreach
//string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
//foreach (string c in cities)
//{
//    Console.WriteLine(c);
//}

//int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
//foreach (int number in numbers)
//{
//    if(number % 2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}

//int total = 0;
//foreach (int number in numbers)
//{
//    total += number;
//}
//Console.WriteLine(total);

//List<int> numbers = new List<int>()
//{
//    1,2,3,4,5,6
//};
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//string word = "Merhaba";
//foreach(char w in word)
//{
//    Console.WriteLine(w);
//}
#endregion

#region Örnek Sınav Sistemi Uygulaması
Console.Write("****** C# Eğitim Kampı Sınav Uygulaması ******");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("-----------------");
Console.Write("Sınıfınızda kaç öğrenci var: ");
int studentCount = int.Parse(Console.ReadLine());
Console.WriteLine("-----------------");

string[] studentNames = new string[studentCount];
double[] studentExamAvg = new double[studentCount];

for (int i = 0; i < studentCount; i++)
{
    Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
    studentNames[i] = Console.ReadLine();

    double totalExamResult = 0;

    //her öğrenci için 3 sınav notu girişi
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
        double value = double.Parse(Console.ReadLine());
        totalExamResult += value;
    }
    Console.WriteLine();
    studentExamAvg[i] = totalExamResult / 3;
}

for (int i = 0; i < studentCount; i++)
{
    Console.WriteLine("-------------------------");

    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

    if (studentExamAvg[i] >= 50)
    {
        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti");
    }
    else
    {
        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");

    }
    Console.WriteLine("-------------------------");
}


#endregion