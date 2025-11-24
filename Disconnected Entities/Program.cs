
using Disconnected_Entities.Models;


// entities states with respect to tracking: (Tracked, Detached, Disconnected)

var context = new AppDb();
//var person = new Person("Mehrshad", "Khaki");
//context.Persons.Add(person);    
//context.SaveChanges();
//Console.WriteLine("succeeded");

var person = context.Persons.First();
context.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
person.Name = "Ahmad";
context.SaveChanges();
Console.WriteLine($" state is : {context.Entry(person).State}");
Console.WriteLine("succeeded");


Console.ReadKey();