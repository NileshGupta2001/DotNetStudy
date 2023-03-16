// See https://aka.ms/new-console-template for more information
using System.Collections;
using CollectionStudy;

Console.WriteLine("Hello, World!");
ArrayList arrayList = new ArrayList();
arrayList.Add("ranveer");
arrayList.Add(10);
arrayList.Add(false);
arrayList.Add(20.1);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

List<string> list = new List<string>(); //generic list
list.Add("ranveer");
list.Add("nilesh");
foreach (var item in list)
{
    Console.WriteLine(item);
}

List<int> intlist = new List<int>();

//Dictionary Study ->(stores in key:value pair)
Dictionary<string, int> intdict = new Dictionary<string, int>();
intdict.Add("nilesh", 1);
intdict.Add("ranveer", 2);
intdict.Add("anshu", 3);
intdict.Add("rahul", 4);
Console.WriteLine(intdict["nilesh"]); // To print Value
foreach(string key in intdict.Keys) //To Print Keys
{
    Console.WriteLine(key); 
}

Student obj1 = new Student();
Student obj2 = new Student();
obj1.Name = "Nilesh";
obj1.StudID = 1;
obj2.Name = "Ranveer";
obj2.StudID = 2;
Dictionary<string, Student> myStudDict = new Dictionary<string, Student>();
myStudDict.Add("Key1", obj1);
myStudDict.Add("Key2", obj2);


