// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region ArrayList
using System.Collections;

//// go to definition yapabilirsin (birçok method var incelersin)
//// ArrayList reference type veri tipi
//ArrayList days = new ArrayList();
//days.Add("Monday");
//days.Add("Tuesday");
//days.Add("Wednesday");
//days.Add("Thursday");
//days.Add("Friday");
//days.Add("Saturday");
//days.Add("Sunday");
//// Add bizden object bekler bu sebeple herhangi bir veri tipinde değer gönderebilirim
////int[] arr = new int[] { 1, 2, 3, 4, 5 }; 
////days.AddRange(arr); // days collections 12 elemanlı olur 

//Console.WriteLine("----- Element Count -----");
//Console.WriteLine($"Element Count: {days.Count}");
//Console.WriteLine("----- Element Capacity -----");
//Console.WriteLine($"Collection Capacity: {days.Capacity}");

//days.Add("Mon");
//days.Add("Tue");
//days.Add("Wed");
//days.Add("Thu");
//days.Add("Fri");

//Console.WriteLine("----- Element Count -----");
//Console.WriteLine($"Element Count: {days.Count}");
//Console.WriteLine("----- Element Capacity -----");
//Console.WriteLine($"Collection Capacity: {days.Capacity}");

//days.TrimToSize(); // Kapasiteyi eleman sayısına indirgiyor

//Console.WriteLine("----- Element Count -----");
//Console.WriteLine($"Element Count: {days.Count}");
//Console.WriteLine("----- Element Capacity -----");
//Console.WriteLine($"Collection Capacity: {days.Capacity}");

////days.Clear();

////Console.WriteLine("----- Element Count -----");
////Console.WriteLine($"Element Count: {days.Count}");
////Console.WriteLine("----- Element Capacity -----");
////Console.WriteLine($"Collection Capacity: {days.Capacity}");

//// Sort() farklı veri tipleri olması durumunda bir sıralama yapamaz
//// İlerde bunu yapabilmek için bir yol öğreneceğiz
//days.Sort();
//foreach (string item in days)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("----------");
//days.Reverse();
//foreach (string item in days)
//{
//    Console.WriteLine(item);
//}

//bool res1 = days.Contains("Sunday");
//bool res2 = days.Contains("Sun");
//Console.WriteLine(res1);
//Console.WriteLine(res2);

//days.Add("Wed");
//int firstIndex = days.IndexOf("Wed");
//int lastIndex = days.LastIndexOf("Wed");
//Console.WriteLine(firstIndex);
//Console.WriteLine(lastIndex);
//// Bulamazsa -1 döndürür ikisi de

//days.Remove("Wed"); // Karşılaştığı ilk değeri siler
//days.RemoveAt(8); // O indexteki elementi siler. Fazla index girersen boundary, out of range hatası alırsın

//days.Insert(8, "Mamba"); // O indexe ekler. Eski 8'deki element index 9 olur
//days.InsertRange(8, new string[] { "Kobe", "Bryant" }); // İlgili yere ikisini de sırayla insert eder. 8 ve 9'a

//days.RemoveRange(8, 3); // index 8'i ve sonrasındaki 2 elementi daha siler

//string[] strArr = new string[20];
//// days.CopyTo(strArr); 
////days.CopyTo(strArr, 6); // kaçıncı indexten itibaren eklesin
//days.CopyTo(3, strArr, 5, 5); // days'in 3. indexinden itibaren 5 elementini al ve strArr'in 5. indexinden itibaren yaz

//Console.ReadLine();
#endregion

#region Dictionary (Generic)
// key ve value bekler
// go to definition ile inceleyebilirsin
//using System.Collections;

//Dictionary<int, string> cities = new Dictionary<int, string>(); // key & value
//cities.Add(1, "Adana");
//cities.Add(31, "Hatay");
//cities.Add(34, "İstanbul");
//cities.Add(35, "İzmir");
//cities.Add(27, "Gaziantep");
//cities.Add(6, "Ankara");

////cities.Add(31, "Antakya"); // key unique olmalı, hata verir
////cities.Clear(); // deletes elements of the collection

////Console.WriteLine("Number of elements" + cities.Count); // Element sayısını verir. (Bunlarda kapasite yok)

////bool result1 = cities.ContainsKey(31); // true
////bool result2 = cities.ContainsKey(21); // false
////bool result3 = cities.ContainsValue("Hatay"); // true

////Console.WriteLine(result1);
////Console.WriteLine(result2);
////Console.WriteLine(result3);

//Dictionary<int, string>.KeyCollection keys = cities.Keys;
//Dictionary<int, string>.ValueCollection values = cities.Values;
//foreach (int key in keys)
//{
//    //Console.WriteLine($"[{key}]: [{cities[key]}]");
//}

//bool res1 = cities.TryGetValue(31, out string city1);
//bool res2 = cities.TryGetValue(41, out string city2);
////Console.WriteLine($"{res1}: {city1}"); // True: Hatay
////Console.WriteLine($"{res2}: {city2}"); // False:

////cities.Remove(31); // sadece siler
//cities.Remove(31, out string city); // sildiği değeri döndürür
//Console.WriteLine(city); // Hatay döner


//Console.ReadLine();
#endregion

#region HashTable
// go to definition yapabilirsin
// key value
// keys unique olmalı
// Dataya hızlı erişmede ideal ama geniş çaplı datada kaynak tüketimi fazla
//Hashtable playerList = new Hashtable();
//playerList.Add("24", "Kobe Bryant");
//playerList.Add("23", "Michael Jordan");
//playerList.Add("3", "Allen Iverson");

////playerList.Clear(); // Bütün memberları siler

//bool res1 = playerList.Contains("24");
//bool res2 = playerList.ContainsKey("8");
//bool res3 = playerList.ContainsValue("Allen Iverson");

////Console.WriteLine(res1); // true
////Console.WriteLine(res2); // false
////Console.WriteLine(res3); // true

//ICollection keys = playerList.Keys;
//foreach (string key in keys)
//{
//    Console.WriteLine(key); // 23 24 ve 3'ü alırsın
//}

//playerList.Remove("23"); // Jordan silinir

//// Clone object döndürür
//object obj = playerList.Clone(); // boxing
//Hashtable newPlayersList = obj as Hashtable; // unboxing

//// DictionaryEntry key value çiftlerini üzerinde taşır
//foreach (DictionaryEntry de in newPlayersList)
//{
//    Console.WriteLine($"[{de.Key}]: {de.Value}");
//    // [3]: Allen Iverson
//    // [24]: Kobe Bryant
//}

//Console.ReadLine();
#endregion

#region SortedList
// Küçük veri setlerinde hızlı çalışır.
// 2 tür tanımlama: biri type alır diğeri almaz.

SortedList cities = new SortedList(); // object bekler
// SortedList<int, string> cities2 = new SortedList<int, string>(); // verdiğimiz veri tiplerini bekler

cities.Add(31, "Hatay");
cities.Add(34, "İstanbul");
cities.Add(6, "Ankara");

//cities.Clear();
int elementCount = cities.Count;

IList keys = cities.GetKeyList();
//IList values= cities.GetValueList();
//foreach (int key in keys)
//{
//    Console.WriteLine(key); //5 31 34 döner
//}

cities.Remove(31); 
cities.RemoveAt(0); // index

cities.Contains(31); // key'e göre çalışır
cities.ContainsKey(31); 
cities.ContainsValue("İstanbul");

// herhangi bir index'teki key'i almak için:
int key = (int)cities.GetKey(0); // obje döner
Console.WriteLine(key);
    
#endregion
