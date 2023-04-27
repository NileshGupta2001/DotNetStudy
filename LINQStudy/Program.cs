// See https://aka.ms/new-console-template for more information
using LINQStudy;
using System.Collections;
using static LINQStudy.Car;
// What is LINQ
//Language Integrated Query(LINQ) 
//used to perform SQL operations on Dotnet
//using Linq we can work with XML,JSON data 
//System.Linq library required

#region LinqIntroduction
/*
int[] scores = { 97, 92,  81, 60 };
//Select sc from scores where sc>90
IEnumerable<int> scoresQuery = from sc in scores where sc > 90 select sc; //QueryExpression
var QueryResult = scores.Where(x => x > 90); //through Linq methods


//IEnumerabe is used to store collection
//to read collection use for each loop
foreach (int score in QueryResult)
{
    Console.WriteLine(score);
}
*/
#endregion


#region Anony-Lambda
//HW : ANONYMOUS LAMBDA C#
/*
Print prnt = delegate (string val) {
    Console.WriteLine("Anonymous method: {0}", val);
};
prnt("nilesh");
Print p = a => Console.WriteLine(a); //lambda expression
p("ranveer");
*/
#endregion
/*
 * 1: Where
2: Select and Select Many
3: First , FirstOrDefault
4: Last, LastorDefault
5: Single and SingleOrDefault
6: Iquerable and IEnumarable
7: Lazy loading
 */
#region MasterData
Course course1 = new Course()
{
    CourseID = 1,
    CourseName = "Java"
};
Course course2 = new Course()
{
    CourseID = 2,
    CourseName = "Dotnet"
};
Course course3 = new Course()
{
    CourseID = 3,
    CourseName = "Python"
};
Student student1 = new Student()
{
    StudentID = 1,
    StudName = "Nilesh",
    Marks = 90

};
student1.EnrolledCourses.Add(course1);
student1.EnrolledCourses.Add(course2);
Student student2 = new Student()
{
    StudentID = 2,
    StudName = "Nile",
    Marks=95

};
Student student3 = new Student()
{
    StudentID = 3,
    StudName = "Nilesh",
    Marks=100
};
student2.EnrolledCourses.Add(course3);
student3.EnrolledCourses.Add(course1);
List<Student> lstStudents = new List<Student>();
lstStudents.Add(student1);
lstStudents.Add(student2);
#endregion

#region Where
//var result = lstStudents.Where(x => x.StudName.StartsWith('N'));  // Selects everything
//foreach(var item in result)
//{
//    Console.WriteLine(item.StudName);
//}
#endregion

#region Select
//var result1 = lstStudents.Select(x => x.StudName); //Selects particular columns
//var result2 = lstStudents.Select(x => new{x.StudName,x.StudentID}); //Selects mul//tiple columns

//var result1 = lstStudents.Select(x => x.EnrolledCourses);
//foreach (var item in result1)
//{
//    foreach (var course in item)
//    {
//        Console.WriteLine(course.CourseName);
//        //Console.WriteLine(item.StudentID);
//    }
//}
#endregion

#region SelectMany

//var resultmany = lstStudents.SelectMany(x => x.EnrolledCourses);
//foreach (var item in resultmany)
//{
//    Console.WriteLine(item.CourseName);
//}
#endregion

#region First
//var result = lstStudents.First(x => x.StudName=="Nilesh");
//Console.WriteLine(result.StudName);
#endregion

#region FirstDefault
//var result1 = lstStudents.FirstOrDefault(x => x.StudName == "suraj");
//if(result1!=null)
//{
//    Console.WriteLine(result1.StudName);
//}
//Last/LastorDefault will display the last record
#endregion

#region Single
//var result = lstStudents.Single(x => x.StudName == "Nilesh");
////Displays only single records with a value
//// will fail if multiple records exist of the same value
//Console.WriteLine(result.StudName);

#endregion

#region SingleDefault
//var resultDefault = lstStudents.SingleOrDefault(x => x.StudName == "Nilesh");
////Displays only single records with a value
//// will fail if multiple records exist of the same value
//if (resultDefault != null)
//{
//    Console.WriteLine(resultDefault.StudName);
//}
#endregion

#region ElementAt
//var resultDefault = lstStudents.ElementAt(1);
////Displays record at third position(or position that is specified)
//Console.WriteLine(resultDefault.StudName);
#endregion

#region GroupBy
//var resultGrpBy = lstStudents.GroupBy(x=>x.Marks);
////Displays records according to the group (same as sql)
//Console.WriteLine();
#endregion

#region OrderBy
//var resultOrdBy = lstStudents.OrderBy(x => x.StudentID);
//var resultOrdBy = lstStudents.OrderByDescending(x => x.StudentID);
//Sorts the records in ascending order
Console.WriteLine();
#endregion

//HW ALL OR ANY, ORDER BY DESC, 
#region All
//var resultAll= lstStudents.All(x => x.StudName.StartsWith('N')); //true if all records are preset 
//var resultAny = lstStudents.Any(x => x.StudName.StartsWith('N')); //true if any record is present
//Console.WriteLine(resultAny);
//Console.WriteLine(resultAll);
#endregion

#region LazyLoadingAndEagerLoading
var result = lstStudents.Take(1);//.Where(x => x.StudName.StartsWith('N'));
foreach(var item in result)
{
    Console.WriteLine(item.StudName);
}
#endregion

//IEnumerable and Iqueryable interfaces

//IEnumerable -> LINQ to object / linq to xml
//Iqueryable -> LINQ to sql queries