
using Disconnected_Entities.Models;
using Microsoft.EntityFrameworkCore;

// entities states with respect to tracking: (Tracked, Detached, Disconnected)

var context = new AppDb();
//var person = new Person("Mehrshad", "Khaki");
//context.Persons.Add(person);    
//context.SaveChanges();
//Console.WriteLine("succeeded");

//var person = context.Persons.First();
//context.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
//person.Name = "Ahmad";
//context.SaveChanges();

var person = new Person("Mehdi", "Ahmadvand");
if (person.Id == 0)
    context.Entry(person).State = EntityState.Added;
else if (person.Id == 1)
    context.Entry(person).State = EntityState.Modified;

Console.WriteLine($" state is : {context.Entry(person).State}");
Console.WriteLine("succeeded");
context.SaveChanges();
Console.WriteLine($" state is : {context.Entry(person).State}");


Console.ReadKey();