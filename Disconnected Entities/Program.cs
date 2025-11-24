
using Disconnected_Entities.Models;

var context = new AppDb();
var person = new Person("Mehrshad", "Khaki");
context.Persons.Add(person);    
context.SaveChanges();
Console.WriteLine("succeeded");



Console.ReadKey();