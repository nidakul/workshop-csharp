#region Basic Array Exp
//string[] colors = new string[4];
//colors[0] = "Kırmızı";
//colors[1] = "Sarı";
//colors[2] = "Beyaz";
//colors[3] = "Mavi";
//Console.WriteLine(colors[2]);

//string[] cities = new string[5];
//cities[0] = "Milano";
//cities[1] = "Budapeşte";
//cities[2] = "Lyon";
//cities[3] = "Kahire";
//cities[4] = "Üsküp";
//Console.WriteLine(cities[5]); //error

//int[] numbers = new int[10];
//numbers[0] = 50;
//numbers[1] = 48;
//numbers[2] = 698;
//numbers[3] = 24;
//numbers[7] = 748;
//Console.WriteLine(numbers[5]); //0

//string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
//Console.WriteLine(cities[2]);
#endregion

#region Array With Loops/If-Else
//string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
//for (int i = 0; i < colors.Length; i++)
//{
//    Console.WriteLine(colors[i]);
//}

//int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 3 == 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
//for (int i = 0; i < symbols.Length; i++)
//{
//    Console.WriteLine(symbols[i]);
//}
#endregion

#region Find Max Number
//int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
//first way
//int maxNum = myArray[0];
//for (int i = 1; i < myArray.Length; i++)
//{
//    if(maxNum < myArray[i])
//    {
//        maxNum = myArray[i];
//    }
//}
//Console.WriteLine(maxNum);

//second way
//int maxNum = myArray.Max();
//Console.WriteLine(maxNum);
#endregion

#region Array Methods
//string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
//Console.WriteLine(persons.Length);

//int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
//Array.Sort(numbers);
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
//Array.Reverse(numbers);
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
//int index = Array.IndexOf(customers, "Merve");
//Console.WriteLine(index);

//int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
//Console.WriteLine("En büyük eleman: " + numbers.Max() + " En küçük eleman: " + numbers.Min());
#endregion