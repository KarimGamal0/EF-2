using EF_2.Context;
using EF_2.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AirlineDbContext dbContext = new AirlineDbContext();
            //a.Insert a new airline named "EgyptAir" with contact person "Ahmed Ali", phone "0123456789" and “0113654789”, and address "Cairo".

            //Airline airline = new Airline()
            //{
            //    Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Address = "Cairo",
            //    Phones = new HashSet<Phone>()
            //    {
            //        new Phone{Number = "0123456789"},
            //        new Phone{Number = "0113654789"}
            //    }

            //};

            //dbContext.Airlines.Add(airline);
            //dbContext.SaveChanges();

            //b.Add a new aircraft with model "Model01", capacity 180, and airline = "EgyptAir".
            //Aircraft aircraft = new Aircraft()
            //{
            //    Model = "Model01",
            //    Capacity = 180,
            //    AirlineId = 18
            //};

            //dbContext.Aircrafts.Add(aircraft);
            //dbContext.SaveChanges();

            //c.Record a new transaction of amount 50000 with description "Tickets" for "EgyptAir".
            //Transaction transaction = new Transaction()
            //{
            //    Amount = 50000,
            //    Description = "Tickets",
            //    AirlineId = 18
            //};
            //dbContext.Transactions.Add(transaction);
            //dbContext.SaveChanges();

            //d.Select all employees who work in "EgyptAir"

            //var emps = dbContext.Empolyees.Where(E => E.AirlineId == 18);

            //foreach (var e in emps)
            //{
            //    Console.WriteLine(e.Name);
            //}

            //e.Show all transactions (id, description, amount) recorded by "EgyptAir".
            //var trans = dbContext.Transactions.Where(T => T.AirlineId == 18);
            //foreach (var transaction in trans) {
            //    Console.WriteLine(transaction.Id);
            //    Console.WriteLine(transaction.Description);
            //    Console.WriteLine(transaction.Amount);
            //}

            //d.Get the total number of employees working in each airline.

            //var empCounts = dbContext.Empolyees
            //    .GroupBy(a => a.AirlineId)
            //    .Select(group => new
            //    {
            //        key = group.Key,
            //        tot = group.Count()
            //    }
            //    );

            //foreach (var emp in empCounts) {
            //    Console.WriteLine(emp);
            //}

            //g.Change the capacity of the “Model01”  aircraft to 200.
            //var aircraft = dbContext.Aircrafts.Where(A => A.Model == "Model01").FirstOrDefault();

            //if (aircraft != null)
            //{

            //    Console.WriteLine(aircraft.Capacity);
            //    aircraft.Capacity = 200;
            //    dbContext.SaveChanges();
            //}


            //h.Delete all transactions older than 2020.
            //dbContext.Transactions.Where(e => e.Date.Year <= 2020).ExecuteDelete();

            //i.Insert a new route from "Cairo" to "Dubai", classification "International", distance 2400 km.

            //Route route = new Route()
            //{
            //    Origin = "Cairo",
            //    Destionation = "Dubai",
            //    Classification = "International",
            //    Distance = 2400
            //};

            //dbContext.Routes.Add(route);
            //dbContext.SaveChanges();

            //j.Assign  “Model01”  aircraft to Route From  "Cairo" to "Dubai". With duration 4 hours, price 3000 LE




        }
    }
}
